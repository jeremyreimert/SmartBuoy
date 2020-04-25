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
using System.Configuration;
using System.Data.Linq;

namespace SmartBuoySimulator
{
    /*************************************************************
     * SmartBuoy inherits DataContext 
     * An instance of class will act as connection to the database 
     *************************************************************/
    class SmartBuoyDB : DataContext
    {
        private static readonly String Login = ConfigurationManager.ConnectionStrings["connect"].ConnectionString; // connection string
        public Table<SimulatedReading> Reading; 

        public SmartBuoyDB() : base(Login)
        {
        }
    }
}
