using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB.BLL.Models
{
    public class ClientesInfo
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public ClientesInfo(int numId = 0, string name = "")
        {
            Id = numId;
            Nome = name;
        }      
    }
}
