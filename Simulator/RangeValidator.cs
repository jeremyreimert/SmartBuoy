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
using System.Windows.Forms;

namespace SmartBuoySimulator
{
    /***********************************************************
     * RangeValidator contains methods to verify the 
     * measurements are within the range of the probes. 
     * Any measurement outside of the acceptable range will
     * raise an alert indicating the probe requires calibration  
     ***********************************************************/
    static class RangeValidator
    {
        /*********************************************************
        * isValidReading tests values of all measurements 
        * returns true if all values are in range
        * opens a MessageBox and returns false if out of range
        *********************************************************/
        public static Boolean isValidReading(SimulatedReading read)
        {
            if (isPositionInRange(read.latitude, read.longitude)
                && isVoltageInRange(read.battery)
                && isPhInRange(read.pH) && isTempInRange(read.temperature)
                && isConductivityInRange(read.conductivity)
                && isTurbidityInRange(read.turbidity)
                && isDissolvedSolidsInRange(read.dissolvedSolids))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Reading has not been/nbroadcast or recorded", "Device Error");
                return false;
            }
        }

        /*********************************************************
        * isPositionInRange tests value of latitude and longitude
        * returns true if value is in range
        * opens a MessageBox and returns false if out of range
        *********************************************************/
        private static Boolean isPositionInRange(decimal lat, decimal lon)
        {
            decimal LATmax = 90; // upper limit
            decimal LATmin = -90; // lower limit
            decimal LONmax = 180; // upper limit
            decimal LONmin = -180; // lower limit

            if (LATmin <= lat && lat <= LATmax && LONmin <= lon && lon <= LONmax)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Position out of range:\nCheck GPS calibration", "Device Error");
                return false;
            }
        }

        /*********************************************************
        * isVoltageInRange tests value of battery
        * returns true if value is in range
        * opens a MessageBox and returns false if out of range
        *********************************************************/
        private static Boolean isVoltageInRange(decimal volt)
        {
            decimal VOLTmin = 0; // lower limit
            decimal VOLTmax = 5; // upper limit

            if (volt >= VOLTmin && volt <= VOLTmax)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Voltage out of range:\nCheck battery calibration", "Device Error");
                return false;
            }
        }

        /*********************************************************
        * isPhInRange tests value of pH
        * returns true if value is in range
        * opens a MessageBox and returns false if out of range
        *********************************************************/
        private static Boolean isPhInRange(decimal ph)
        {
            decimal PHmin = 0; // lower limit
            decimal PHmax = 14; // upper limit

            if (ph >= PHmin && ph <= PHmax)
            {
                return true;
            }
            else
            {
                MessageBox.Show("pH out of range:\nCheck pH probe calibration", "Device Error");
                return false;
            }
        }

        /*********************************************************
        * isTempInRange tests value of temperature
        * returns true if value is in range
        * opens a MessageBox and returns false if out of range
        *********************************************************/
        private static Boolean isTempInRange(decimal temp)
        {
            decimal TEMPmin = 0; // lower limit
            decimal TEMPmax = 100; // upper limit

            if (temp >= TEMPmin && temp <= TEMPmax)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Temperature out of range:\nCheck thermometer calibration", "Device Error");
                return false;
            }
        }

        /*********************************************************
        * isConductvityInRange tests value of conductivity
        * returns true if value is in range
        * opens a MessageBox and returns false if out of range
        *********************************************************/
        private static Boolean isConductivityInRange(decimal ec)
        {
            decimal ECmin = 0; // lower limit
            decimal ECmax = 2000; // upper limit

            if (ec >= ECmin && ec <= ECmax)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Conductivity out of range:\nCheck EC probe calibration", "Device Error");
                return false;
            }
        }

        /*********************************************************
         * isTurbidityInRange tests value of turbidity
         * returns true if value is in range
         * opens a MessageBox and returns false if out of range
         *********************************************************/
        private static Boolean isTurbidityInRange(decimal turb)
        {
            decimal TURBmin = 0; // lower limit
            decimal TURBmax = 10; // upper limit

            if (turb >= TURBmin && turb <= TURBmax)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Turbidity out of range:\nCheck turbidity probe calibration", "Device Error");
                return false;
            }
        }

        /*********************************************************
         * isDissolvedSolidsInRange tests value of dissolvedSolids
         * returns true if value is in range
         * opens a MessageBox and returns false if out of range
         *********************************************************/
        private static Boolean isDissolvedSolidsInRange(decimal tds)
        {
            decimal TDSmin = 0; // lower limit
            decimal TDSmax = 500; // upper limit

            if (tds >= TDSmin && tds <= TDSmax)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Dissovled Solids out of range:\nCheck TDS probe calibration", "Device Error");
                return false;
            }
        }
    }
}
