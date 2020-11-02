using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Infraestructure.EntityConfiguration
{
    class CitaTecnicoEntityTypeConfiguration : IEntityTypeConfiguration<CitaTecnico>
    {
        public void Configure(EntityTypeBuilder<CitaTecnico> builder)
        {
            builder
                .HasKey(x => x.Id)
                .HasName("citaTecnitoId");
        }
    }
}
