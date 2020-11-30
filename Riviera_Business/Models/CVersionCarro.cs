using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class CVersionCarro
    {
        public int IdVersionCarro { get; set; }
        public string VersionCarro { get; set; }
        public string Usuario { get; set; }
        public int IdModelo { get; set; }

        public virtual CModeloCarro IdModeloNavigation { get; set; }
    }
}
