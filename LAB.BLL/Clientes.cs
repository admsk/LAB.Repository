using LAB.BLL.Interface;
using LAB.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB.BLL
{
    class Clientes : IClientes
    {
        List<ClientesInfo> clientes = new List<ClientesInfo>();
        public void AddCliente()
        {
            ClientesInfo c1 = new ClientesInfo(1, "David");
            ClientesInfo c2 = new ClientesInfo(2, "Adriano");
            ClientesInfo c3 = new ClientesInfo(3, "Itamar");
            ClientesInfo c4 = new ClientesInfo(4, "Lucas");
            clientes.Add(c1);
            clientes.Add(c2);
            clientes.Add(c3);
            clientes.Add(c4);
        }
        public void DeleteCliente(int id)
        {
            throw new NotImplementedException();
        }

        List<string> IClientes.GetAllClientes()
        {
            throw new NotImplementedException();
        }
    }
}
