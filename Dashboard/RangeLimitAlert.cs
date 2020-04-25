using System;

namespace SmartBuoyDashboard
{
    /***********************************************************
     * RangeLimitAlert contains methods to verify the 
     * measurements are within an environmentally acceptable range. 
     * Any measurement outside of the acceptable range will
     * cause the method to return false
     ***********************************************************/
    class RangeLimitAlert
    {
        /*********************************************************
        * isReadingWithinLimit tests values of all measurements 
        * returns true if all values are in range
        * returns false if out of range
        *********************************************************/
        public Boolean isReadingWithinLimit(Reading read)
        {
            if (isVoltageWithinLimit(read.battery)
                && isPhWithinLimit(read.pH) && isTempWithinLimit(read.temperature)
                && isConductivityWithinLimit(read.conductivity)
                && isTurbidityWithinLimit(read.turbidity)
                && isDissolvedSolidsWithinLimit(read.dissolvedSolids))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*********************************************************
        * isVoltageWithinLimit tests value of battery
        * returns true if value is in range
        * returns false if out of range
        *********************************************************/
        public Boolean isVoltageWithinLimit(decimal volt)
        {
            decimal VOLTmin = 3; // lower limit
            decimal VOLTmax = 5; // upper limit

            if (volt >= VOLTmin && volt <= VOLTmax)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*********************************************************
        * isPhWithinLimit tests value of pH
        * returns true if value is in range
        * returns false if out of range
        *********************************************************/
        public Boolean isPhWithinLimit(decimal ph)
        {
            decimal PHmin = 6.0M; // lower limit
            decimal PHmax = 8.5M; // upper limit

            if (ph >= PHmin && ph <= PHmax)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*********************************************************
        * isTempWithinLimit tests value of temperature
        * returns true if value is in range
        * returns false if out of range
        *********************************************************/
        public Boolean isTempWithinLimit(decimal temp)
        {
            decimal TEMPmin = 0; // lower limit
            decimal TEMPmax = 35; // upper limit

            if (temp >= TEMPmin && temp <= TEMPmax)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*********************************************************
        * isConductivityWithinLimit tests value of conductivity
        * returns true if value is in range
        * returns false if out of range
        *********************************************************/
        public Boolean isConductivityWithinLimit(decimal ec)
        {
            decimal ECmin = 0; // lower limit
            decimal ECmax = 900; // upper limit

            if (ec >= ECmin && ec <= ECmax)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*********************************************************
        * isTurbidityWithinLimit tests value of turbidity
        * returns true if value is in range
        * returns false if out of range
        *********************************************************/
        public Boolean isTurbidityWithinLimit(decimal turb)
        {
            decimal TURBmin = 0; // lower limit
            decimal TURBmax = 5; // upper limit

            if (turb >= TURBmin && turb <= TURBmax)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*********************************************************
        * isDissolvedSolidsWithinLimit tests value of dissolvedSolids
        * returns true if value is in range
        * returns false if out of range
        *********************************************************/
        public Boolean isDissolvedSolidsWithinLimit(decimal tds)
        {
            decimal TDSmin = 0; // lower limit
            decimal TDSmax = 300; // upper limit

            if (tds >= TDSmin && tds <= TDSmax)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
