﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tienda.Soporte.Infraestructure.Persistence;

namespace Tienda.Soporte.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201101041024_updates")]
    partial class updates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.Cita", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescripcionCita")
                        .IsRequired()
                        .HasColumnName("descripcionCita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnName("direccionCita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoCita")
                        .HasColumnName("estadoCita")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaVisita")
                        .HasColumnName("fechaVisita")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("OrdenServicioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id")
                        .HasName("citaId");

                    b.HasIndex("OrdenServicioId");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.CitaTecnico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CitaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TecnicoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CitaId");

                    b.HasIndex("TecnicoId");

                    b.ToTable("CitaTecnicos");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnName("direccionCliente")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("clienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.DetalleServicio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion_Servicio")
                        .IsRequired()
                        .HasColumnName("descripcionServicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("OrdenServicioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Precio")
                        .HasColumnName("precioServicio")
                        .HasColumnType("float");

                    b.Property<int>("TipoServicio")
                        .HasColumnName("tipoServicio")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("detalleServicioId");

                    b.HasIndex("OrdenServicioId");

                    b.ToTable("DetalleServicios");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.FormTrabajo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CitaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DetalleTrabajo")
                        .HasColumnName("detalleTrabajo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaFormulario")
                        .HasColumnName("fechaFormulario")
                        .HasColumnType("datetime2");

                    b.HasKey("Id")
                        .HasName("formTrabajoId");

                    b.HasIndex("CitaId");

                    b.ToTable("FormTrabajos");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.OrdenProducto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DetalleServicioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id")
                        .HasName("ordenProductoId");

                    b.HasIndex("DetalleServicioId");

                    b.HasIndex("ProductoId");

                    b.ToTable("OrdenProductos");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.OrdenServicio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EstadoOrden")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnName("fechaRegistro")
                        .HasColumnType("datetime2");

                    b.HasKey("Id")
                        .HasName("ordenServicioId");

                    b.HasIndex("ClienteId");

                    b.ToTable("OrdenServicios");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.Producto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnName("categoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreProd")
                        .IsRequired()
                        .HasColumnName("nombreProd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("productoId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.Tecnico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Oficio")
                        .HasColumnName("oficioTecnico")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("tecnicoId");

                    b.ToTable("Tecnicos");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.Cita", b =>
                {
                    b.HasOne("Tienda.Soporte.Domain.Model.Soporte.OrdenServicio", "OrdenServicio")
                        .WithMany()
                        .HasForeignKey("OrdenServicioId");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.CitaTecnico", b =>
                {
                    b.HasOne("Tienda.Soporte.Domain.Model.Soporte.Cita", "Cita")
                        .WithMany()
                        .HasForeignKey("CitaId");

                    b.HasOne("Tienda.Soporte.Domain.Model.Soporte.Tecnico", "Tecnico")
                        .WithMany()
                        .HasForeignKey("TecnicoId");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.Cliente", b =>
                {
                    b.OwnsOne("Tienda.Soporte.SharedKernel.ValueObjects.PersonEmail.PersonEmailValue", "Correo", b1 =>
                        {
                            b1.Property<Guid>("ClienteId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnName("correoCliente")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ClienteId");

                            b1.ToTable("Clientes");

                            b1.WithOwner()
                                .HasForeignKey("ClienteId");
                        });

                    b.OwnsOne("Tienda.Soporte.SharedKernel.ValueObjects.PersonNameValue", "Apellidos", b1 =>
                        {
                            b1.Property<Guid>("ClienteId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnName("apellidosCliente")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ClienteId");

                            b1.ToTable("Clientes");

                            b1.WithOwner()
                                .HasForeignKey("ClienteId");
                        });

                    b.OwnsOne("Tienda.Soporte.SharedKernel.ValueObjects.PersonNameValue", "Nombres", b1 =>
                        {
                            b1.Property<Guid>("ClienteId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnName("nombresCliente")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ClienteId");

                            b1.ToTable("Clientes");

                            b1.WithOwner()
                                .HasForeignKey("ClienteId");
                        });

                    b.OwnsOne("Tienda.Soporte.SharedKernel.ValueObjects.PhoneNumber.PhoneNumberValue", "Telefono", b1 =>
                        {
                            b1.Property<Guid>("ClienteId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnName("telefonoCliente")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ClienteId");

                            b1.ToTable("Clientes");

                            b1.WithOwner()
                                .HasForeignKey("ClienteId");
                        });
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.DetalleServicio", b =>
                {
                    b.HasOne("Tienda.Soporte.Domain.Model.Soporte.OrdenServicio", "OrdenServicio")
                        .WithMany()
                        .HasForeignKey("OrdenServicioId");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.FormTrabajo", b =>
                {
                    b.HasOne("Tienda.Soporte.Domain.Model.Soporte.Cita", "Cita")
                        .WithMany()
                        .HasForeignKey("CitaId");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.OrdenProducto", b =>
                {
                    b.HasOne("Tienda.Soporte.Domain.Model.Soporte.DetalleServicio", "DetalleServicio")
                        .WithMany()
                        .HasForeignKey("DetalleServicioId");

                    b.HasOne("Tienda.Soporte.Domain.Model.Soporte.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.OrdenServicio", b =>
                {
                    b.HasOne("Tienda.Soporte.Domain.Model.Soporte.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.Tecnico", b =>
                {
                    b.OwnsOne("Tienda.Soporte.SharedKernel.ValueObjects.PersonEmail.PersonEmailValue", "Correo", b1 =>
                        {
                            b1.Property<Guid>("TecnicoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnName("correoTecnico")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("TecnicoId");

                            b1.ToTable("Tecnicos");

                            b1.WithOwner()
                                .HasForeignKey("TecnicoId");
                        });

                    b.OwnsOne("Tienda.Soporte.SharedKernel.ValueObjects.PersonNameValue", "Apellidos", b1 =>
                        {
                            b1.Property<Guid>("TecnicoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnName("apellidosTecnico")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("TecnicoId");

                            b1.ToTable("Tecnicos");

                            b1.WithOwner()
                                .HasForeignKey("TecnicoId");
                        });

                    b.OwnsOne("Tienda.Soporte.SharedKernel.ValueObjects.PersonNameValue", "Nombres", b1 =>
                        {
                            b1.Property<Guid>("TecnicoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnName("nombresTecnico")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("TecnicoId");

                            b1.ToTable("Tecnicos");

                            b1.WithOwner()
                                .HasForeignKey("TecnicoId");
                        });

                    b.OwnsOne("Tienda.Soporte.SharedKernel.ValueObjects.PhoneNumber.PhoneNumberValue", "Telefono", b1 =>
                        {
                            b1.Property<Guid>("TecnicoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnName("telefonoTecnico")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("TecnicoId");

                            b1.ToTable("Tecnicos");

                            b1.WithOwner()
                                .HasForeignKey("TecnicoId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
