using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Infraestructure.EntityConfiguration
{
    class OrdenServicioEntityTypeConfiguration : IEntityTypeConfiguration<OrdenServicio>
    {
        public void Configure(EntityTypeBuilder<OrdenServicio> builder)
        {
            builder
                .HasKey(x => x.Id)
                .HasName("ordenServicioId");
            builder
                .Property(x => x.FechaRegistro)
                .HasColumnName("fechaRegistro")
                .IsRequired();
        }
    }
}
