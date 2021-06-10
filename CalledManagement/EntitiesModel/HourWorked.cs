using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalledManagement.EntitiesDAO
{
    //Classe responsável pela modelagem das horas trabalhadas
    public class HourWorked
    {
        //metodos get e set "props" gerados pela IDE
        public int Id { get; set; }
        public Called CalledId { get; set; }//associação
        public DateTime DateInserted { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateChange { get; set; }
    }
}
