using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Log
    {
        public int? ID { get; set; } 
        public DateTime Created { get; set; }
        public string Message { get; set; }
        public int Severity { get; set; }
        public Log() {
            this.Created = DateTime.Now;
        }
        public Log(string msg , int severity, int? id = null)
        {
            ID = id;
            Created = DateTime.Now;
            Message = msg;
            Severity = severity;
        }

    }
}
