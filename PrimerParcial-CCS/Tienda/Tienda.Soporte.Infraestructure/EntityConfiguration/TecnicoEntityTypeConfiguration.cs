using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Infraestructure.EntityConfiguration
{
    class TecnicoEntityTypeConfiguration : IEntityTypeConfiguration<Tecnico>
    {
        public void Configure(EntityTypeBuilder<Tecnico> builder)
        {
            builder
                .HasKey(x => x.Id)
                .HasName("tecnicoId");

            builder
                .OwnsOne(x => x.Nombres)
                .Property(x => x.Value)
                .HasColumnName("nombresTecnico")
                .IsRequired();

            builder
                .OwnsOne(x => x.Apellidos)
                .Property(x => x.Value)
                .HasColumnName("apellidosTecnico")
                .IsRequired();

            builder
                .OwnsOne(x => x.Correo)
                .Property(x => x.Value)
                .HasColumnName("correoTecnico")
                .IsRequired();

            builder
                .OwnsOne(x => x.Telefono)
                .Property(x => x.Value)
                .HasColumnName("telefonoTecnico")
                .IsRequired();

            builder.Property(x => x.Oficio)
                .HasColumnName("oficioTecnico")
                .IsRequired();
        }
    }
}
