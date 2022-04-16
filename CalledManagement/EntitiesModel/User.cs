using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalledManagement.EntitiesModel
{
    class User: EntitiesModel.IEntidade
    {
        //metodos get e set "props" gerados pela IDE
        public int Id { get; set; }
        public string Descripition { get; set; }
        public string Password { get; set; }
        public string Email { get; set; } 
        public DateTime RegisterDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
