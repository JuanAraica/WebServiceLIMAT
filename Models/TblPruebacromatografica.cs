using System;
using System.Collections.Generic;

namespace WebServiceLIMAT.Models
{
    public partial class TblPruebacromatografica
    {
        public TblPruebacromatografica()
        {
            TblReporte = new HashSet<TblReporte>();
        }

        public int IdPruebaCroma { get; set; }
        public string IdEquipo { get; set; }
        public string SerieEquipo { get; set; }
        public string DioxidoCarbono { get; set; }
        public string Acetileno { get; set; }
        public string Etileno { get; set; }
        public string Etano { get; set; }
        public string Metano { get; set; }
        public string MonoxidoCarbono { get; set; }
        public string Hidrogeno { get; set; }
        public string Oxigeno { get; set; }
        public string Nitrogeno { get; set; }
        public string TotalGasesCombusibles { get; set; }
        public string BadSample { get; set; }
        public string FechaMuestreo { get; set; }

        public virtual TblEquipo IdEquipoNavigation { get; set; }
        public virtual ICollection<TblReporte> TblReporte { get; set; }
    }
}
