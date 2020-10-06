using System;
using System.Collections.Generic;

namespace WebServiceLIMAT.Models
{
    public partial class TblMantenimiento
    {
        public int IdMantenimiento { get; set; }
        public string IdEquipo { get; set; }
        public string TipoMantenimiento { get; set; }
        public string Descripcion { get; set; }
        public string Supervisor { get; set; }
        public string Fecha { get; set; }
        public string Informe { get; set; }

        public virtual TblEquipo IdEquipoNavigation { get; set; }
    }
}
