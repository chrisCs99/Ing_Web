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
    public class ProductoController : ControllerBase
    {
        private readonly IProductoRepository _productoRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductoController(IProductoRepository productoRepository, IUnitOfWork unitOfWork)
        {
            _productoRepository = productoRepository;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> InsertProduct([FromBody] ProductoViewModel producto)
        {
            try
            {
                Producto obj = new Producto(
                    nombreProd: producto.NombreProd,
                    categoria: producto.Categoria
                    );

                await _productoRepository.Insert(obj);
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
