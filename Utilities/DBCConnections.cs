using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace MapCharts.Utilities
{
    public class DBCConnections
    {
        public static string _connectionString;

        public static string GetConnectionString()
        {


            if (string.IsNullOrEmpty(_connectionString))
            {
                _connectionString = ConfigurationManager.ConnectionStrings["MapCon"].ConnectionString;
            }

            return _connectionString;
        }
    }
}