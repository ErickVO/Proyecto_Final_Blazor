﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudioEF.DAL;

namespace StudioEF.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("StudioEF.Models.Articulos", b =>
                {
                    b.Property<int>("ArticuloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Costo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(40);

                    b.Property<decimal>("Precio")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Stock")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ArticuloId");

                    b.ToTable("Articulos");
                });

            modelBuilder.Entity("StudioEF.Models.Categorias", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("StudioEF.Models.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellidos")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cedula")
                        .HasColumnType("TEXT");

                    b.Property<string>("Celular")
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("StudioEF.Models.Compras", b =>
                {
                    b.Property<int>("CompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Monto")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CompraId");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("StudioEF.Models.ComprasDetalle", b =>
                {
                    b.Property<int>("ComprasDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArticuloId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ArticulosId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadArticulos")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompraId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Costo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(40);

                    b.HasKey("ComprasDetalleId");

                    b.HasIndex("ArticulosId");

                    b.HasIndex("CompraId");

                    b.ToTable("ComprasDetalle");
                });

            modelBuilder.Entity("StudioEF.Models.Eventos", b =>
                {
                    b.Property<int>("EventoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("TEXT");

                    b.Property<int>("FotografoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lugar")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Precio")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("EventoId");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("StudioEF.Models.Fotografos", b =>
                {
                    b.Property<int>("FotografoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellidos")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cedula")
                        .HasColumnType("TEXT");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(10);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Sueldo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FotografoId");

                    b.ToTable("Fotografos");

                    b.HasData(
                        new
                        {
                            FotografoId = 1,
                            Apellidos = "Minalla",
                            Cedula = "1231231234",
                            Celular = "8297123444",
                            Direccion = "su casa",
                            FechaNacimiento = new DateTime(2020, 8, 4, 2, 31, 5, 512, DateTimeKind.Local).AddTicks(2846),
                            Nombres = "Juan Roque",
                            Sexo = "Hombre",
                            Sueldo = 2000m,
                            Telefono = "8092124433",
                            UsuarioId = 1
                        });
                });

            modelBuilder.Entity("StudioEF.Models.Usuarios", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            UsuarioId = 1,
                            Contrasena = "QQBkAG0AaQBuAA==",
                            Email = "ericksvicente@hotmail.com",
                            NombreUsuario = "Admin",
                            Nombres = "Administrador"
                        });
                });

            modelBuilder.Entity("StudioEF.Models.Ventas", b =>
                {
                    b.Property<int>("VentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellidos")
                        .HasColumnType("TEXT");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Total")
                        .HasColumnType("TEXT");

                    b.HasKey("VentaId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("StudioEF.Models.VentasDetalle", b =>
                {
                    b.Property<int>("VentasDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArticuloId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ArticulosId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<int>("EventoId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Monto")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PrecioArticulo")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PrecioEvento")
                        .HasColumnType("TEXT");

                    b.Property<int>("VentaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("VentasDetalleId");

                    b.HasIndex("ArticulosId");

                    b.HasIndex("EventoId");

                    b.HasIndex("VentaId");

                    b.ToTable("VentasDetalle");
                });

            modelBuilder.Entity("StudioEF.Models.ComprasDetalle", b =>
                {
                    b.HasOne("StudioEF.Models.Articulos", null)
                        .WithMany("ComprasDetalle")
                        .HasForeignKey("ArticulosId");

                    b.HasOne("StudioEF.Models.Compras", null)
                        .WithMany("ComprasDetalle")
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudioEF.Models.VentasDetalle", b =>
                {
                    b.HasOne("StudioEF.Models.Articulos", null)
                        .WithMany("VentasDetalle")
                        .HasForeignKey("ArticulosId");

                    b.HasOne("StudioEF.Models.Eventos", null)
                        .WithMany("VentasDetalle")
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudioEF.Models.Ventas", null)
                        .WithMany("VentasDetalle")
                        .HasForeignKey("VentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
