using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class TbSeguimiento
    {
        public int IdSeguimiento { get; set; }
        public string NombreCompleto { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int CMedioPublicitario { get; set; }
        public string DiaSemana { get; set; }
        public DateTime? Fecha { get; set; }
        public string Sexo { get; set; }
        public string AsesorAsignado { get; set; }
        public int? IdCarro { get; set; }
        public int? ContestaNc { get; set; }
        public int? Cita { get; set; }
        public int? Asistio { get; set; }
        public int? Toma { get; set; }
        public int? PruebaManejo { get; set; }
        public int? IdTipoCompra { get; set; }
        public int? Anticipo { get; set; }
        public int? Venta { get; set; }
        public string Comentarios { get; set; }
        public int? IdEstado { get; set; }

        public virtual CMedioPublicitario CMedioPublicitarioNavigation { get; set; }
        public virtual TbCarros IdCarroNavigation { get; set; }
        public virtual CEstados IdEstadoNavigation { get; set; }
    }
}
