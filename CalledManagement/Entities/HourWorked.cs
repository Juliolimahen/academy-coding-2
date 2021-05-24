using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalledManagement.Entities
{
    //Classe responsável pela modelagem das horas trabalhadas
    public class HourWorked
    {
       
        public Called CalledId { get; set; }//associação
        public User UserId { get; set; }
        //metodos get e set "props" gerados pela IDE
        public DateTime DateInserted { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateChange { get; set; }
        public char Manual { get; set; }

    }
}
