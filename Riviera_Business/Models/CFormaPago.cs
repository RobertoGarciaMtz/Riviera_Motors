using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class CFormaPago
    {
        public CFormaPago()
        {
            TbControl = new HashSet<TbControl>();
        }

        public int IdFormaPago { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public int? IdEstado { get; set; }

        public virtual CEstados IdEstadoNavigation { get; set; }
        public virtual ICollection<TbControl> TbControl { get; set; }
    }
}
