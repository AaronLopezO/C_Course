using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una clase abstracta es una clase que no se puede instanciar
            // Se usan para generar una jerarquia de clases.
            // Genera las superclases

            // El objetivo de establecer una estructra base para la generacion de las demas clases
            // 

            clsClienteConContacto cliente = new clsClienteConContacto(0, "Aaron", "213","LOOA940708",1,"Aaron Lopez","21123","312312","aaronvladimirl@hexaware.com",
                "Rancho de Peña", "267", "SN","Doctores", "Saltillo","Coahuila", "26170");


            impresion impression;
            impression = new impresion();
            impression.imprimeCliente(cliente);

        }
    }
}
