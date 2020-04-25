/**************************************************************************************
 * NAME:        Jeremy Reimert
 * DATE:        April 25, 2020
 * PROJECT:     SmartBuoy Simulator
 * DESCRIPTION: This program simulates the operation of SmartBuoy. 
 *              SmartBuoy was built to measure and transmit water quaity data.
 *              Data is live streamed and stored in a database.
 * 
 *              The application has three main functions:
 *              1. Generate random numbers for each measurement
 *              2. Transmit streaming data via Dweet.io 
 *              3. Transmit data to a database
 **************************************************************************************/

using System;
using System.Threading;
using System.Windows.Forms;

namespace SmartBuoySimulator
{
    /****************************************************************
     * Simulator contains the components and event 
     * handlers that make up the programs GUI
     ****************************************************************/
    public partial class Simulator : Form
    {
        private bool PowerIsOn; // the status of the device

        /**************************************************
         * Constructor initializes form
         **************************************************/
        public Simulator()
        {
            InitializeComponent();
            PowerIsOn = false; 
            ReadingTimer.Interval = 15000; 
        }

        /**********************************************************************************
         * CycleLEDs()
         * Repeatedly calls the FlashLED method, passing a series of PictureBoxes 
         * This is used to give the impression of the device performing operations  
         **********************************************************************************/
        public void CycleLEDs()
        {
            try
            {
                FlashLED(indicatorBATT);
                FlashLED(indicatorTEMP);
                FlashLED(indicatorPH);
                FlashLED(indicatorEC);
                FlashLED(indicatorTDS);
                FlashLED(indicatorTURB);
                FlashLED(indicatorGPS);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogError(ex);
            }
        }

        /**********************************************************************************
         * FlashLED(PictureBox picBox)
         * toggles the PictureBox images to simulate an LED turning on and off 
         **********************************************************************************/
        private void FlashLED(PictureBox picBox)
        {
            try
            {
                picBox.Image = SmartBuoySimulator.Properties.Resources.LED_GreenOn;
                picBox.Refresh();
                Thread.Sleep(200);
                picBox.Image = SmartBuoySimulator.Properties.Resources.LED_GreenOff;
                picBox.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogError(ex);
            }
        }

        /**********************************************************************************
        * btnPowerOn_Click(object sender, EventArgs e)
        * Powers on the unit: sets PowerIsOn to true and enables ReadingTimer
        **********************************************************************************/
        private void btnPowerOn_Click(object sender, EventArgs e)
        {
            try
            {
                btnPowerOn.Enabled = false;
                btnPowerOff.Enabled = true;

                if (!PowerIsOn)
                {
                    PowerIsOn = true;
                    indicatorPower.Image = SmartBuoySimulator.Properties.Resources.LED_RedOn;
                    indicatorPower.Refresh();
                    ReadingTimer.Enabled = true; // start the timer
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogError(ex);
            }
        }

        /**********************************************************************************
        * btnPowerOff_Click(object sender, EventArgs e)
        * Powers down the unit: sets PowerIsOn to false and disables ReadingTimer       
        **********************************************************************************/
        private void btnPowerOff_Click(object sender, EventArgs e)
        {
            try
            {
                btnPowerOn.Enabled = true;
                btnPowerOff.Enabled = false;

                if (PowerIsOn)
                {
                    PowerIsOn = false;
                    indicatorPower.Image = SmartBuoySimulator.Properties.Resources.LED_RedOff;
                    indicatorPower.Refresh();
                    ReadingTimer.Enabled = false; // stop the timer
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogError(ex);
            }
        }

        /**********************************************************************************
        * ReadingTimer_TickAsync(object sender, EventArgs e)
        * Creates a reading and sends it to dweet.io
        * Every 240 readings (1 hour) send reading to database
        **********************************************************************************/
        private async void ReadingTimer_TickAsync(object sender, EventArgs e)
        {
            try
            {
                SimulatedReading reading = new SimulatedReading(); // create reading
                SmartBuoyDB sb = new SmartBuoyDB(); //for database connection
               
                int counter = 1; // set counter

                CycleLEDs(); // LEDS

                if (RangeValidator.isValidReading(reading)) // validate data
                {
                    indicatorLIVE.Image = SmartBuoySimulator.Properties.Resources.LED_GreenOn;

                    await DweetStream.BroadcastLive(reading); // send to dweet.io

                    indicatorLIVE.Image = SmartBuoySimulator.Properties.Resources.LED_GreenOff;

                    counter++; // increment counter

                    if (counter == 240) // every 240 readings (1 hour) insert data into database
                    {
                        indicatorSQL.Image = SmartBuoySimulator.Properties.Resources.LED_GreenOn;
                        indicatorSQL.Refresh();

                        // Insert into the database
                        sb.Reading.InsertOnSubmit(reading);
                        sb.SubmitChanges();

                        Thread.Sleep(1000);
                        indicatorSQL.Image = SmartBuoySimulator.Properties.Resources.LED_GreenOff;
                        indicatorSQL.Refresh();

                        counter = 1; // reset counter
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogError(ex);
            }
        }
    }
}





