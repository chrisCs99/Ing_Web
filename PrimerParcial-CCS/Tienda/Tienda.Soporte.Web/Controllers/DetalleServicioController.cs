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
    public class DetalleServicioController : ControllerBase
    {
        private readonly IDetalleServicioRepository _detalleServicioRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOrdenServicioRepository _ordenServicioRepository;
        private readonly IProductoRepository _productoRepository;
        private readonly IOrdenProductoRepository _ordenProductoRepository;

        public DetalleServicioController(IDetalleServicioRepository detalleServicioRepository
            , IUnitOfWork unitOfWork, IOrdenServicioRepository ordenServicioRepository,
            IProductoRepository productoRepository, IOrdenProductoRepository ordenProductoRepository)
        {
            _detalleServicioRepository = detalleServicioRepository;
            _unitOfWork = unitOfWork;
            _ordenServicioRepository = ordenServicioRepository;
            _productoRepository = productoRepository;
            _ordenProductoRepository = ordenProductoRepository;
        }

        [HttpPost]
        public async Task<IActionResult> InsertDetalleSerivicio([FromBody] DetalleServicioViewModel detalleServicio)
        {
            try
            {
                OrdenServicio objOrden = await _ordenServicioRepository.GetOrdenServicio(detalleServicio.OrdenServicio);
                DetalleServicio obj = new DetalleServicio(
                    tipoServicio: (TipoServicio)detalleServicio.TipoServicio,
                    precio: detalleServicio.Precio,
                    ordenServicio: objOrden,
                    descripcion_servicio: detalleServicio.Descripcion_Servicio
                    );
                await _detalleServicioRepository.Insert(obj);
                foreach (var item in detalleServicio.Productos)
                {
                    Producto objProd = await _productoRepository.GetProducto(item);
                    OrdenProducto objOrd = new OrdenProducto(
                        producto: objProd,
                        detalleServicio: obj
                        );
                    await _ordenProductoRepository.Insert(objOrd);
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

    }
}
