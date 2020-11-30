using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class CMarcaCarro
    {
        public CMarcaCarro()
        {
            CModeloCarro = new HashSet<CModeloCarro>();
            TbCarros = new HashSet<TbCarros>();
        }

        public int IdMarcaCarro { get; set; }
        public string NombreMarca { get; set; }
        public string Usuario { get; set; }

        public virtual ICollection<CModeloCarro> CModeloCarro { get; set; }
        public virtual ICollection<TbCarros> TbCarros { get; set; }
    }
}
