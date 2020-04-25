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

using System;
using System.Data.Linq.Mapping;

namespace SmartBuoyDashboard
{
    /******************************************************
     * The Reading class contains properties to set and 
     * get the values of each measurement
     * ***************************************************/

    [Table(Name = "Reading")] // links class with database table
    public class Reading
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
    }
}
