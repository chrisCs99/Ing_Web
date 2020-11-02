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
    public class CitaController : ControllerBase
    {
        private readonly ICitaRepository _citaRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICitaTecnicoRepository _citaTecnicoRepository;
        private readonly ITecnicoRepository _tecnicoRepository;
        private readonly IOrdenServicioRepository _ordenServicioRepository;

        public CitaController(ICitaRepository citaRepository, ICitaTecnicoRepository citaTecnicoRepository,
            IUnitOfWork unitOfWork, ITecnicoRepository tecnicoRepository, IOrdenServicioRepository ordenServicioRepository)
        {
            _citaRepository = citaRepository;
            _unitOfWork = unitOfWork;
            _citaTecnicoRepository = citaTecnicoRepository;
            _tecnicoRepository = tecnicoRepository;
            _ordenServicioRepository = ordenServicioRepository;
        }

        [HttpPost]
        public async Task<IActionResult> InsertCita([FromBody] CitaViewModel cita)
        {
            try
            {
                OrdenServicio objSer = await _ordenServicioRepository.GetOrdenServicio(cita.OrdenServicio);

                Cita obj = new Cita(
                    ordenServicio: objSer,
                    fechaVisita: cita.FechaVisita,
                    direccion: cita.Direccion,
                    descripcionCita: cita.DescripcionCita
                    );

                await _citaRepository.Insert(obj);
                //await _unitOfWork.Commit();

                //Cita objCita = await _citaRepository.GetLastInsert();
                //CitaTecnico obj2 = new CitaTecnico(
                //    cita: objCita,
                //    tecnico: objTec
                //    );
                foreach (var item in cita.Tecnico)
                {
                    Tecnico objTec = await _tecnicoRepository.GetTecnico(item);

                    CitaTecnico obj2 = new CitaTecnico(
                        cita: obj,
                        tecnico: objTec
                        );
                    await _citaTecnicoRepository.Insert(obj2);
                }
                await _unitOfWork.Commit();

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }
        }

        [HttpPost]
        [Route("cancel")]
        public async Task<IActionResult> CancelOrderService([FromBody] CancelItemsViewModel orden)
        {
            try
            {
                Cita obj = await _citaRepository.GetCita(orden.Id);
                obj.EstadoCita = (EstadoCita)3;

                _citaRepository.Cancel(obj);
                await _unitOfWork.Commit();
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
                throw;
            }
        }
    }
}
