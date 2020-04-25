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
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBuoySimulator
{
    /*************************************************************************
     * DweetStream sends reading data to Dweet.IO through an Http connection
     *************************************************************************/
    static class DweetStream
    {
        /**********************************************************************************
        * BroadcastLIVE will take the data reading and send to the Dweet.io
        * hosting service using an HttpClient. 
       **********************************************************************************/
        public static async Task BroadcastLive(SimulatedReading sr)
        {
            try
            {
                StringBuilder dweetString = new StringBuilder();

                // build the url string
                dweetString.Append("https://dweet.io/dweet/for/SmartBuoyb97e934d5336e0?DATETIME=");
                dweetString.Append(sr.readingDT);
                dweetString.Append("&VOLTS=");
                dweetString.Append(sr.battery);
                dweetString.Append("&TEMP=");
                dweetString.Append(sr.temperature);
                dweetString.Append("&PH=");
                dweetString.Append(sr.pH);
                dweetString.Append("&EC=");
                dweetString.Append(sr.conductivity);
                dweetString.Append("&TDS=");
                dweetString.Append(sr.dissolvedSolids);
                dweetString.Append("&TURB=");
                dweetString.Append(sr.turbidity);
                dweetString.Append("&LAT=");
                dweetString.Append(sr.latitude);
                dweetString.Append("&LON=");
                dweetString.Append(sr.longitude);

                HttpClient client = new HttpClient();

                var result = await client.GetAsync(dweetString.ToString()); // connect to dweet.io
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogError(ex);
            }
        }
    }
}
