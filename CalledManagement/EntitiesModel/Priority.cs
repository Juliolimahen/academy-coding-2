using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalledManagement.EntitiesDAO
{
    //classe Prioridade
    public class Priority
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Days { get; set; }

        //teste
        public override string ToString()
        {
            return "ID: " + Id + "   Nome: " + Name + "   Dias: " + Days;
        }
        //teste, lista de prioridades
        public List<Priority> ListPriority(){

            List<Priority> list = new List<Priority>();
            list.Add(new Priority() { Id = 1, Name ="Baixa", Days = 8 });
            list.Add(new Priority() { Id = 2, Name = "Normal", Days = 6 });
            list.Add(new Priority() { Id = 3, Name = "Grave", Days = 2 });
            list.Add(new Priority() { Id = 4, Name = "Critica", Days = 1 });

            return list;
        }
    }
    
}
