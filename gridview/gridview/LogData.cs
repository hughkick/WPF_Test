using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gridview
{
    internal class LogData : List<Log>
    {
        public LogData()
        {
        }
    }

    public class Log
    {
        public DateTime time { get; set; }
        public string description { get; set; }

        public Log(string t, string log)
        {
            time = DateTime.Parse(t);
            description = log;
        }
    }
}
