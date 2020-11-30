using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class CEstados
    {
        public CEstados()
        {
            CCarroExtra = new HashSet<CCarroExtra>();
            CFormaPago = new HashSet<CFormaPago>();
            CGuiaAutometricaEbc = new HashSet<CGuiaAutometricaEbc>();
            CMedioPublicitario = new HashSet<CMedioPublicitario>();
            TbCarros = new HashSet<TbCarros>();
            TbCarrosTransaccion = new HashSet<TbCarrosTransaccion>();
            TbComprobantes = new HashSet<TbComprobantes>();
            TbCondiciones = new HashSet<TbCondiciones>();
            TbControl = new HashSet<TbControl>();
            TbDatosPersona = new HashSet<TbDatosPersona>();
            TbDatosPersonaMoral = new HashSet<TbDatosPersonaMoral>();
            TbExportacion = new HashSet<TbExportacion>();
            TbGastos = new HashSet<TbGastos>();
            TbLeyAntilavado = new HashSet<TbLeyAntilavado>();
            TbPapelesCarro = new HashSet<TbPapelesCarro>();
            TbPreciosTentativos = new HashSet<TbPreciosTentativos>();
            TbProveedor = new HashSet<TbProveedor>();
            TbSeguimiento = new HashSet<TbSeguimiento>();
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdEstados { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<CCarroExtra> CCarroExtra { get; set; }
        public virtual ICollection<CFormaPago> CFormaPago { get; set; }
        public virtual ICollection<CGuiaAutometricaEbc> CGuiaAutometricaEbc { get; set; }
        public virtual ICollection<CMedioPublicitario> CMedioPublicitario { get; set; }
        public virtual ICollection<TbCarros> TbCarros { get; set; }
        public virtual ICollection<TbCarrosTransaccion> TbCarrosTransaccion { get; set; }
        public virtual ICollection<TbComprobantes> TbComprobantes { get; set; }
        public virtual ICollection<TbCondiciones> TbCondiciones { get; set; }
        public virtual ICollection<TbControl> TbControl { get; set; }
        public virtual ICollection<TbDatosPersona> TbDatosPersona { get; set; }
        public virtual ICollection<TbDatosPersonaMoral> TbDatosPersonaMoral { get; set; }
        public virtual ICollection<TbExportacion> TbExportacion { get; set; }
        public virtual ICollection<TbGastos> TbGastos { get; set; }
        public virtual ICollection<TbLeyAntilavado> TbLeyAntilavado { get; set; }
        public virtual ICollection<TbPapelesCarro> TbPapelesCarro { get; set; }
        public virtual ICollection<TbPreciosTentativos> TbPreciosTentativos { get; set; }
        public virtual ICollection<TbProveedor> TbProveedor { get; set; }
        public virtual ICollection<TbSeguimiento> TbSeguimiento { get; set; }
        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
