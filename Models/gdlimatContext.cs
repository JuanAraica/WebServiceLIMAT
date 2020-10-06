using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebServiceLIMAT.Models
{
    public partial class gdlimatContext : DbContext
    {
        public gdlimatContext()
        {
        }

        public gdlimatContext(DbContextOptions<gdlimatContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblClientes> TblClientes { get; set; }
        public virtual DbSet<TblEquipo> TblEquipo { get; set; }
        public virtual DbSet<TblMantenimiento> TblMantenimiento { get; set; }
        public virtual DbSet<TblPruebacromatografica> TblPruebacromatografica { get; set; }
        public virtual DbSet<TblPruebaelectrica> TblPruebaelectrica { get; set; }
        public virtual DbSet<TblPruebafisica> TblPruebafisica { get; set; }
        public virtual DbSet<TblPruebaquimica> TblPruebaquimica { get; set; }
        public virtual DbSet<TblPruelectransf> TblPruelectransf { get; set; }
        public virtual DbSet<TblRegistros> TblRegistros { get; set; }
        public virtual DbSet<TblReporte> TblReporte { get; set; }
        public virtual DbSet<TblUnidadmedida> TblUnidadmedida { get; set; }
        public virtual DbSet<TblUsuarios> TblUsuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-44T26OH\\SQLEXPRESS;Database=gdlimat; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblClientes>(entity =>
            {
                entity.HasKey(e => e.NombreCliente)
                    .HasName("Pk_Clientes");

                entity.ToTable("tbl_CLIENTES");

                entity.Property(e => e.NombreCliente)
                    .HasColumnName("nombreCliente")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Contacto)
                    .HasColumnName("contacto")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Proyecto)
                    .HasColumnName("proyecto")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEquipo>(entity =>
            {
                entity.HasKey(e => e.IdEquipo)
                    .HasName("Pk_Equipo");

                entity.ToTable("tbl_EQUIPO");

                entity.HasIndex(e => e.Serie)
                    .HasName("UQ__tbl_EQUI__DFD1906AD4485C20")
                    .IsUnique();

                entity.Property(e => e.IdEquipo)
                    .HasColumnName("idEquipo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Annio)
                    .HasColumnName("annio")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CantidadAceite)
                    .HasColumnName("cantidadAceite")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CantidadFase)
                    .HasColumnName("cantidadFase")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Coretype)
                    .HasColumnName("CORETYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Criticality)
                    .HasColumnName("CRITICALITY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Energizedate)
                    .HasColumnName("ENERGIZEDATE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HumedadRelativa)
                    .HasColumnName("humedadRelativa")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HvKV)
                    .HasColumnName("HV_kV")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Isauto)
                    .HasColumnName("ISAUTO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Lv1KV)
                    .HasColumnName("LV1_kV")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Lv2KV)
                    .HasColumnName("LV2_kV")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Marca)
                    .HasColumnName("marca")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mva)
                    .HasColumnName("MVA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCliente)
                    .HasColumnName("nombreCliente")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PotenciaMaxima)
                    .HasColumnName("potenciaMaxima")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RelacioTension)
                    .HasColumnName("relacioTension")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Repairdate)
                    .HasColumnName("REPAIRDATE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Retiredate)
                    .HasColumnName("RETIREDATE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Serie)
                    .HasColumnName("serie")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubEstacion)
                    .HasColumnName("subEstacion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TemperaturaAmbiente)
                    .HasColumnName("temperaturaAmbiente")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TemperaturaEquipo)
                    .HasColumnName("temperaturaEquipo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tension)
                    .HasColumnName("tension")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEquipo)
                    .HasColumnName("tipoEquipo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoRefrigeracion)
                    .HasColumnName("tipoRefrigeracion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TvKV)
                    .HasColumnName("TV_kV")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UltimoMantenimiento)
                    .HasColumnName("ultimoMantenimiento")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UltimoReporte)
                    .HasColumnName("ultimoReporte")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Utility)
                    .HasColumnName("UTILITY")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMantenimiento>(entity =>
            {
                entity.HasKey(e => e.IdMantenimiento)
                    .HasName("Pk_Mantenimiento");

                entity.ToTable("tbl_MANTENIMIENTO");

                entity.Property(e => e.IdMantenimiento).HasColumnName("idMantenimiento");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEquipo)
                    .HasColumnName("idEquipo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Informe)
                    .HasColumnName("informe")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Supervisor)
                    .HasColumnName("supervisor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMantenimiento)
                    .HasColumnName("tipoMantenimiento")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEquipoNavigation)
                    .WithMany(p => p.TblMantenimiento)
                    .HasForeignKey(d => d.IdEquipo)
                    .HasConstraintName("FK_Equipo_Mantenimiento");
            });

            modelBuilder.Entity<TblPruebacromatografica>(entity =>
            {
                entity.HasKey(e => e.IdPruebaCroma)
                    .HasName("Pk_PruebaCromatografica");

                entity.ToTable("tbl_PRUEBACROMATOGRAFICA");

                entity.Property(e => e.IdPruebaCroma).HasColumnName("idPruebaCroma");

                entity.Property(e => e.Acetileno)
                    .HasColumnName("acetileno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BadSample)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DioxidoCarbono)
                    .HasColumnName("dioxidoCarbono")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Etano)
                    .HasColumnName("etano")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Etileno)
                    .HasColumnName("etileno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaMuestreo)
                    .HasColumnName("fechaMuestreo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hidrogeno)
                    .HasColumnName("hidrogeno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdEquipo)
                    .IsRequired()
                    .HasColumnName("idEquipo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Metano)
                    .HasColumnName("metano")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MonoxidoCarbono)
                    .HasColumnName("monoxidoCarbono")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nitrogeno)
                    .HasColumnName("nitrogeno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Oxigeno)
                    .HasColumnName("oxigeno")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SerieEquipo)
                    .HasColumnName("serieEquipo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalGasesCombusibles)
                    .HasColumnName("totalGasesCombusibles")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEquipoNavigation)
                    .WithMany(p => p.TblPruebacromatografica)
                    .HasForeignKey(d => d.IdEquipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equipo_PruebaCromatografica");
            });

            modelBuilder.Entity<TblPruebaelectrica>(entity =>
            {
                entity.HasKey(e => e.IdPruebaElectrica)
                    .HasName("Pk_PruebaElectrica");

                entity.ToTable("tbl_PRUEBAELECTRICA");

                entity.Property(e => e.IdPruebaElectrica).HasColumnName("idPruebaElectrica");

                entity.Property(e => e.FactorPotencia100C)
                    .IsRequired()
                    .HasColumnName("factorPotencia100C")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaMuestreo)
                    .IsRequired()
                    .HasColumnName("fechaMuestreo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEquipo)
                    .IsRequired()
                    .HasColumnName("idEquipo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Resistividad100)
                    .IsRequired()
                    .HasColumnName("resistividad100")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RigidezDioElectrica)
                    .IsRequired()
                    .HasColumnName("rigidezDioElectrica")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEquipoNavigation)
                    .WithMany(p => p.TblPruebaelectrica)
                    .HasForeignKey(d => d.IdEquipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equipo_PruebaElectrica");
            });

            modelBuilder.Entity<TblPruebafisica>(entity =>
            {
                entity.HasKey(e => e.IdPruebasFisicas)
                    .HasName("Pk_PruebaFisicas");

                entity.ToTable("tbl_PRUEBAFISICA");

                entity.Property(e => e.IdPruebasFisicas).HasColumnName("idPruebasFisicas");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnName("color")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExamenVisual)
                    .IsRequired()
                    .HasColumnName("examenVisual")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaMuestreo)
                    .IsRequired()
                    .HasColumnName("fechaMuestreo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GravedadEspecifica15C15c)
                    .IsRequired()
                    .HasColumnName("gravedadEspecifica15C15C")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdEquipo)
                    .IsRequired()
                    .HasColumnName("idEquipo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TensionInterfacial)
                    .IsRequired()
                    .HasColumnName("tensionInterfacial")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEquipoNavigation)
                    .WithMany(p => p.TblPruebafisica)
                    .HasForeignKey(d => d.IdEquipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equipo_PruebaFisica");
            });

            modelBuilder.Entity<TblPruebaquimica>(entity =>
            {
                entity.HasKey(e => e.IdPruebaQuimica)
                    .HasName("Pk_PruebaQuimica");

                entity.ToTable("tbl_PRUEBAQUIMICA");

                entity.Property(e => e.IdPruebaQuimica).HasColumnName("idPruebaQuimica");

                entity.Property(e => e.ContenidoAgua)
                    .IsRequired()
                    .HasColumnName("contenidoAgua")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaMuestreo)
                    .IsRequired()
                    .HasColumnName("fechaMuestreo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEquipo)
                    .IsRequired()
                    .HasColumnName("idEquipo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumNeutralizacionAcido)
                    .IsRequired()
                    .HasColumnName("numNeutralizacionAcido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pbc)
                    .IsRequired()
                    .HasColumnName("PBC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEquipoNavigation)
                    .WithMany(p => p.TblPruebaquimica)
                    .HasForeignKey(d => d.IdEquipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equipo_PruebaQuimica");
            });

            modelBuilder.Entity<TblPruelectransf>(entity =>
            {
                entity.HasKey(e => e.IdPruElecTfransf)
                    .HasName("Pk_PruElecTfransf");

                entity.ToTable("tbl_PRUELECTRANSF");

                entity.Property(e => e.IdPruElecTfransf).HasColumnName("idPruElecTfransf");

                entity.Property(e => e.IdEquipo)
                    .IsRequired()
                    .HasColumnName("idEquipo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEquipoNavigation)
                    .WithMany(p => p.TblPruelectransf)
                    .HasForeignKey(d => d.IdEquipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equipo_PrueElectRansf");
            });

            modelBuilder.Entity<TblRegistros>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("Pk_Registro");

                entity.ToTable("tbl_REGISTROS");

                entity.Property(e => e.IdRegistro).HasColumnName("idRegistro");

                entity.Property(e => e.Fecha)
                    .IsRequired()
                    .HasColumnName("fecha")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Registro)
                    .IsRequired()
                    .HasColumnName("registro")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblReporte>(entity =>
            {
                entity.HasKey(e => e.IdReporte)
                    .HasName("Pk_Muestra");

                entity.ToTable("tbl_REPORTE");

                entity.Property(e => e.IdReporte).HasColumnName("idReporte");

                entity.Property(e => e.FechaReporte)
                    .IsRequired()
                    .HasColumnName("fechaReporte")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEquipo)
                    .IsRequired()
                    .HasColumnName("idEquipo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdPruebaCroma).HasColumnName("idPruebaCroma");

                entity.Property(e => e.IdPruebaElectrica).HasColumnName("idPruebaElectrica");

                entity.Property(e => e.IdPruebaQuimica).HasColumnName("idPruebaQuimica");

                entity.Property(e => e.IdPruebasFisicas).HasColumnName("idPruebasFisicas");

                entity.Property(e => e.NombreCliente)
                    .HasColumnName("nombreCliente")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEquipoNavigation)
                    .WithMany(p => p.TblReporte)
                    .HasForeignKey(d => d.IdEquipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reporte_equipo");

                entity.HasOne(d => d.IdPruebaCromaNavigation)
                    .WithMany(p => p.TblReporte)
                    .HasForeignKey(d => d.IdPruebaCroma)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reporte_PruebaCromatografica");

                entity.HasOne(d => d.IdPruebaElectricaNavigation)
                    .WithMany(p => p.TblReporte)
                    .HasForeignKey(d => d.IdPruebaElectrica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reporte_PruebaElectrica");

                entity.HasOne(d => d.IdPruebaQuimicaNavigation)
                    .WithMany(p => p.TblReporte)
                    .HasForeignKey(d => d.IdPruebaQuimica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reporte_PruebaQuimica");

                entity.HasOne(d => d.IdPruebasFisicasNavigation)
                    .WithMany(p => p.TblReporte)
                    .HasForeignKey(d => d.IdPruebasFisicas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reporte_PruebaFisica");

                entity.HasOne(d => d.NombreClienteNavigation)
                    .WithMany(p => p.TblReporte)
                    .HasForeignKey(d => d.NombreCliente)
                    .HasConstraintName("FK_Reporte_Cliente");
            });

            modelBuilder.Entity<TblUnidadmedida>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_UNIDADMEDIDA");

                entity.Property(e => e.FactorAmedir)
                    .IsRequired()
                    .HasColumnName("factorAMedir")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadMedida)
                    .IsRequired()
                    .HasColumnName("unidadMedida")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ValorRecomendado)
                    .HasColumnName("valorRecomendado")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUsuarios>(entity =>
            {
                entity.HasKey(e => e.Nick)
                    .HasName("Pk_Usuarios");

                entity.ToTable("tbl_USUARIOS");

                entity.Property(e => e.Nick)
                    .HasColumnName("nick")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasColumnName("contraseña")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
