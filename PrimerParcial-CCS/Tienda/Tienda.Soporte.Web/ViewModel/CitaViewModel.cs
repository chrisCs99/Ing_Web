using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Web.ViewModel
{
    public class CitaViewModel
    {
        public Guid OrdenServicio { get; set; }
        public DateTime? FechaVisita { get; set; }
        public string Direccion { get; set; }
        public string DescripcionCita { get; set; }
        public List<Guid> Tecnico { get; set; }
    }
}
