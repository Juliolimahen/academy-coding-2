using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalledManagement.Entities
{
    class HourWorked
    {
        public string Descripition { get; set; }
        public int MyProperty { get; set; }
        public Called Id { get;}
        public DateTime StartDate { get; set;}
        public DateTime EndDate { get; set; }
        public char Manual { get; set; }
        public DateTime DateChange { get; set; }
    }
}
