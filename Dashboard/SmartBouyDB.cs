using System;
using System.Configuration;
using System.Data.Linq;

namespace SmartBuoyDashboard
{
    /*************************************************************
    * SmartBuoy inherits DataContext 
    * An instance of class will act as connection to the database 
    *************************************************************/
    class SmartBuoyDB : DataContext
    {
        private static readonly String Login = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        public Table<Reading> Reading;

        public SmartBuoyDB() : base(Login)
        {
        }
    }
}
