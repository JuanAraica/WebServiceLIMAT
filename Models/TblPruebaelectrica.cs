using System;
using System.Collections.Generic;

namespace WebServiceLIMAT.Models
{
    public partial class TblPruebaelectrica
    {
        public TblPruebaelectrica()
        {
            TblReporte = new HashSet<TblReporte>();
        }

        public int IdPruebaElectrica { get; set; }
        public string IdEquipo { get; set; }
        public string RigidezDioElectrica { get; set; }
        public string FactorPotencia100C { get; set; }
        public string Resistividad100 { get; set; }
        public string FechaMuestreo { get; set; }

        public virtual TblEquipo IdEquipoNavigation { get; set; }
        public virtual ICollection<TblReporte> TblReporte { get; set; }
    }
}
