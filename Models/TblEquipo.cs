using System;
using System.Collections.Generic;

namespace WebServiceLIMAT.Models
{
    public partial class TblEquipo
    {
        public TblEquipo()
        {
            TblMantenimiento = new HashSet<TblMantenimiento>();
            TblPruebacromatografica = new HashSet<TblPruebacromatografica>();
            TblPruebaelectrica = new HashSet<TblPruebaelectrica>();
            TblPruebafisica = new HashSet<TblPruebafisica>();
            TblPruebaquimica = new HashSet<TblPruebaquimica>();
            TblPruelectransf = new HashSet<TblPruelectransf>();
            TblReporte = new HashSet<TblReporte>();
        }

        public string IdEquipo { get; set; }
        public string TipoEquipo { get; set; }
        public string Serie { get; set; }
        public string Marca { get; set; }
        public string Annio { get; set; }
        public string Energizedate { get; set; }
        public string Repairdate { get; set; }
        public string Retiredate { get; set; }
        public string Utility { get; set; }
        public string Region { get; set; }
        public string SubEstacion { get; set; }
        public string Coretype { get; set; }
        public string Mva { get; set; }
        public string TipoRefrigeracion { get; set; }
        public string HvKV { get; set; }
        public string Lv1KV { get; set; }
        public string Lv2KV { get; set; }
        public string TvKV { get; set; }
        public string CantidadFase { get; set; }
        public string Isauto { get; set; }
        public string Criticality { get; set; }
        public string Tension { get; set; }
        public string CantidadAceite { get; set; }
        public string RelacioTension { get; set; }
        public string HumedadRelativa { get; set; }
        public string TemperaturaAmbiente { get; set; }
        public string TemperaturaEquipo { get; set; }
        public string UltimoReporte { get; set; }
        public string UltimoMantenimiento { get; set; }
        public string NombreCliente { get; set; }
        public string Estado { get; set; }
        public string PotenciaMaxima { get; set; }

        public virtual ICollection<TblMantenimiento> TblMantenimiento { get; set; }
        public virtual ICollection<TblPruebacromatografica> TblPruebacromatografica { get; set; }
        public virtual ICollection<TblPruebaelectrica> TblPruebaelectrica { get; set; }
        public virtual ICollection<TblPruebafisica> TblPruebafisica { get; set; }
        public virtual ICollection<TblPruebaquimica> TblPruebaquimica { get; set; }
        public virtual ICollection<TblPruelectransf> TblPruelectransf { get; set; }
        public virtual ICollection<TblReporte> TblReporte { get; set; }
    }
}
