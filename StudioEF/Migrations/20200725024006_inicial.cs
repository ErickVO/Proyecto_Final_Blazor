using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudioEF.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articulos",
                columns: table => new
                {
                    ArticuloId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsuarioId = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(maxLength: 40, nullable: false),
                    CategoriaId = table.Column<int>(nullable: false),
                    Stock = table.Column<decimal>(nullable: false),
                    Precio = table.Column<decimal>(nullable: false),
                    Costo = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulos", x => x.ArticuloId);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsuarioId = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsuarioId = table.Column<int>(nullable: false),
                    Nombres = table.Column<string>(maxLength: 30, nullable: false),
                    Apellidos = table.Column<string>(maxLength: 30, nullable: false),
                    Cedula = table.Column<string>(maxLength: 11, nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(maxLength: 10, nullable: false),
                    Celular = table.Column<string>(nullable: false),
                    Sexo = table.Column<string>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    CompraId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsuarioId = table.Column<int>(nullable: false),
                    Monto = table.Column<decimal>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.CompraId);
                });

            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    EventoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsuarioId = table.Column<int>(nullable: false),
                    FotografoId = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(maxLength: 30, nullable: false),
                    Lugar = table.Column<string>(nullable: false),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false),
                    Precio = table.Column<decimal>(nullable: false),
                    Disponible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.EventoId);
                });

            migrationBuilder.CreateTable(
                name: "Fotografos",
                columns: table => new
                {
                    FotografoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsuarioId = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 30, nullable: false),
                    Cedula = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(maxLength: 11, nullable: false),
                    Celular = table.Column<string>(maxLength: 11, nullable: false),
                    Sexo = table.Column<string>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Sueldo = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotografos", x => x.FotografoId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombres = table.Column<string>(maxLength: 30, nullable: false),
                    NombreUsuario = table.Column<string>(maxLength: 30, nullable: false),
                    Contrasena = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    VentaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClienteId = table.Column<int>(nullable: false),
                    Nombres = table.Column<string>(maxLength: 30, nullable: false),
                    Apellidos = table.Column<string>(maxLength: 30, nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Total = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.VentaId);
                    table.ForeignKey(
                        name: "FK_Ventas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComprasDetalle",
                columns: table => new
                {
                    ComprasDetalleId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompraId = table.Column<int>(nullable: false),
                    ArticuloId = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(maxLength: 40, nullable: false),
                    CantidadArticulos = table.Column<int>(nullable: false),
                    Costo = table.Column<decimal>(nullable: false),
                    Importe = table.Column<decimal>(nullable: false),
                    ArticulosId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComprasDetalle", x => x.ComprasDetalleId);
                    table.ForeignKey(
                        name: "FK_ComprasDetalle_Articulos_ArticulosId",
                        column: x => x.ArticulosId,
                        principalTable: "Articulos",
                        principalColumn: "ArticuloId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComprasDetalle_Compras_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compras",
                        principalColumn: "CompraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VentasDetalle",
                columns: table => new
                {
                    VentasDetalleId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VentaId = table.Column<int>(nullable: false),
                    ArticuloId = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(maxLength: 30, nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    PrecioArticulo = table.Column<decimal>(nullable: false),
                    EventoId = table.Column<int>(nullable: false),
                    PrecioEvento = table.Column<decimal>(nullable: false),
                    Monto = table.Column<decimal>(nullable: false),
                    ArticulosId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentasDetalle", x => x.VentasDetalleId);
                    table.ForeignKey(
                        name: "FK_VentasDetalle_Articulos_ArticulosId",
                        column: x => x.ArticulosId,
                        principalTable: "Articulos",
                        principalColumn: "ArticuloId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VentasDetalle_Eventos_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Eventos",
                        principalColumn: "EventoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VentasDetalle_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "VentaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Contrasena", "Email", "NombreUsuario", "Nombres" },
                values: new object[] { 1, "QQBkAG0AaQBuAA==", "ericksvicente@hotmail.com", "Admin", "Administrador" });

            migrationBuilder.CreateIndex(
                name: "IX_ComprasDetalle_ArticulosId",
                table: "ComprasDetalle",
                column: "ArticulosId");

            migrationBuilder.CreateIndex(
                name: "IX_ComprasDetalle_CompraId",
                table: "ComprasDetalle",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ClienteId",
                table: "Ventas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_VentasDetalle_ArticulosId",
                table: "VentasDetalle",
                column: "ArticulosId");

            migrationBuilder.CreateIndex(
                name: "IX_VentasDetalle_EventoId",
                table: "VentasDetalle",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_VentasDetalle_VentaId",
                table: "VentasDetalle",
                column: "VentaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "ComprasDetalle");

            migrationBuilder.DropTable(
                name: "Fotografos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "VentasDetalle");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Articulos");

            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
