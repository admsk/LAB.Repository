using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB.BLL.Interface
{
    public interface IClientes
    {
        List<string> GetAllClientes();
        void AddCliente();
        void DeleteCliente(int id);
    }
}
