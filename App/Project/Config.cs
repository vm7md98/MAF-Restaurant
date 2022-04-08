using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Project_v1
{
    public class Config
    {
        public static string GetConnectionStr()
        {
            string connstr = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            return connstr;
        }

    }
}