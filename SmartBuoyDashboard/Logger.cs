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

using System;
using System.IO;
using System.Windows.Forms;

namespace SmartBuoyDashboard
{
    /******************************************************
    * The Logger class contains methods used to write
    * caught exceptions to a text file
    * ***************************************************/
    static class Logger
    {
        /******************************************************
        * LogError(Exception ex)
        * Accepts an exception and write it to a file.
        * Returns nothing
        * ***************************************************/
        public static void LogError(Exception ex)
        {
            try
            {
                string message = string.Format("Time: {0}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")); // add current date and time to message

                // add exception information to message
                message += Environment.NewLine;
                message += "-----------------------------------------------------------";
                message += Environment.NewLine;
                message += string.Format("Message: {0}", ex.Message);
                message += Environment.NewLine;
                message += string.Format("StackTrace: {0}", ex.StackTrace);
                message += Environment.NewLine;
                message += string.Format("Source: {0}", ex.Source);
                message += Environment.NewLine;
                message += string.Format("TargetSite: {0}", ex.TargetSite.ToString());
                message += Environment.NewLine;
                message += "-----------------------------------------------------------";
                message += Environment.NewLine;

                string path = PathToFile("\\ErrorLog.txt"); // path to text file

                // Write the error message tom the file
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(message);
                    writer.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /************************************************************
        * PathToFile(string localPath)
        * Accepts the local path of a file in the solution directory
        * Returns the full path as a string
        * ***********************************************************/
        private static string PathToFile(string localPath)
        {
            try
            {
                string currentDir = Environment.CurrentDirectory; // get current directory
                DirectoryInfo directory = new DirectoryInfo(
                Path.GetFullPath(Path.Combine(currentDir, @"..\..\" + localPath))); // create full path from currentDir and localPath
                return directory.ToString(); // return the full path
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return "";
            }
        }
    }
}