﻿using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class TbCarros
    {
        public TbCarros()
        {
            CCarroExtra = new HashSet<CCarroExtra>();
            CGuiaAutometricaEbc = new HashSet<CGuiaAutometricaEbc>();
            CPreAcondicionamiento = new HashSet<CPreAcondicionamiento>();
            TbAdecuaciones = new HashSet<TbAdecuaciones>();
            TbCarrosTransaccion = new HashSet<TbCarrosTransaccion>();
            TbGastos = new HashSet<TbGastos>();
            TbPapelesCarro = new HashSet<TbPapelesCarro>();
            TbPreciosTentativos = new HashSet<TbPreciosTentativos>();
            TbSeguimiento = new HashSet<TbSeguimiento>();
        }

        public int IdCarros { get; set; }
        public int? IdProveedor { get; set; }
        public int? TipoCompra { get; set; }
        public int? Kms { get; set; }
        public string FolioFiscal { get; set; }
        public DateTime? FechaFactToma { get; set; }
        public int? Antiguedad { get; set; }
        public int? Canal { get; set; }
        public int? Ano { get; set; }
        public string ColorExt { get; set; }
        public string ColorInt { get; set; }
        public string NoSerie { get; set; }
        public string NoMotor { get; set; }
        public string NumEconomicoOpc { get; set; }
        public string MvaOpc { get; set; }
        public int? Transmicion { get; set; }
        public string ClaveVehicular { get; set; }
        public int? IdEstado { get; set; }
        public string Usuario { get; set; }
        public int CMarcaCarroIdMarcaCarro { get; set; }
        public int? DuenoAnterior { get; set; }
        public string Origen { get; set; }
        public string Ubicacion { get; set; }
        public float? PropuestaCliente { get; set; }

        public virtual CMarcaCarro CMarcaCarroIdMarcaCarroNavigation { get; set; }
        public virtual CEstados IdEstadoNavigation { get; set; }
        public virtual ICollection<CCarroExtra> CCarroExtra { get; set; }
        public virtual ICollection<CGuiaAutometricaEbc> CGuiaAutometricaEbc { get; set; }
        public virtual ICollection<CPreAcondicionamiento> CPreAcondicionamiento { get; set; }
        public virtual ICollection<TbAdecuaciones> TbAdecuaciones { get; set; }
        public virtual ICollection<TbCarrosTransaccion> TbCarrosTransaccion { get; set; }
        public virtual ICollection<TbGastos> TbGastos { get; set; }
        public virtual ICollection<TbPapelesCarro> TbPapelesCarro { get; set; }
        public virtual ICollection<TbPreciosTentativos> TbPreciosTentativos { get; set; }
        public virtual ICollection<TbSeguimiento> TbSeguimiento { get; set; }
    }
}
