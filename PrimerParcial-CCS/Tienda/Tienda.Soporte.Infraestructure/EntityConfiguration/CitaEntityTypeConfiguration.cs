using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Infraestructure.EntityConfiguration
{
    class CitaEntityTypeConfiguration : IEntityTypeConfiguration<Cita>
    {
        public void Configure(EntityTypeBuilder<Cita> builder)
        {
            builder
                .HasKey(x => x.Id)
                .HasName("citaId");

            builder
                .Property(x => x.EstadoCita)
                .HasColumnName("estadoCita")
                .IsRequired();

            builder
                .Property(x => x.FechaVisita)
                .HasColumnName("fechaVisita");

            builder
                .Property(x => x.Direccion)
                .HasColumnName("direccionCita")
                .IsRequired();

            builder
                .Property(x => x.DescripcionCita)
                .HasColumnName("descripcionCita")
                .IsRequired();
        }
    }
}
