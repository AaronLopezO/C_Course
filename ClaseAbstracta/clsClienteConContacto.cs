using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    public class clsClienteConContacto : clsClientesBase
    {
        public clsClienteConContacto()
        {
            _Direccion = new clsDirecciones();
        }

        public clsClienteConContacto(int pId, string pNombre, string pClave, string pRFC, int pTipoRegimen, string pNombreContacto,
            string ptelefono1, string ptelefono2, string pEmail, string pCalle, string pNumeroExterior,
            string pNumeroInterior, string pColonia, string pMunicipio, string pEstado, string pCP)
        {
            Id = pId;
            NombreCliente = pNombre;
            Clave = pClave;
            RFC = pRFC;
            TipoRegimen = pTipoRegimen;
            NombreContacto = pNombreContacto;
            Telefono1 = ptelefono1;
            Telefono2 = ptelefono2;
            Email = pEmail;
            _Direccion = new clsDirecciones();
            _Direccion.Calle = pCalle;
            _Direccion.NumeroExterior = pNumeroExterior;
            _Direccion.NumeroInterior = pNumeroInterior;
            _Direccion.Colonia = pColonia;
            _Direccion.Municipio = pMunicipio;
            _Direccion.Estado = pEstado;
            _Direccion.CP = pCP;
   
        }

        public string Telefono1 { get; set; }

        public string Telefono2 { get; set; }

        public string Email { get; set; }
        
        private clsDirecciones _Direccion;

        public clsDirecciones Direccion
        {
            get => _Direccion;
            set => _Direccion = value;
        }

    }
}
