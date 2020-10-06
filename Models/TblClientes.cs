using System;
using System.Collections.Generic;

namespace WebServiceLIMAT.Models
{
    public partial class TblClientes
    {
        public TblClientes()
        {
            TblReporte = new HashSet<TblReporte>();
        }

        public string NombreCliente { get; set; }
        public string Contacto { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Proyecto { get; set; }

        public virtual ICollection<TblReporte> TblReporte { get; set; }
    }
}
