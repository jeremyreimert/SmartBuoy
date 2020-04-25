/**********************************************************************************
 * NAME: Jeremy Reimert
 * DATE: February 29, 2020
 * PROJECT: SmartBuoy Interface
 * DESCRIPTION: This project is a user interface for viewing data from
 * a device created to measure the quality of water.
 * 
 * The application has two main functions:
 * 1. To retrieve historic data from a database. 
 * 2. To retrieve live streaming data using the Dweet.io service. 
 * 
 * In both cases, data is presented within a dataGridView, a line chart, and 
 * customized gauges. Location data is used to plot points on a map.  
 * 
 **********************************************************************************/

using Newtonsoft.Json;
using System;
using System.Net;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace SmartBuoyDashboard
{
    /****************************************************************************
     * ReadingProxy class used for extracing data from a JSON string 
     ***************************************************************************/
    class ReadingProxy
    {
        [DataContract] // Rootobject defines a data contract
        public class Rootobject
        {
            // properties are members of the data contract
            [DataMember]
            public string _this { get; set; }
            [DataMember]
            public string by { get; set; }
            [DataMember]
            public string the { get; set; }
            [DataMember]
            public With[] with { get; set; }
        }

        [DataContract] // With defines a data contract
        public class With
        {
            // properties are members of the data contract
            [DataMember]
            public string thing { get; set; }
            [DataMember]
            public DateTime created { get; set; }
            [DataMember]
            public Content content { get; set; }
        }

        /**********************************************
         * Content contains the data to be extracted
         **********************************************/
        [DataContract] // Content defines a data contract
        public class Content
        {
            // properties are members of the data contract
            [DataMember]
            public string DATETIME { get; set; }
            [DataMember]
            public double VOLTS { get; set; }
            [DataMember]
            public double TEMP { get; set; }
            [DataMember]
            public double PH { get; set; }
            [DataMember]
            public double EC { get; set; }
            [DataMember]
            public double TDS { get; set; }
            [DataMember]
            public double TURB { get; set; }
            [DataMember]
            public double LAT { get; set; }
            [DataMember]
            public double LON { get; set; }
        }

        /****************************************************************************
         * WebResponse() retrieves a the most recent reading from dweet.io
         * Deserializes the JSON string and assigns to a Reading object
         ***************************************************************************/
        public static Reading WebResponse()
        {
            Reading read = new Reading(); // reading object

            try
            {
                using (var webClient = new WebClient())
                {
                    string url = "https://dweet.io/get/latest/dweet/for/SmartBuoyb97e934d5336e0"; // dweet.io url

                    var rawJSON = webClient.DownloadString(url); // get JSON string

                    Rootobject root = JsonConvert.DeserializeObject<Rootobject>(rawJSON); // assign JSON string data to Rootobject 

                    // Set values of the Reading data members to the values of ReadingProxy data members 
                    read.readingDT = Convert.ToDateTime(WebUtility.HtmlDecode(root.with[0].content.DATETIME));
                    read.battery = Convert.ToDecimal(WebUtility.HtmlDecode(root.with[0].content.VOLTS.ToString("0.0")));
                    read.temperature = Convert.ToDecimal(WebUtility.HtmlDecode(root.with[0].content.TEMP.ToString("#0.0")));
                    read.pH = Convert.ToDecimal(WebUtility.HtmlDecode(root.with[0].content.PH.ToString("#0.0")));
                    read.conductivity = Convert.ToDecimal(WebUtility.HtmlDecode(root.with[0].content.EC.ToString("####")));
                    read.dissolvedSolids = Convert.ToDecimal(WebUtility.HtmlDecode(root.with[0].content.TDS.ToString("####")));
                    read.turbidity = Convert.ToDecimal(WebUtility.HtmlDecode(root.with[0].content.TURB.ToString("0.0")));
                    read.latitude = Convert.ToDecimal(WebUtility.HtmlDecode(root.with[0].content.LAT.ToString("###.######")));
                    read.longitude = Convert.ToDecimal(WebUtility.HtmlDecode(root.with[0].content.LON.ToString("###.######")));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Logger.LogError(e);
            }
            return read;
        }
    }
}

