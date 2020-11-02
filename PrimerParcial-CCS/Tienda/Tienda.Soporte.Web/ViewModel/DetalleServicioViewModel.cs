using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Web.ViewModel
{
    public class DetalleServicioViewModel
    {
        public int TipoServicio { get; set; }
        public double Precio { get; set; }
        public Guid OrdenServicio { get; set; }
        public string Descripcion_Servicio { get; set; }
        public List<Guid> Productos { get; set; }
    }
}
