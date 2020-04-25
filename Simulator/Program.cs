/**********************************************************************************
 * NAME: Jeremy Reimert
 * DATE: February 7, 2020
 * PROJECT: SmartBuoy Simulator
 * DESCRIPTION: This project was meant to be a user interface for viewing data from
 * a device created to measure the quality of water. However, because this is an
 * online course their is no access to the physical device. This application takes 
 * the place of the device by producing random numbers, within a set range, for
 * each of the measurements. Then, just as the actual device would, the application
 * broadcasts the data both as a continuous stream and periodically to a database. 
 **********************************************************************************/

using System;
using System.Windows.Forms;

namespace SmartBuoySimulator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Simulator());
        }
    }
}
