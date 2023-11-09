using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK_8
{
    internal class Report
    {
        public string Text { get; }    
        public DateTime Deadline { get; set; }  
        public Employee Performer { get; set; }
        
        public Report(string text, DateTime deadline, Employee performer) 
        {
            Text = text;
            Deadline = deadline;    
            Performer = performer;  
        }
    }
}
