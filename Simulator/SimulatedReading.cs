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
using System.Data.Linq.Mapping;

namespace SmartBuoySimulator
{
    /******************************************************
     * The SimulatedReading class contains properties to 
     * set and get the values of each measurement
     * ***************************************************/

    [Table(Name = "Reading")] // links class with database table
    public class SimulatedReading
    {
        // reading variables associated with column of table
        [Column(IsPrimaryKey = true)]
        public DateTime readingDT { get; set; }
        [Column]
        public decimal battery { get; set; }
        [Column]
        public decimal temperature { get; set; }
        [Column]
        public decimal pH { get; set; }
        [Column]
        public decimal conductivity { get; set; }
        [Column]
        public decimal dissolvedSolids { get; set; }
        [Column]
        public decimal turbidity { get; set; }
        [Column]
        public decimal latitude { get; set; }
        [Column]
        public decimal longitude { get; set; }

        public SimulatedReading()
        {
            GetReading();
        }

        /**********************************************************************************
         * GetReading creates random numbers, formats them, and then assigns them to
         * members of the SimulatedReading class 
         **********************************************************************************/
        private void GetReading()
        {
            try
            {
                Random random = new Random();

                readingDT = DateTime.Now;

                battery = (decimal)random.Next(30, 51) / 10;  // 3 - 5

                pH = (decimal)random.Next(60, 96) / 10; // 60 - 95

                temperature = (decimal)random.Next(150, 251) / 10; // 150 - 250

                conductivity = (decimal)random.Next(600, 951); // 600 - 950

                dissolvedSolids = (decimal)random.Next(100, 351); // 100 - 350

                turbidity = (decimal)random.Next(10, 101) / 10; // 1 - 10

                longitude = (decimal)random.Next(7680000, 7900001) / -100000; //-76.80000 - -79.00000

                latitude = (decimal)random.Next(4338000, 4383001) / 100000; // -43.38000 - 43.83000 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.LogError(ex);
            }
        }
    }
}
