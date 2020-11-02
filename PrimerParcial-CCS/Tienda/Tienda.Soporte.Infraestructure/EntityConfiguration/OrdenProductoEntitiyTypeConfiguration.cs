using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Infraestructure.EntityConfiguration
{
    class OrdenProductoEntitiyTypeConfiguration : IEntityTypeConfiguration<OrdenProducto>
    {
        public void Configure(EntityTypeBuilder<OrdenProducto> builder)
        {
            builder
                .HasKey(x => x.Id)
                .HasName("ordenProductoId");
        }
    }
}
