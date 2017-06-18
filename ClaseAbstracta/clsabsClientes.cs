﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    public  abstract class clsabsClientes
    {
        // Hay que definir el alcance de las clases
        // => public , => private

        public abstract int Id { get; set; }

        public abstract string NombreCliente { get; set; }

        public abstract string Clave { get; set; }

        public abstract string RFC { get; set; }

        public abstract int TipoRegimen { get; set; }

        public abstract string NombreContacto { get; set; }

    }
}
