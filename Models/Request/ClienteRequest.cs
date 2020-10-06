using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceLIMAT.Models.Request
{
    public class ClienteRequest
    {
        public string NombreCliente { get; set; }
        public string Contacto { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Proyecto { get; set; }
    }
}
