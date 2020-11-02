using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Infraestructure.EntityConfiguration
{
    class FormTrabajoEntityTypeConfiguration : IEntityTypeConfiguration<FormTrabajo>
    {
        public void Configure(EntityTypeBuilder<FormTrabajo> builder)
        {
            builder
                .HasKey(x => x.Id)
                .HasName("formTrabajoId");

            builder
                .Property(x => x.DetalleTrabajo)
                .HasColumnName("detalleTrabajo");

            builder
                .Property(x => x.FechaFormulario)
                .HasColumnName("fechaFormulario");
        }
    }
}
