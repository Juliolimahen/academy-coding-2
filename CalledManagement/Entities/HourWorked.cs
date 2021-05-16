using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalledManagement.Entities
{
    class HourWorked
    {
        public Called CalledId { get; }
        public DateTime DateInserted { get; set;}
        public DateTime DateStarted{ get; set;}
        public DateTime EndDate { get; set; }
        public DateTime DateChange { get; set; }
        public char Manual { get; set; }
    }
}
