using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riviera_Business.Models
{
    public partial class ZCopiaControlPersonas
    {

        public ZCopiaControlPersonas()
        {
            TbCarrosTransaccion = new HashSet<TbCarrosTransaccion>();
            TbComprobantes = new HashSet<TbComprobantes>();
            TbCondiciones = new HashSet<TbCondiciones>();
            TbSeguro = new HashSet<TbSeguro>();
            TbDatosPersonaMoral = new HashSet<TbDatosPersonaMoral>();
            TbExportacion = new HashSet<TbExportacion>();
            TbLeyAntilavado = new HashSet<TbLeyAntilavado>();
        }
        public int IdMovimiento { get; set; }
        public float? Medias { get; set; }
        public string ClienteVenta { get; set; }
        public string VoBoFacturarSat { get; set; }
        public string Usuarios { get; set; }
        public DateTime? FechaActual { get; set; }
        public int? IdCarros { get; set; }
        public int? IdCliente { get; set; }
        public int? TipoVenta { get; set; }
        public float? SubTotal { get; set; }
        public float? Iva { get; set; }
        public float? Total { get; set; }
        public int? Pagada { get; set; }
        public int? CompraVenta { get; set; }
        public int? IdFormaPago { get; set; }
        public string LineaCaptura { get; set; }
        public string MetodoPago { get; set; }
        public string Banco { get; set; }
        public DateTime? FechaES { get; set; }
        public string Factura { get; set; }
        public string Repuve { get; set; }
        public string Isan { get; set; }
        public float? PNeto { get; set; }
        public DateTime? FechaFactura { get; set; }
        public int? IdEstado { get; set; }
        public float? PrecioPactado { get; set; }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///
        public int IdDatosPersona { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string ActividadUOcupacion { get; set; }
        public string NombreCalle { get; set; }
        public string NoInterior { get; set; }
        public string NoExterior { get; set; }
        public string Colonia { get; set; }
        public string Cd { get; set; }
        public string Estado { get; set; }
        public string Cp { get; set; }
        public string Curp { get; set; }
        public string Rfc { get; set; }
        public string NumeroTelefono { get; set; }
        public int? FisicaOMoral { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaPoderNotorial { get; set; }
        public string NoPoderNotorial { get; set; }
        public string AutoridadEmite { get; set; }

        public virtual CEstados IdEstadoNavigation { get; set; }
        public virtual CFormaPago IdFormaPagoNavigation { get; set; }
        public virtual ICollection<TbCarrosTransaccion> TbCarrosTransaccion { get; set; }
        public virtual ICollection<TbComprobantes> TbComprobantes { get; set; }
        public virtual ICollection<TbCondiciones> TbCondiciones { get; set; }
        public virtual ICollection<TbSeguro> TbSeguro { get; set; }
        public virtual ICollection<TbDatosPersonaMoral> TbDatosPersonaMoral { get; set; }
        public virtual ICollection<TbExportacion> TbExportacion { get; set; }
        public virtual ICollection<TbLeyAntilavado> TbLeyAntilavado { get; set; }

    }
}
