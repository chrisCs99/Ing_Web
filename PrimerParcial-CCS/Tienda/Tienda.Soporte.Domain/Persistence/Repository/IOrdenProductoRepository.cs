﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Domain.Persistence.Repository
{
    public interface IOrdenProductoRepository
    {
        Task Insert(OrdenProducto ordenProducto);
        Task<OrdenProducto> GetOrdenProducto(Guid ordenProductoId);
    }
}
