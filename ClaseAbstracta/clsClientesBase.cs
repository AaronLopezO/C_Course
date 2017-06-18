using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    public class clsClientesBase : clsabsClientes
    {
        public clsClientesBase()
        {
            Id = 0;
            NombreCliente = string.Empty;
            Clave = string.Empty;
            RFC = string.Empty;
            TipoRegimen = 0;
            NombreContacto = string.Empty;
        }

        public clsClientesBase(int pId, string pNombre, string pClave,
            string pRFC, int pTipoRegimen, string pNombreContacto)
        {
            Id = pId;
            NombreCliente = pNombre;
            Clave = pClave;
            RFC = pRFC;
            TipoRegimen = pTipoRegimen;
            NombreContacto = pNombreContacto;
        }

        public override int Id { get; set; }

        public override string NombreCliente { get; set; }

        public override string  Clave { get; set; }

        public override string RFC { get; set; }

        public override int TipoRegimen { get; set; }

        public override string NombreContacto { get; set; }

    }
}
