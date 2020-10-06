using System;
using System.Collections.Generic;

namespace WebServiceLIMAT.Models
{
    public partial class TblReporte
    {
        public int IdReporte { get; set; }
        public string NombreCliente { get; set; }
        public string IdEquipo { get; set; }
        public int IdPruebaElectrica { get; set; }
        public int IdPruebasFisicas { get; set; }
        public int IdPruebaQuimica { get; set; }
        public int IdPruebaCroma { get; set; }
        public string FechaReporte { get; set; }

        public virtual TblEquipo IdEquipoNavigation { get; set; }
        public virtual TblPruebacromatografica IdPruebaCromaNavigation { get; set; }
        public virtual TblPruebaelectrica IdPruebaElectricaNavigation { get; set; }
        public virtual TblPruebaquimica IdPruebaQuimicaNavigation { get; set; }
        public virtual TblPruebafisica IdPruebasFisicasNavigation { get; set; }
        public virtual TblClientes NombreClienteNavigation { get; set; }
    }
}
