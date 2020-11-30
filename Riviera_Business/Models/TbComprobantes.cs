using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class TbComprobantes
    {
        public int IdComprobantes { get; set; }
        public int? Contrato { get; set; }
        public int? LeyAntilavado { get; set; }
        public int? BajaCambProp { get; set; }
        public int? ComprobarId { get; set; }
        public int? ConstamcoaFiscal { get; set; }
        public int? CurpPf { get; set; }
        public int? ComprobantesPago { get; set; }
        public int? IdEstado { get; set; }
        public string Usuarios { get; set; }
        public int? IdControl { get; set; }

        public virtual TbControl IdControlNavigation { get; set; }
        public virtual CEstados IdEstadoNavigation { get; set; }
    }
}
