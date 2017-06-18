using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    public class impresion
    {
        public void imprimeCliente(clsabsClientes cliente)
        {
           Console.WriteLine(cliente.Clave + " - " + cliente.NombreCliente);
            Console.ReadKey();
        }
    }
}
