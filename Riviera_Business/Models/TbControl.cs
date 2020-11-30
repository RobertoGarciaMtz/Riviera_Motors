using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class TbControl
    {
        public TbControl()
        {
            TbCarrosTransaccion = new HashSet<TbCarrosTransaccion>();
            TbComprobantes = new HashSet<TbComprobantes>();
            TbCondiciones = new HashSet<TbCondiciones>();
            TbSeguro = new HashSet<TbSeguro>();
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
        public int? Debiendo { get; set; }
        public float? CantidadDebida { get; set; }
        public DateTime? FechaPagado { get; set; }

        public virtual CEstados IdEstadoNavigation { get; set; }
        public virtual CFormaPago IdFormaPagoNavigation { get; set; }
        public virtual ICollection<TbCarrosTransaccion> TbCarrosTransaccion { get; set; }
        public virtual ICollection<TbComprobantes> TbComprobantes { get; set; }
        public virtual ICollection<TbCondiciones> TbCondiciones { get; set; }
        public virtual ICollection<TbSeguro> TbSeguro { get; set; }
    }
}
