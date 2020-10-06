using System;
using System.Collections.Generic;

namespace WebServiceLIMAT.Models
{
    public partial class TblPruebaquimica
    {
        public TblPruebaquimica()
        {
            TblReporte = new HashSet<TblReporte>();
        }

        public int IdPruebaQuimica { get; set; }
        public string IdEquipo { get; set; }
        public string ContenidoAgua { get; set; }
        public string NumNeutralizacionAcido { get; set; }
        public string Pbc { get; set; }
        public string FechaMuestreo { get; set; }

        public virtual TblEquipo IdEquipoNavigation { get; set; }
        public virtual ICollection<TblReporte> TblReporte { get; set; }
    }
}
