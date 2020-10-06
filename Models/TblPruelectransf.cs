using System;
using System.Collections.Generic;

namespace WebServiceLIMAT.Models
{
    public partial class TblPruelectransf
    {
        public int IdPruElecTfransf { get; set; }
        public string IdEquipo { get; set; }

        public virtual TblEquipo IdEquipoNavigation { get; set; }
    }
}
