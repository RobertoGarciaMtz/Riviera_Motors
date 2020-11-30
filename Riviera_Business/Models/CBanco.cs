﻿using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class CBanco
    {
        public CBanco()
        {
            TbConta = new HashSet<TbConta>();
        }

        public int IdBanco { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<TbConta> TbConta { get; set; }
    }
}
