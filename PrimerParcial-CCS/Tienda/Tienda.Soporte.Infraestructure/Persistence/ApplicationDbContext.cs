using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.Domain.Model.Soporte;
using Tienda.Soporte.Infraestructure.EntityConfiguration;

namespace Tienda.Soporte.Infraestructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; private set; }
        public DbSet<Tecnico> Tecnicos { get; private set; }
        public DbSet<OrdenServicio> OrdenServicios { get; private set; }
        public DbSet<DetalleServicio> DetalleServicios { get; private set; }
        public DbSet<OrdenProducto> OrdenProductos { get; private set; }
        public DbSet<Cita> Citas { get; private set; }
        public DbSet<CitaTecnico> CitaTecnicos { get; private set; }
        public DbSet<FormTrabajo> FormTrabajos { get; private set; }
        public DbSet<Producto> Productos { get; private set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {  
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ClienteEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OrdenServicioEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TecnicoEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CitaEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DetalleServicioEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OrdenProductoEntitiyTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FormTrabajoEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductoEntityTypeConfiguration());
        }
    }
}
