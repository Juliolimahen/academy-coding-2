using CalledManagement.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalledManagement.Entities
{
    class Called
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        public DateTime Date { get; set; }
        public CalledStatus Status { get; set; }
        public string Descripition { get; set; }
    }
}
