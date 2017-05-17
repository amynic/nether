using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Nether.Analytics.DataLake.Jobs
{
    public class eventDate
    {
        public static DateTime EventDateValue { get; set; }

        public static DateTime convertDate(string eventDate)
        {
            DateTime newdate = DateTime.Parse(eventDate);
            return newdate;
        }
        
    }
}
