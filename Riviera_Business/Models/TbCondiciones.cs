using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class TbCondiciones
    {
        public int IdCondiciones { get; set; }
        public int? PiezasRotas { get; set; }
        public string DescripcionPiezas { get; set; }
        public int? IdEstado { get; set; }
        public int? IdCarro { get; set; }
        public string Usuario { get; set; }

        public virtual TbControl IdCarroNavigation { get; set; }
        public virtual CEstados IdEstadoNavigation { get; set; }
    }
}
