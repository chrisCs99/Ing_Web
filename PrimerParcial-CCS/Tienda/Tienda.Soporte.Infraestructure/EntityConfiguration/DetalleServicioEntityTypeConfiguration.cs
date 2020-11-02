using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Infraestructure.EntityConfiguration
{
    class DetalleServicioEntityTypeConfiguration : IEntityTypeConfiguration<DetalleServicio>
    {
        public void Configure(EntityTypeBuilder<DetalleServicio> builder)
        {
            builder
                .HasKey(x => x.Id)
                .HasName("detalleServicioId");

            builder
                .Property(x => x.TipoServicio)
                .HasColumnName("tipoServicio")
                .IsRequired();

            builder
                .Property(x => x.Precio)
                .HasColumnName("precioServicio")
                .IsRequired();

            builder
                .Property(x => x.Descripcion_Servicio)
                .HasColumnName("descripcionServicio")
                .IsRequired();
        }
    }
}
