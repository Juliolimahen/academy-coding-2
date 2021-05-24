using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalledManagement.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTimeRegister { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Occupation { get; set; }
        public string Group { get; set; }
    }
}
