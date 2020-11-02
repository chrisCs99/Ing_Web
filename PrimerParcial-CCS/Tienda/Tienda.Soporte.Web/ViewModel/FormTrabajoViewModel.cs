using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tienda.Soporte.Web.ViewModel
{
    public class FormTrabajoViewModel
    {
        public Guid Cita { get; set; }
        public string DetalleTrabajo { get; set; }
        public DateTime? FechaFormulario { get; set; }
        public Guid OrdenServicio{ get; set; }
    }
}
