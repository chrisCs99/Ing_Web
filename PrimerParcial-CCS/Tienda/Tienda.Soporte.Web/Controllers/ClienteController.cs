using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Soporte.Domain.Model.Soporte;
using Tienda.Soporte.Domain.Persistence;
using Tienda.Soporte.Domain.Persistence.Repository;
using Tienda.Soporte.Web.ViewModel;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Tienda.Soporte.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ClienteController(IClienteRepository clienteRepository,
            IUnitOfWork unitOfWork)
        {
            _clienteRepository = clienteRepository;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> InsertClient([FromBody] ClienteViewModel cliente)
        {
            try
            {
                Cliente obj = new Cliente(
                    id: cliente.Id,
                    nombres: cliente.Nombres,
                    apellidos: cliente.Apellidos,
                    telefono: cliente.Telefono,
                    correo: cliente.Correo,
                    direccion: cliente.Direccion
                    );

                await _clienteRepository.Insert(obj);
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
