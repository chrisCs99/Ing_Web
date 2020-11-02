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
    public class OrdenServicioController : ControllerBase
    {
        private readonly IOrdenServicioRepository _ordenServicioRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IClienteRepository _clienteRepository;

        public OrdenServicioController(IOrdenServicioRepository ordenServicioRepository,
            IUnitOfWork unitOfWork, IClienteRepository clienteRepository)
        {
            _ordenServicioRepository = ordenServicioRepository;
            _unitOfWork = unitOfWork;
            _clienteRepository = clienteRepository;
        }

        [HttpPost]
        public async Task<IActionResult> InsertOrderService([FromBody] OrdenServicioViewModel orden)
        {
            try
            {
                Cliente objCliente = await _clienteRepository.GetCliente(orden.Cliente);
                OrdenServicio obj = new OrdenServicio(
                    cliente: objCliente
                    );
                await _ordenServicioRepository.Insert(obj);
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
                OrdenServicio obj = await _ordenServicioRepository.GetOrdenServicio(orden.Id);
                obj.EstadoOrden = 0;
                _ordenServicioRepository.Cancel(obj);
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
