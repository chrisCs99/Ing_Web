using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tienda.Soporte.Domain.Model.Soporte;
using Tienda.Soporte.Domain.Persistence;
using Tienda.Soporte.Domain.Persistence.Repository;
using Tienda.Soporte.Web.ViewModel;

namespace Tienda.Soporte.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormTrabajoController : ControllerBase
    {
        private readonly IFormTrabajoRepository _formTrabajoRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICitaRepository _citaRepository;
        private readonly IOrdenServicioRepository _ordenServicioRepository;

        public FormTrabajoController(IFormTrabajoRepository formTrabajoRepository, IUnitOfWork unitOfWork,
            ICitaRepository citaRepository, IOrdenServicioRepository ordenServicioRepository)
        {
            _formTrabajoRepository = formTrabajoRepository;
            _unitOfWork = unitOfWork;
            _citaRepository = citaRepository;
            _ordenServicioRepository = ordenServicioRepository;
        }

        [HttpPost]
        public async Task<IActionResult> InsertFormTrabajo([FromBody] FormTrabajoViewModel formTrabajo)
        {
            try
            {
                Cita objCita = await _citaRepository.GetCita(formTrabajo.Cita);
                OrdenServicio objServ = await _ordenServicioRepository.GetOrdenServicio(formTrabajo.OrdenServicio);
                FormTrabajo obj = new FormTrabajo(
                    cita: objCita,
                    detalleTrabajo: formTrabajo.DetalleTrabajo,
                    fechaFormulario: formTrabajo.FechaFormulario
                    );
                await _formTrabajoRepository.Insert(obj);
                objCita.EstadoCita = EstadoCita.Finalizada;
                objServ.EstadoOrden= EstadoOrdenServicio.FINALIZADA;
                _citaRepository.Update(objCita);
                _ordenServicioRepository.Update(objServ);
                await _unitOfWork.Commit();
                
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
                throw;
            }
        }
    }
}
