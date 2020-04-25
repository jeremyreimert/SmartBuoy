/**************************************************************************************
 * NAME:        Jeremy Reimert
 * DATE:        April 25, 2020
 * PROJECT:     SmartBuoy Dashboard
 * DESCRIPTION: This program creates a user interface for viewing data from SmartBuoy.
 *              SmartBuoy was built to measure and transmit water quaity data.
 *              Data is live streamed and stored in a database.
 * 
 *              The application has two main functions:
 *              1. To retrieve historic data from a database. 
 *              2. To retrieve live streaming data using the Dweet.io service. 
 * 
 *              In both cases, data is presented within a dataGridView, a line chart, 
 *              and customized gauges. Location data is used to plot points on a map.  
 **************************************************************************************/

using Microsoft.Maps.MapControl.WPF;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace SmartBuoyDashboard
{
    /****************************************************************
     * Dashboard contains the components and event 
     * handlers that make up the programs GUI
     ****************************************************************/
    public partial class Dashboard : Form
    {
        Reading reading = new Reading(); // creates a Reading object to hold retreived data
        DateTime lastDT; // stores a DateTime used in the timer

        /****************************************************************************
         * Constuctor initializes the form 
         ***************************************************************************/
        public Dashboard()
        {
            try
            {
                InitializeComponent();
                clearGauges(); // reset gauges

                LiveTimer.Interval = 15000; // set timer

                // set today as max date
                dtStart.MaxDate = DateTime.Today; 
                dtEnd.MaxDate = DateTime.Today;

                dataHistory.RowCount = 22; // initialize DGV 

                //Set Credentials for map
                BuoyMap.Map.CredentialsProvider = new ApplicationIdCredentialsProvider("AsUGlAVgyrC0JDqPbdWVcIny1gHMMTYtBGVM4kcTE4nVqq32LbYttky3tPDA9SLw");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogError(ex);
            }
        }

        /****************************************************************************
         * btnHistoric_Click retreives data from the database. The user specifies the
         * start and end dates. If the end date is before the start date an error is 
         * thrown. The data retrieved is shown in the dataGridview, gauges, and chart
         * Latitudes and longitdes are plotted as points on the map.
         ***************************************************************************/
        private void btnHistoric_Click(object sender, EventArgs e)
        {
            try
            { 
                SmartBuoyDB sb = new SmartBuoyDB(); // for the database connection
                 
                // Toggle button text color
                btnHistoric.ForeColor = Color.OrangeRed;
                btnHistoric.Refresh();
                btnLive.ForeColor = Color.White;
                btnLive.Refresh();

                rangeSlider.Enabled = true; // activate the slider
                LiveTimer.Enabled = false; // stop the timer

                if (dtStart.Value <= dtEnd.Value) // check that start date is earlier than end date
                {
                    dataHistory.Columns.Clear(); // clear the DGV

                    // retreive rows from the database and add to the datagridview
                    dataHistory.DataSource = from read in sb.GetTable<Reading>() where read.readingDT >= dtStart.Value && read.readingDT <= dtEnd.Value orderby read.readingDT ascending select read; 

                    // Show message if no data was retrieved
                    if (dataHistory.RowCount == 0)
                    {
                        MessageBox.Show("No Data Available for the Selected Range");
                    }
                    else
                    {
                        dataHistory.Sort(dataHistory.Columns.GetFirstColumn(0), 0); // sort rows by dateTime

                        BuoyMap.Map.ZoomLevel = 7; // set map zoom
                        BuoyMap.Map.Children.Clear(); // clear the map

                        // Add pins tom the map
                        for (int i = 0; i < dataHistory.Rows.Count - 1; i++)
                        {
                            // set LAT and LON with data from DGV cells
                            reading.latitude = Convert.ToDecimal(dataHistory.Rows[i].Cells[7].Value);
                            reading.longitude = Convert.ToDecimal(dataHistory.Rows[i].Cells[8].Value);

                            setMapPin(); // create an set pins 
                        }

                        int max = dataHistory.Rows.Count - 1; // set max to the number of retrieved rows

                        // check data in all grid cells
                        for(int i = 0; i <= max; i++)
                        {
                            checkLimits(i);
                        }

                        // set properties of rangeSlider
                        rangeSlider.Maximum = max; 
                        rangeSlider.Value = max;

                        // set DGV row selection
                        dataHistory.ClearSelection();
                        dataHistory.Rows[max].Selected = true;

                        rangeSlider.Focus(); // set focus to the rangeSlider

                        rowToReading(max); // set values of Reading data members with values from the DGV row

                        setGauges(); // set gauge values
                         
                        setChart(max); // create the chart
                    }
                }
                else
                {
                    MessageBox.Show("Error: The starting date must\nbe earlier than the ending date");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogError(ex);
            }
        }

        /*****************************************************************************
        * btnLive_ClickAsync enables LiveTimer and clears the map, gauges, chart, grid
        ******************************************************************************/
        private void btnLive_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                // Toggle button text color
                btnLive.ForeColor = Color.OrangeRed;
                btnLive.Refresh();
                btnHistoric.ForeColor = Color.White;
                btnHistoric.Refresh();

                lblGet.Visible = true; // alerts user of connection to SmartBuoy
                rangeSlider.Enabled = false; // disable slider

                BuoyMap.Map.ZoomLevel = 7; // set map zoom
                BuoyMap.Map.Children.Clear(); // clear the map

                clearGauges(); // clear gauges

                // clear the chart
                foreach (var series in lineChart.Series)
                {
                    series.Points.Clear();
                }

                dataHistory.DataSource = null; // clear the DGV

                // Add columns to DGV
                dataHistory.Columns.Add("column1", "TimeStamp");
                dataHistory.Columns.Add("column2", "Battery");
                dataHistory.Columns.Add("column3", "Temperature");
                dataHistory.Columns.Add("column4", "pH");
                dataHistory.Columns.Add("column5", "Conductivity");
                dataHistory.Columns.Add("column6", "TDS");
                dataHistory.Columns.Add("column7", "Turbidity");
                dataHistory.Columns.Add("column8", "Latitude");
                dataHistory.Columns.Add("column9", "Longitude");

                dataHistory.RowCount = 0; 

                LiveTimer.Enabled = true; // start the timer
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogError(ex);
            }
        }

        /****************************************************************************
        * LiveTimer_Tick retrieves the latest reading from dweet.io. The data is 
        * added to the chart, map, gauges, and a new row in the DGV.
        * Comparing DATETIME values prevents duplicate rows from being added
        ***************************************************************************/
        private void LiveTimer_Tick(object sender, EventArgs e)
        {
            reading = ReadingProxy.WebResponse(); // get reading

            if (reading.readingDT != lastDT) // prevents duplicate readings from being added 
            {
                dataHistory.Rows.Add(); // create a new row

                int row = dataHistory.RowCount - 1; // set the row number

                lblGet.Visible = false; // turn off "connecting" noification

                readingToRow(row); // add reading to the new row

                checkLimits(row); // check cell values

                setGauges(); // set the gauges with the reading

                setMapPin(); // add a pin 

                setChart(row); // update the chart

                lastDT = reading.readingDT; // set previous DateTime with current DateTime
            }
        }

        /****************************************************************************
         * rangeSlider_Scroll increments or decrements rangeSlider.Value, which 
         * corresponds to a row from the dataGridView. Cell values of that row are 
         * used to set gauges and become the last values added to the chart and map 
         ***************************************************************************/
        private void rangeSlider_Scroll(object sender, EventArgs e)
        {
            try
            {
                int row = rangeSlider.Value; // set the row number to the value of the slider

                // clear row selection
                dataHistory.ClearSelection();
                dataHistory.Rows[row].Selected = true;

                rowToReading(row); // set values of Reading data members with values from the DGV row

                setGauges(); // set the gauge values

                BuoyMap.Map.Children.Clear(); // clear the map

                // Add pins tom the map
                for (int i = 0; i <= row; i++)
                {
                    // set LAT and LON with data from DGV cells
                    reading.latitude = Convert.ToDecimal(dataHistory.Rows[i].Cells[7].Value);
                    reading.longitude = Convert.ToDecimal(dataHistory.Rows[i].Cells[8].Value);

                    setMapPin(); // set pin
                }

                // set MIN and MAX values of lineChart
                lineChart.ChartAreas[0].AxisX.Minimum = 1;
                lineChart.ChartAreas[0].AxisX.Maximum = rangeSlider.Value + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogError(ex);
            }
        }

        /****************************************************************************
         * btnZoomIn_Click increments the value of BuoyMap.Map.ZoomLevel 
         ***************************************************************************/
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            try
            {
                BuoyMap.Map.ZoomLevel++; // increment zoom level
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogError(ex);
            }
        }

        /****************************************************************************
         * btnZoomOut_Click decrements the value of BuoyMap.Map.ZoomLevel 
         ***************************************************************************/
        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            try
            {
                BuoyMap.Map.ZoomLevel--; // decrement zoom level
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogError(ex);
            }
        }

        /*****************************************************************************
       * dtStart_ValueChanged sets the Min date of dtEnd 
       * to the Value of dtStart when dtStart.Value changes
       * ****************************************************************************/
        private void dtStart_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtEnd.MinDate = dtStart.Value; // set min date
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogError(ex);
            }
        }

        /*****************************************************************************
        * dtEnd_ValueChanged sets the Max date of dtStart
        * to the Value of dtEnd when dtEnd.Value changes
        * ****************************************************************************/
        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtStart.MaxDate = dtEnd.Value; // set max date
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogError(ex);
            }
        }

        /****************************************************************************
         * setGauges sets the gauge Value and gauge Text to the 
         * values of the Reading object data members
         * **************************************************************************/
        private void setGauges()
        {
            try
            {
                // Set Value
                gaugeBatt.Value = Convert.ToInt32(reading.battery * 10);
                gaugeTemp.Value = Convert.ToInt32(reading.temperature * 10);
                gaugePH.Value = Convert.ToInt32(reading.pH * 10);
                gaugeEC.Value = Convert.ToInt32(reading.conductivity);
                gaugeTDS.Value = Convert.ToInt32(reading.dissolvedSolids);
                gaugeTurb.Value = Convert.ToInt32(reading.turbidity * 10);

                // Set Text
                gaugeBatt.Text = reading.battery.ToString("0.0");
                gaugeTemp.Text = reading.temperature.ToString("#0.0");
                gaugePH.Text = reading.pH.ToString("#0.0");
                gaugeEC.Text = reading.conductivity.ToString("####");
                gaugeTDS.Text = reading.dissolvedSolids.ToString("####");
                gaugeTurb.Text = reading.turbidity.ToString("0.0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogError(ex);
            }
        }

        /****************************************************************************
         * clearGauges resets the gauges - sets Value to 0 and Text to "0.0"
         * **************************************************************************/
        private void clearGauges()
        {
            try
            {
                // set Value to 0
                gaugeBatt.Value = 0;
                gaugeTemp.Value = 0;
                gaugePH.Value = 0;
                gaugeEC.Value = 0;
                gaugeTDS.Value = 0;
                gaugeTurb.Value = 0;

                // set Text to "0.0"
                gaugeBatt.Text = "0.0";
                gaugeTemp.Text = "0.0";
                gaugePH.Text = "0.0";
                gaugeEC.Text = "0.0";
                gaugeTDS.Text = "0.0";
                gaugeTurb.Text = "0.0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogError(ex);
            }
        }

        /****************************************************************************
         * setMapPin adds a pin to the map
         * **************************************************************************/
        private void setMapPin()
        {
            try
            {
                Pushpin pin = new Pushpin(); // create Pushpin object
                pin.Location = new Microsoft.Maps.MapControl.WPF.Location((double)reading.latitude, (double)reading.longitude); //set pin location
                BuoyMap.Map.Children.Add(pin); // add pin to map
                BuoyMap.Map.Center = pin.Location; // center map on pin
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogError(ex);
            }
        }

        /****************************************************************************
         * setChart accepts an int representing the maximum DGV row number
         * creates the chart from the DGV rows
         * **************************************************************************/
        private void setChart(int max)
        {
            try
            {
                // clear chart
                foreach (var series in lineChart.Series)
                {
                    series.Points.Clear();
                }

                lineChart.ChartAreas[0].AxisX.Maximum = max + 1; // set X axis max value

                // read each row of DGV
                for (int i = 0; i <= max; i++)
                {
                    // read each cell of DGV row 
                    for (int j = 0; j < 6; j++)
                    {
                        int p = lineChart.Series[j].Points.AddXY(i + 1, dataHistory[j + 1, i].Value); // create data point from cell value
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogError(ex);
            }
        }

        /****************************************************************************
         * rowToReading accepts an integer representing a row number. Assigns the 
         * values of the cells in a DataGridView row to the Reading object data members
         * **************************************************************************/
        private void rowToReading(int row)
        {
            try
            {
                // sets the value of the Reading data members to to the cell values of the DGV row
                reading.battery = Convert.ToDecimal(dataHistory.Rows[row].Cells[1].Value);
                reading.temperature = Convert.ToDecimal(dataHistory.Rows[row].Cells[2].Value);
                reading.pH = Convert.ToDecimal(dataHistory.Rows[row].Cells[3].Value);
                reading.conductivity = Convert.ToDecimal(dataHistory.Rows[row].Cells[4].Value);
                reading.dissolvedSolids = Convert.ToDecimal(dataHistory.Rows[row].Cells[5].Value);
                reading.turbidity = Convert.ToDecimal(dataHistory.Rows[row].Cells[6].Value);
                reading.latitude = Convert.ToDecimal(dataHistory.Rows[row].Cells[7].Value);
                reading.longitude = Convert.ToDecimal(dataHistory.Rows[row].Cells[8].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogError(ex);
            }
        }

        /****************************************************************************
         * readingToRow accepts an integer representing a row number. Assigns the value
         * of the Reading object data members to cells of the row in the DataGridView.
         * **************************************************************************/
        private void readingToRow(int row)
        {
            try
            {
                // sets the cell values of a row to the values of the Reading data members
                dataHistory.Rows[row].Cells[0].Value = reading.readingDT;
                dataHistory.Rows[row].Cells[1].Value = reading.battery.ToString("0.0");
                dataHistory.Rows[row].Cells[2].Value = reading.temperature.ToString("#0.0");
                dataHistory.Rows[row].Cells[3].Value = reading.pH.ToString("#0.0");
                dataHistory.Rows[row].Cells[4].Value = reading.conductivity.ToString("####");
                dataHistory.Rows[row].Cells[5].Value = reading.dissolvedSolids.ToString("####");
                dataHistory.Rows[row].Cells[6].Value = reading.turbidity.ToString("0.0");
                dataHistory.Rows[row].Cells[7].Value = reading.latitude.ToString("###.######");
                dataHistory.Rows[row].Cells[8].Value = reading.longitude.ToString("###.######");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogError(ex);
            }
        }

        /***********************************************************************
         * checkLimits tests all grid cell values in a given row against a range 
         * of acceptable values. Any cell out of range is highlighted in red 
         ***********************************************************************/
        private void checkLimits(int row)
        {
            RangeLimitAlert limit = new RangeLimitAlert(); // RangeLimitAlert object

            // if battery value is in range
            if (limit.isVoltageWithinLimit(Convert.ToDecimal(dataHistory.Rows[row].Cells[1].Value)))
            {
                dataHistory.Rows[row].Cells[1].Style.BackColor = Color.White; // set background color to white 
            }
            else // if the value is out of range
            {
                dataHistory.Rows[row].Cells[1].Style.BackColor = Color.Red; // set background color to red
            }

            // if temperature value is in range
            if (limit.isTempWithinLimit(Convert.ToDecimal(dataHistory.Rows[row].Cells[2].Value)))
            {
                dataHistory.Rows[row].Cells[2].Style.BackColor = Color.White; // set background color to white
            }
            else // if the value is out of range
            {
                dataHistory.Rows[row].Cells[2].Style.BackColor = Color.Red; // set background color to red
            }

            // if pH value is in range
            if (limit.isPhWithinLimit(Convert.ToDecimal(dataHistory.Rows[row].Cells[3].Value)))
            {
                dataHistory.Rows[row].Cells[3].Style.BackColor = Color.White; // set background color to white
            }
            else // if the value is out of range
            {
                dataHistory.Rows[row].Cells[3].Style.BackColor = Color.Red; // set background color to red
            }

            // if conductivity value is in range
            if (limit.isConductivityWithinLimit(Convert.ToDecimal(dataHistory.Rows[row].Cells[4].Value)))
            {
                dataHistory.Rows[row].Cells[4].Style.BackColor = Color.White; // set background color to white
            }
            else // if the value is out of range
            {
                dataHistory.Rows[row].Cells[4].Style.BackColor = Color.Red; // set background color to red
            }

            // if dissolved solids value is in range
            if (limit.isDissolvedSolidsWithinLimit(Convert.ToDecimal(dataHistory.Rows[row].Cells[5].Value)))
            {
                dataHistory.Rows[row].Cells[5].Style.BackColor = Color.White; // set background color to white
            }
            else // if the value is out of range
            {
                dataHistory.Rows[row].Cells[5].Style.BackColor = Color.Red; // set background color to red
            }

            // if turbidity value is in range
            if (limit.isTurbidityWithinLimit(Convert.ToDecimal(dataHistory.Rows[row].Cells[6].Value)))
            {
                dataHistory.Rows[row].Cells[6].Style.BackColor = Color.White; // set background color to white
            }
            else // if the value is out of range
            {
                dataHistory.Rows[row].Cells[6].Style.BackColor = Color.Red; // set background color to red
            }
        }
    }
}
