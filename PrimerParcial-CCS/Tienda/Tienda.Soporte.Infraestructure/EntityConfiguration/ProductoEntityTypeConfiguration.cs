using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Infraestructure.EntityConfiguration
{
    class ProductoEntityTypeConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder
                .HasKey(x => x.Id)
                .HasName("productoId");

            builder
                .Property(x => x.NombreProd)
                .HasColumnName("nombreProd")
                .IsRequired();

            builder
                .Property(x => x.Categoria)
                .HasColumnName("categoria")
                .IsRequired();
        }
    }
}
