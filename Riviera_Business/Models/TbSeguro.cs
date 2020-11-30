using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class TbSeguro
    {
        public int IdSeguro { get; set; }
        public string NomSeguro { get; set; }
        public int? IdControl { get; set; }
        public string PolizaSeguro { get; set; }

        public virtual TbControl IdControlNavigation { get; set; }
    }
}
