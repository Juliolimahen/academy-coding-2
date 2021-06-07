using CalledManagement.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalledManagement.Entities
{
    //Classe responsável pela modelagem do chamado
    public class Called
    {
        //metodos get e set "props" gerados pela IDE
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Finished { get; set; }
        public string Descripition { get; set; }
        public User UserId { get; set; }
        public Priority PriorityId { get; set; } //associação
    }
}
