using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Riviera_Business.Models
{
    public partial class riviera_businessContext : DbContext
    {
        public riviera_businessContext()
        {
        }

        public riviera_businessContext(DbContextOptions<riviera_businessContext> options)
            : base(options)
        {
        }

        public riviera_businessContext(string v)
        {
        }

        public virtual DbSet<CBanco> CBanco { get; set; }
        public virtual DbSet<CCarroExtra> CCarroExtra { get; set; }
        public virtual DbSet<CEstados> CEstados { get; set; }
        public virtual DbSet<CFormaPago> CFormaPago { get; set; }
        public virtual DbSet<CGuiaAutometricaEbc> CGuiaAutometricaEbc { get; set; }
        public virtual DbSet<CMarcaCarro> CMarcaCarro { get; set; }
        public virtual DbSet<CMedioPublicitario> CMedioPublicitario { get; set; }
        public virtual DbSet<CModeloCarro> CModeloCarro { get; set; }
        public virtual DbSet<CPreAcondicionamiento> CPreAcondicionamiento { get; set; }
        public virtual DbSet<CTipoGasto> CTipoGasto { get; set; }
        public virtual DbSet<CVersionCarro> CVersionCarro { get; set; }
        public virtual DbSet<TbAdecuaciones> TbAdecuaciones { get; set; }
        public virtual DbSet<TbCarros> TbCarros { get; set; }
        public virtual DbSet<TbCarrosTransaccion> TbCarrosTransaccion { get; set; }
        public virtual DbSet<TbComprobantes> TbComprobantes { get; set; }
        public virtual DbSet<TbCondiciones> TbCondiciones { get; set; }
        public virtual DbSet<TbConta> TbConta { get; set; }
        public virtual DbSet<TbControl> TbControl { get; set; }
        public virtual DbSet<TbDatosPersona> TbDatosPersona { get; set; }
        public virtual DbSet<TbDatosPersonaMoral> TbDatosPersonaMoral { get; set; }
        public virtual DbSet<TbExportacion> TbExportacion { get; set; }
        public virtual DbSet<TbGastos> TbGastos { get; set; }
        public virtual DbSet<TbLeyAntilavado> TbLeyAntilavado { get; set; }
        public virtual DbSet<TbPapelesCarro> TbPapelesCarro { get; set; }
        public virtual DbSet<TbPreciosTentativos> TbPreciosTentativos { get; set; }
        public virtual DbSet<TbProveedor> TbProveedor { get; set; }
        public virtual DbSet<TbSeguimiento> TbSeguimiento { get; set; }
        public virtual DbSet<TbSeguro> TbSeguro { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;database=riviera_business;user=root;password=1234", x => x.ServerVersion("8.0.13-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CBanco>(entity =>
            {
                entity.HasKey(e => e.IdBanco)
                    .HasName("PRIMARY");

                entity.ToTable("c_banco");

                entity.Property(e => e.IdBanco)
                    .HasColumnName("Id_Banco")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CCarroExtra>(entity =>
            {
                entity.HasKey(e => e.IdCarroExtra)
                    .HasName("PRIMARY");

                entity.ToTable("c_carro_extra");

                entity.HasIndex(e => e.IdCarro)
                    .HasName("FK_Extra_Carro_idx");

                entity.HasIndex(e => e.IdEstado)
                    .HasName("FK_Extra_Estado_idx");

                entity.Property(e => e.IdCarroExtra)
                    .HasColumnName("Id_Carro_Extra")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Antena).HasColumnType("int(11)");

                entity.Property(e => e.CarnetServicio)
                    .HasColumnName("Carnet_Servicio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Duplicado).HasColumnType("int(11)");

                entity.Property(e => e.Gato).HasColumnType("int(11)");

                entity.Property(e => e.Herramientas).HasColumnType("int(11)");

                entity.Property(e => e.IdCarro)
                    .HasColumnName("Id_Carro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("Id_Estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LlantaRefaccion)
                    .HasColumnName("Llanta_Refaccion")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Manuales).HasColumnType("int(11)");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdCarroNavigation)
                    .WithMany(p => p.CCarroExtra)
                    .HasForeignKey(d => d.IdCarro)
                    .HasConstraintName("FK_Extra_Carro");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.CCarroExtra)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_Extra_Estado");
            });

            modelBuilder.Entity<CEstados>(entity =>
            {
                entity.HasKey(e => e.IdEstados)
                    .HasName("PRIMARY");

                entity.ToTable("c_estados");

                entity.Property(e => e.IdEstados)
                    .HasColumnName("Id_Estados")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CFormaPago>(entity =>
            {
                entity.HasKey(e => e.IdFormaPago)
                    .HasName("PRIMARY");

                entity.ToTable("c_forma_pago");

                entity.HasIndex(e => e.IdEstado)
                    .HasName("FK_FP_Estado_idx");

                entity.Property(e => e.IdFormaPago)
                    .HasColumnName("Id_Forma_Pago")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("Id_Estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.CFormaPago)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_FP_Estado");
            });

            modelBuilder.Entity<CGuiaAutometricaEbc>(entity =>
            {
                entity.HasKey(e => e.IdGuiaAutometrica)
                    .HasName("PRIMARY");

                entity.ToTable("c_guia_autometrica_ebc");

                entity.HasIndex(e => e.IdCarro)
                    .HasName("FK_Guia_Carro_idx");

                entity.HasIndex(e => e.IdEstado)
                    .HasName("FK_Guia_Estado_idx");

                entity.Property(e => e.IdGuiaAutometrica)
                    .HasColumnName("Id_Guia_Autometrica")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GuiaAutometricaEbc)
                    .HasColumnName("Guia_Autometrica_EBC")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdCarro)
                    .HasColumnName("Id_Carro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("Id_Estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdCarroNavigation)
                    .WithMany(p => p.CGuiaAutometricaEbc)
                    .HasForeignKey(d => d.IdCarro)
                    .HasConstraintName("FK_Guia_Carro");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.CGuiaAutometricaEbc)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_Guia_Estado");
            });

            modelBuilder.Entity<CMarcaCarro>(entity =>
            {
                entity.HasKey(e => e.IdMarcaCarro)
                    .HasName("PRIMARY");

                entity.ToTable("c_marca_carro");

                entity.Property(e => e.IdMarcaCarro)
                    .HasColumnName("Id_Marca_Carro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NombreMarca)
                    .HasColumnName("Nombre_Marca")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CMedioPublicitario>(entity =>
            {
                entity.HasKey(e => e.IdMedioPublicitario)
                    .HasName("PRIMARY");

                entity.ToTable("c_medio_publicitario");

                entity.HasIndex(e => e.IdEstado)
                    .HasName("FK_MP_Estado_idx");

                entity.Property(e => e.IdMedioPublicitario)
                    .HasColumnName("Id_Medio_Publicitario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("Id_Estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.CMedioPublicitario)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_MP_Estado");
            });

            modelBuilder.Entity<CModeloCarro>(entity =>
            {
                entity.HasKey(e => e.IdModeloCarro)
                    .HasName("PRIMARY");

                entity.ToTable("c_modelo_carro");

                entity.HasIndex(e => e.IdMarca)
                    .HasName("FK_CMarca_CModelo_idx");

                entity.Property(e => e.IdModeloCarro)
                    .HasColumnName("Id_Modelo_Carro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdMarca)
                    .HasColumnName("Id_Marca")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModeloCarro)
                    .HasColumnName("Modelo_Carro")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdMarcaNavigation)
                    .WithMany(p => p.CModeloCarro)
                    .HasForeignKey(d => d.IdMarca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMarca_CModelo");
            });

            modelBuilder.Entity<CPreAcondicionamiento>(entity =>
            {
                entity.HasKey(e => e.IdPreAcondicionamiento)
                    .HasName("PRIMARY");

                entity.ToTable("c_pre_acondicionamiento");

                entity.HasIndex(e => e.TbCarrosIdCarros)
                    .HasName("fk_C_Pre_Acondicionamiento_Tb_Carros1_idx");

                entity.Property(e => e.IdPreAcondicionamiento)
                    .HasColumnName("Id_Pre_Acondicionamiento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Hyp).HasColumnName("HYP");

                entity.Property(e => e.Mec).HasColumnName("MEC");

                entity.Property(e => e.TbCarrosIdCarros)
                    .HasColumnName("Tb_Carros_Id_Carros")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.TbCarrosIdCarrosNavigation)
                    .WithMany(p => p.CPreAcondicionamiento)
                    .HasForeignKey(d => d.TbCarrosIdCarros)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_C_Pre_Acondicionamiento_Tb_Carros1");
            });

            modelBuilder.Entity<CTipoGasto>(entity =>
            {
                entity.HasKey(e => e.IdTipoGasto)
                    .HasName("PRIMARY");

                entity.ToTable("c_tipo_gasto");

                entity.Property(e => e.IdTipoGasto)
                    .HasColumnName("Id_Tipo_Gasto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CVersionCarro>(entity =>
            {
                entity.HasKey(e => e.IdVersionCarro)
                    .HasName("PRIMARY");

                entity.ToTable("c_version_carro");

                entity.HasIndex(e => e.IdModelo)
                    .HasName("FK_CModelo_CVersion_idx");

                entity.Property(e => e.IdVersionCarro)
                    .HasColumnName("Id_Version_Carro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdModelo)
                    .HasColumnName("Id_Modelo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VersionCarro)
                    .HasColumnName("Version_Carro")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdModeloNavigation)
                    .WithMany(p => p.CVersionCarro)
                    .HasForeignKey(d => d.IdModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CModelo_CVersion");
            });

            modelBuilder.Entity<TbAdecuaciones>(entity =>
            {
                entity.HasKey(e => e.IdAdecuaciones)
                    .HasName("PRIMARY");

                entity.ToTable("tb_adecuaciones");

                entity.HasIndex(e => e.IdCarro)
                    .HasName("FK_Adecuaciones_Carros_idx");

                entity.Property(e => e.IdAdecuaciones)
                    .HasColumnName("Id_Adecuaciones")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdCarro)
                    .HasColumnName("Id_Carro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Lavado).HasColumnType("int(11)");

                entity.Property(e => e.LavadoVestiduras)
                    .HasColumnName("Lavado_Vestiduras")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mecanica)
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Motor)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Otros)
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Preparacion)
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PulidoEncerado)
                    .HasColumnName("Pulido_Encerado")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Traslado).HasColumnType("int(11)");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdCarroNavigation)
                    .WithMany(p => p.TbAdecuaciones)
                    .HasForeignKey(d => d.IdCarro)
                    .HasConstraintName("FK_Adecuaciones_Carros");
            });

            modelBuilder.Entity<TbCarros>(entity =>
            {
                entity.HasKey(e => e.IdCarros)
                    .HasName("PRIMARY");

                entity.ToTable("tb_carros");

                entity.HasIndex(e => e.CMarcaCarroIdMarcaCarro)
                    .HasName("fk_Tb_Carros_C_Marca_Carro1_idx");

                entity.HasIndex(e => e.IdEstado)
                    .HasName("FK_Carros_Estado_idx");

                entity.Property(e => e.IdCarros)
                    .HasColumnName("Id_Carros")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ano).HasColumnType("int(11)");

                entity.Property(e => e.Antiguedad).HasColumnType("int(11)");

                entity.Property(e => e.CMarcaCarroIdMarcaCarro)
                    .HasColumnName("C_Marca_Carro_Id_Marca_Carro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Canal).HasColumnType("int(11)");

                entity.Property(e => e.ClaveVehicular)
                    .HasColumnName("Clave_Vehicular")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ColorExt)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ColorInt)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DuenoAnterior)
                    .HasColumnName("Dueno_anterior")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FechaFactToma)
                    .HasColumnName("FechaFact(toma)")
                    .HasColumnType("date");

                entity.Property(e => e.FolioFiscal)
                    .HasColumnName("Folio_Fiscal")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("Id_Estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdProveedor)
                    .HasColumnName("Id_Proveedor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Kms).HasColumnType("int(11)");

                entity.Property(e => e.MvaOpc)
                    .HasColumnName("MVA_opc")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NoMotor)
                    .HasColumnName("No_Motor")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NoSerie)
                    .HasColumnName("No_Serie")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NumEconomicoOpc)
                    .HasColumnName("Num_Economico_opc")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Origen)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PropuestaCliente).HasColumnName("Propuesta_Cliente");

                entity.Property(e => e.TipoCompra)
                    .HasColumnName("Tipo_Compra")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Transmicion).HasColumnType("int(11)");

                entity.Property(e => e.Ubicacion)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.CMarcaCarroIdMarcaCarroNavigation)
                    .WithMany(p => p.TbCarros)
                    .HasForeignKey(d => d.CMarcaCarroIdMarcaCarro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Tb_Carros_C_Marca_Carro1");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.TbCarros)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_Carros_Estado");
            });

            modelBuilder.Entity<TbCarrosTransaccion>(entity =>
            {
                entity.HasKey(e => e.IdCarrosTransaccion)
                    .HasName("PRIMARY");

                entity.ToTable("tb_carros_transaccion");

                entity.HasIndex(e => e.IdCarro)
                    .HasName("FK_Carros_CT_idx");

                entity.HasIndex(e => e.IdControl)
                    .HasName("FK_Control_CT_idx");

                entity.HasIndex(e => e.IdEstado)
                    .HasName("FK_Estados_CT_idx");

                entity.Property(e => e.IdCarrosTransaccion)
                    .HasColumnName("Id_Carros_Transaccion")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdCarro)
                    .HasColumnName("Id_Carro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdControl)
                    .HasColumnName("Id_Control")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("Id_Estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipoVenta)
                    .HasColumnName("Tipo_Venta")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdCarroNavigation)
                    .WithMany(p => p.TbCarrosTransaccion)
                    .HasForeignKey(d => d.IdCarro)
                    .HasConstraintName("FK_Carros_CT");

                entity.HasOne(d => d.IdControlNavigation)
                    .WithMany(p => p.TbCarrosTransaccion)
                    .HasForeignKey(d => d.IdControl)
                    .HasConstraintName("FK_Control_CT");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.TbCarrosTransaccion)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_Estados_CT");
            });

            modelBuilder.Entity<TbComprobantes>(entity =>
            {
                entity.HasKey(e => e.IdComprobantes)
                    .HasName("PRIMARY");

                entity.ToTable("tb_comprobantes");

                entity.HasIndex(e => e.IdControl)
                    .HasName("FK_Comprobantes_idx");

                entity.HasIndex(e => e.IdEstado)
                    .HasName("FK_Comrpobante_Estado_idx");

                entity.Property(e => e.IdComprobantes)
                    .HasColumnName("Id_Comprobantes")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BajaCambProp)
                    .HasColumnName("Baja_Camb_Prop")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComprobantesPago)
                    .HasColumnName("Comprobantes_Pago")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComprobarId)
                    .HasColumnName("Comprobar_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConstamcoaFiscal)
                    .HasColumnName("Constamcoa_Fiscal")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Contrato).HasColumnType("int(11)");

                entity.Property(e => e.CurpPf)
                    .HasColumnName("CURP_PF")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdControl)
                    .HasColumnName("Id_control")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("Id_Estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LeyAntilavado)
                    .HasColumnName("Ley_Antilavado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Usuarios)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdControlNavigation)
                    .WithMany(p => p.TbComprobantes)
                    .HasForeignKey(d => d.IdControl)
                    .HasConstraintName("FK_Comprobantes");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.TbComprobantes)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_Comrpobante_Estado");
            });

            modelBuilder.Entity<TbCondiciones>(entity =>
            {
                entity.HasKey(e => e.IdCondiciones)
                    .HasName("PRIMARY");

                entity.ToTable("tb_condiciones");

                entity.HasIndex(e => e.IdCarro)
                    .HasName("FK_Concidion_Carro_idx");

                entity.HasIndex(e => e.IdEstado)
                    .HasName("FK_Condicion_Estado_idx");

                entity.Property(e => e.IdCondiciones)
                    .HasColumnName("Id_Condiciones")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DescripcionPiezas)
                    .HasColumnName("Descripcion_Piezas")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdCarro)
                    .HasColumnName("Id_Carro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("Id_estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PiezasRotas)
                    .HasColumnName("Piezas_Rotas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdCarroNavigation)
                    .WithMany(p => p.TbCondiciones)
                    .HasForeignKey(d => d.IdCarro)
                    .HasConstraintName("FK_Condicion_Carro");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.TbCondiciones)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_Condicion_Estado");
            });

            modelBuilder.Entity<TbConta>(entity =>
            {
                entity.HasKey(e => e.IdConta)
                    .HasName("PRIMARY");

                entity.ToTable("tb_conta");

                entity.HasIndex(e => e.IdBanco)
                    .HasName("FK_Conta_NB_idx");

                entity.Property(e => e.IdConta)
                    .HasColumnName("Id_Conta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CargoAbono)
                    .HasColumnName("Cargo_Abono")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaTramite)
                    .HasColumnName("Fecha_Tramite")
                    .HasColumnType("date");

                entity.Property(e => e.IdBanco)
                    .HasColumnName("Id_Banco")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdBancoNavigation)
                    .WithMany(p => p.TbConta)
                    .HasForeignKey(d => d.IdBanco)
                    .HasConstraintName("FK_Conta_NB");
            });

            modelBuilder.Entity<TbControl>(entity =>
            {
                entity.HasKey(e => e.IdMovimiento)
                    .HasName("PRIMARY");

                entity.ToTable("tb_control");

                entity.HasIndex(e => e.IdEstado)
                    .HasName("FK_Control_Estado_idx");

                entity.HasIndex(e => e.IdFormaPago)
                    .HasName("FK_Control_FormaPago_idx");

                entity.Property(e => e.IdMovimiento)
                    .HasColumnName("Id_Movimiento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Banco)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CantidadDebida).HasColumnName("Cantidad_Debida");

                entity.Property(e => e.ClienteVenta)
                    .HasColumnName("Cliente_Venta")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CompraVenta)
                    .HasColumnName("Compra_Venta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Debiendo).HasColumnType("int(11)");

                entity.Property(e => e.Factura)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaActual)
                    .HasColumnName("Fecha_Actual")
                    .HasColumnType("date");

                entity.Property(e => e.FechaES)
                    .HasColumnName("Fecha_E_S")
                    .HasColumnType("date");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("Fecha_Factura")
                    .HasColumnType("date");

                entity.Property(e => e.FechaPagado)
                    .HasColumnName("Fecha_Pagado")
                    .HasColumnType("date");

                entity.Property(e => e.IdCarros)
                    .HasColumnName("Id_Carros")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("Id_Cliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("Id_Estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdFormaPago)
                    .HasColumnName("Id_Forma_Pago")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Isan)
                    .HasColumnName("ISAN")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Iva).HasColumnName("IVA");

                entity.Property(e => e.LineaCaptura)
                    .HasColumnName("Linea_Captura")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MetodoPago)
                    .HasColumnName("Metodo_Pago")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PNeto).HasColumnName("P_Neto");

                entity.Property(e => e.Pagada).HasColumnType("int(11)");

                entity.Property(e => e.PrecioPactado).HasColumnName("Precio_Pactado");

                entity.Property(e => e.Repuve)
                    .HasColumnName("REPUVE")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubTotal).HasColumnName("Sub_Total");

                entity.Property(e => e.TipoVenta)
                    .HasColumnName("Tipo_Venta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Usuarios)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VoBoFacturarSat)
                    .HasColumnName("Vo_BO_Facturar_SAT")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.TbControl)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_Control_Estado");

                entity.HasOne(d => d.IdFormaPagoNavigation)
                    .WithMany(p => p.TbControl)
                    .HasForeignKey(d => d.IdFormaPago)
                    .HasConstraintName("FK_Control_FormaPago");
            });

            modelBuilder.Entity<TbDatosPersona>(entity =>
            {
                entity.HasKey(e => e.IdDatosPersona)
                    .HasName("PRIMARY");

                entity.ToTable("tb_datos_persona");

                entity.HasIndex(e => e.IdEstado)
                    .HasName("FK_Datos_Persona_Estado_idx");

                entity.HasIndex(e => e.IdPmDp)
                    .HasName("FK_DP_DPM_idx");

                entity.Property(e => e.IdDatosPersona)
                    .HasColumnName("Id_Datos_Persona")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActividadUOcupacion)
                    .HasColumnName("Actividad_u_Ocupacion")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ApellidoMaterno)
                    .HasColumnName("Apellido_Materno")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ApellidoPaterno)
                    .HasColumnName("Apellido_Paterno")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AutoridadEmite)
                    .HasColumnName("Autoridad_Emite")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cd)
                    .HasColumnName("CD")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Colonia)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Curp)
                    .HasColumnName("CURP")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Estado)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("Fecha_Nacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.FechaPoderNotorial)
                    .HasColumnName("Fecha_Poder_Notorial")
                    .HasColumnType("date");

                entity.Property(e => e.FisicaOMoral)
                    .HasColumnName("Fisica_o_Moral")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("Id_Estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPmDp)
                    .HasColumnName("Id_PM_DP")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nacionalidad)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NoExterior)
                    .HasColumnName("No_Exterior")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NoInterior)
                    .HasColumnName("No_Interior")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NoPoderNotorial)
                    .HasColumnName("No_Poder_Notorial")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nombre)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NombreCalle)
                    .HasColumnName("Nombre_Calle")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NumeroTelefono)
                    .HasColumnName("Numero_Telefono")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Puesto)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.TbDatosPersona)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_Datos_Persona_Estado");

                entity.HasOne(d => d.IdPmDpNavigation)
                    .WithMany(p => p.TbDatosPersona)
                    .HasForeignKey(d => d.IdPmDp)
                    .HasConstraintName("FK_DP_DPM");
            });

            modelBuilder.Entity<TbDatosPersonaMoral>(entity =>
            {
                entity.HasKey(e => e.IdDatosPm)
                    .HasName("PRIMARY");

                entity.ToTable("tb_datos_persona_moral");

                entity.HasIndex(e => e.IdEstado)
                    .HasName("FK_PF_Estado_idx");

                entity.Property(e => e.IdDatosPm)
                    .HasColumnName("Id_Datos_PM")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActividadGiroMercantilObjeto)
                    .HasColumnName("Actividad_Giro_Mercantil_Objeto")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cd)
                    .HasColumnName("CD")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Colonia)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CorreoElectronico)
                    .HasColumnName("Correo_Electronico")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DenominacionRazonSocial)
                    .HasColumnName("Denominacion_Razon_Social")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Estado)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaConstitucion)
                    .HasColumnName("Fecha_Constitucion")
                    .HasColumnType("date");

                entity.Property(e => e.FechaRegistroPublicoComercio)
                    .HasColumnName("Fecha_Registro_Publico_Comercio")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("Id_Estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nacionalidad)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NoActa)
                    .HasColumnName("No_Acta")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NoRegistroPublicoComercio)
                    .HasColumnName("No_Registro_Publico_Comercio")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NombreCalle)
                    .HasColumnName("Nombre_Calle")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NumExterior)
                    .HasColumnName("Num_Exterior")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NumInterior)
                    .HasColumnName("Num_Interior")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NumTelefono)
                    .HasColumnName("Num_Telefono")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.TbDatosPersonaMoral)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_PF_Estado");
            });

            modelBuilder.Entity<TbExportacion>(entity =>
            {
                entity.HasKey(e => e.IdExportacion)
                    .HasName("PRIMARY");

                entity.ToTable("tb_exportacion");

                entity.HasIndex(e => e.IdEstado)
                    .HasName("FK_Exportacion_Estado_idx");

                entity.HasIndex(e => e.IdPersona)
                    .HasName("FK_Exportacion_Persona_idx");

                entity.Property(e => e.IdExportacion)
                    .HasColumnName("Id_Exportacion")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CartaPoderId)
                    .HasColumnName("Carta_Poder_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cfdi)
                    .HasColumnName("CFDI")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CfdiFpA).HasColumnName("CFDI_FP_A");

                entity.Property(e => e.Entregada).HasColumnType("int(11)");

                entity.Property(e => e.FechaFactura)
                    .HasColumnName("Fecha_Factura")
                    .HasColumnType("date");

                entity.Property(e => e.FechaPago)
                    .HasColumnName("Fecha_Pago")
                    .HasColumnType("date");

                entity.Property(e => e.FechaPromesaEntrega)
                    .HasColumnName("Fecha_Promesa_Entrega")
                    .HasColumnType("date");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("Id_Estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPersona)
                    .HasColumnName("Id_Persona")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NoFactura)
                    .HasColumnName("No_Factura")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservacionesReclamos)
                    .HasColumnName("Observaciones_Reclamos")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrdenCompra)
                    .HasColumnName("Orden_Compra")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pagada).HasColumnType("int(11)");

                entity.Property(e => e.PedimientoImpOk)
                    .HasColumnName("Pedimiento_Imp_ok")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SalidaAgencia)
                    .HasColumnName("Salida_Agencia")
                    .HasColumnType("date");

                entity.Property(e => e.ValorFactura).HasColumnName("Valor_Factura");

                entity.Property(e => e.Xml)
                    .HasColumnName("XML")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.TbExportacion)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_Exportacion_Estado");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.TbExportacion)
                    .HasForeignKey(d => d.IdPersona)
                    .HasConstraintName("FK_Exportacion_Persona");
            });

            modelBuilder.Entity<TbGastos>(entity =>
            {
                entity.HasKey(e => e.IdGastos)
                    .HasName("PRIMARY");

                entity.ToTable("tb_gastos");

                entity.HasIndex(e => e.IdCarro)
                    .HasName("Ident_Carros_Gastos_idx");

                entity.HasIndex(e => e.IdEstado)
                    .HasName("FK_Gastos_Estado_idx");

                entity.HasIndex(e => e.IdTipoGasto)
                    .HasName("fk_Tb_Gastos_C_Tipo_Gasto1_idx");

                entity.Property(e => e.IdGastos)
                    .HasColumnName("Id_Gastos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdCarro)
                    .HasColumnName("Id_Carro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("Id_Estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTipoGasto)
                    .HasColumnName("Id_Tipo_Gasto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdCarroNavigation)
                    .WithMany(p => p.TbGastos)
                    .HasForeignKey(d => d.IdCarro)
                    .HasConstraintName("FK_Carros_Gastos");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.TbGastos)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_Gastos_Estado");

                entity.HasOne(d => d.IdTipoGastoNavigation)
                    .WithMany(p => p.TbGastos)
                    .HasForeignKey(d => d.IdTipoGasto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Tb_Gastos_C_Tipo_Gasto1");
            });

            modelBuilder.Entity<TbLeyAntilavado>(entity =>
            {
                entity.HasKey(e => e.IdDocumentos)
                    .HasName("PRIMARY");

                entity.ToTable("tb_ley_antilavado");

                entity.HasIndex(e => e.IdDatosPersona)
                    .HasName("FK_Documentos_Datos_Persona_idx");

                entity.HasIndex(e => e.IdEstado)
                    .HasName("FK_Documentos_Estado_idx");

                entity.Property(e => e.IdDocumentos)
                    .HasColumnName("Id_Documentos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActaConstitutivaBoletaRpc)
                    .HasColumnName("Acta_Constitutiva_Boleta_RPC")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CifSat)
                    .HasColumnName("CIF_SAT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComprobDomicilio)
                    .HasColumnName("Comprob_Domicilio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConocimientoDuenoBeneficiario)
                    .HasColumnName("Conocimiento_Dueno_Beneficiario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConstanciaConocimiento)
                    .HasColumnName("Constancia_Conocimiento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Curp).HasColumnType("int(11)");

                entity.Property(e => e.IdDatosPersona)
                    .HasColumnName("Id_Datos_Persona")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("Id_Estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdentificacionVig)
                    .HasColumnName("Identificacion_Vig")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MesCorrespondiente)
                    .HasColumnName("Mes_Correspondiente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PoderLegarExp)
                    .HasColumnName("Poder_Legar_Exp")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdDatosPersonaNavigation)
                    .WithMany(p => p.TbLeyAntilavado)
                    .HasForeignKey(d => d.IdDatosPersona)
                    .HasConstraintName("FK_Documentos_Datos_Persona");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.TbLeyAntilavado)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_Documentos_Estado");
            });

            modelBuilder.Entity<TbPapelesCarro>(entity =>
            {
                entity.HasKey(e => e.IdPapelesCarro)
                    .HasName("PRIMARY");

                entity.ToTable("tb_papeles_carro");

                entity.HasIndex(e => e.IdCarro)
                    .HasName("FK_TbCarros_TbPapeles_idx");

                entity.HasIndex(e => e.IdEstado)
                    .HasName("FK_Papeles_Estado_idx");

                entity.Property(e => e.IdPapelesCarro)
                    .HasColumnName("Id_Papeles_Carro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Baja).HasColumnType("int(11)");

                entity.Property(e => e.FactOrigen)
                    .HasColumnName("Fact_Origen")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FechaUlltimaVerificacion)
                    .HasColumnName("Fecha_Ulltima_Verificacion")
                    .HasColumnType("date");

                entity.Property(e => e.IdCarro)
                    .HasColumnName("Id_Carro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEmisor)
                    .HasColumnName("Id_Emisor")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("Id_Estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mes)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefactCompleta)
                    .HasColumnName("Refact_Completa")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Repuve)
                    .HasColumnName("REPUVE")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tenencias4Anos)
                    .HasColumnName("Tenencias_4_anos")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Transunionfolio).HasColumnType("int(11)");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Verificacion).HasColumnType("int(11)");

                entity.HasOne(d => d.IdCarroNavigation)
                    .WithMany(p => p.TbPapelesCarro)
                    .HasForeignKey(d => d.IdCarro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbCarros_TbPapeles");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.TbPapelesCarro)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_Papeles_Estado");
            });

            modelBuilder.Entity<TbPreciosTentativos>(entity =>
            {
                entity.HasKey(e => e.IdPreciosTentativos)
                    .HasName("PRIMARY");

                entity.ToTable("tb_precios_tentativos");

                entity.HasIndex(e => e.Estado)
                    .HasName("FK_Proveedor_Status_idx");

                entity.HasIndex(e => e.IdCarro)
                    .HasName("FK_PT_Carros_idx");

                entity.Property(e => e.IdPreciosTentativos)
                    .HasColumnName("Id_Precios_Tentativos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Estado).HasColumnType("int(11)");

                entity.Property(e => e.IdCarro)
                    .HasColumnName("Id_Carro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipoVenta)
                    .HasColumnName("Tipo_Venta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ub).HasColumnName("UB");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.TbPreciosTentativos)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("FK_Proveedor_Status");

                entity.HasOne(d => d.IdCarroNavigation)
                    .WithMany(p => p.TbPreciosTentativos)
                    .HasForeignKey(d => d.IdCarro)
                    .HasConstraintName("FK_PT_Carros");
            });

            modelBuilder.Entity<TbProveedor>(entity =>
            {
                entity.HasKey(e => e.IdProveedor)
                    .HasName("PRIMARY");

                entity.ToTable("tb_proveedor");

                entity.HasIndex(e => e.IdEstado)
                    .HasName("FK_Proveedor_Estado_idx");

                entity.Property(e => e.IdProveedor)
                    .HasColumnName("Id_Proveedor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Contacto)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Coreo)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Correo)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EncargadoCompras)
                    .HasColumnName("Encargado_Compras")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GerenteCompras)
                    .HasColumnName("Gerente_Compras")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("Id_Estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NombreComercial)
                    .HasColumnName("Nombre_Comercial")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Telefono)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ubicacion)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.TbProveedor)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_Proveedor_Estado");
            });

            modelBuilder.Entity<TbSeguimiento>(entity =>
            {
                entity.HasKey(e => e.IdSeguimiento)
                    .HasName("PRIMARY");

                entity.ToTable("tb_seguimiento");

                entity.HasIndex(e => e.CMedioPublicitario)
                    .HasName("fk_Tb_Seguimiento_C_Medio_Publicitario1_idx");

                entity.HasIndex(e => e.IdCarro)
                    .HasName("FK_Seguimiento_Carro_idx");

                entity.HasIndex(e => e.IdEstado)
                    .HasName("FK_Seguimiento_Estado_idx");

                entity.Property(e => e.IdSeguimiento)
                    .HasColumnName("Id_Seguimiento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Anticipo).HasColumnType("int(11)");

                entity.Property(e => e.AsesorAsignado)
                    .HasColumnName("Asesor_asignado")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Asistio).HasColumnType("int(11)");

                entity.Property(e => e.CMedioPublicitario)
                    .HasColumnName("C_Medio_Publicitario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cita).HasColumnType("int(11)");

                entity.Property(e => e.Comentarios)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContestaNc)
                    .HasColumnName("Contesta_NC")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Correo)
                    .HasColumnType("varchar(120)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DiaSemana)
                    .HasColumnName("Dia_Semana")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdCarro)
                    .HasColumnName("Id_Carro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("Id_Estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTipoCompra)
                    .HasColumnName("Id_Tipo_Compra")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NombreCompleto)
                    .HasColumnName("Nombre_Completo")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PruebaManejo)
                    .HasColumnName("Prueba_Manejo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Sexo)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Telefono)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Toma).HasColumnType("int(11)");

                entity.Property(e => e.Venta).HasColumnType("int(11)");

                entity.HasOne(d => d.CMedioPublicitarioNavigation)
                    .WithMany(p => p.TbSeguimiento)
                    .HasForeignKey(d => d.CMedioPublicitario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Tb_Seguimiento_C_Medio_Publicitario1");

                entity.HasOne(d => d.IdCarroNavigation)
                    .WithMany(p => p.TbSeguimiento)
                    .HasForeignKey(d => d.IdCarro)
                    .HasConstraintName("FK_Seguimiento_Carro");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.TbSeguimiento)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_Seguimiento_Estado");
            });

            modelBuilder.Entity<TbSeguro>(entity =>
            {
                entity.HasKey(e => e.IdSeguro)
                    .HasName("PRIMARY");

                entity.ToTable("tb_seguro");

                entity.HasIndex(e => e.IdControl)
                    .HasName("FK_Seguro_Control_idx");

                entity.Property(e => e.IdSeguro)
                    .HasColumnName("Id_Seguro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdControl)
                    .HasColumnName("Id_Control")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NomSeguro)
                    .HasColumnName("Nom_Seguro")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PolizaSeguro)
                    .HasColumnName("Poliza_Seguro")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdControlNavigation)
                    .WithMany(p => p.TbSeguro)
                    .HasForeignKey(d => d.IdControl)
                    .HasConstraintName("FK_Seguro_Control");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuarios)
                    .HasName("PRIMARY");

                entity.ToTable("usuarios");

                entity.HasIndex(e => e.IdEstado)
                    .HasName("FK_Usuarios_Estado_idx");

                entity.Property(e => e.IdUsuarios)
                    .HasColumnName("Id_Usuarios")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Contraseña)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("Id_Estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NombreUsuario)
                    .HasColumnName("Nombre_Usuario")
                    .HasColumnType("varchar(205)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoUsuario)
                    .HasColumnName("Tipo_Usuario")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_Usuarios_Estado");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
