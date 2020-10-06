using System;
using System.Collections.Generic;

namespace WebServiceLIMAT.Models
{
    public partial class TblPruebafisica
    {
        public TblPruebafisica()
        {
            TblReporte = new HashSet<TblReporte>();
        }

        public int IdPruebasFisicas { get; set; }
        public string IdEquipo { get; set; }
        public string ExamenVisual { get; set; }
        public string Color { get; set; }
        public string TensionInterfacial { get; set; }
        public string GravedadEspecifica15C15c { get; set; }
        public string FechaMuestreo { get; set; }

        public virtual TblEquipo IdEquipoNavigation { get; set; }
        public virtual ICollection<TblReporte> TblReporte { get; set; }
    }
}
