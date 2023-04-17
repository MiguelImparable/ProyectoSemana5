using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoSemana5.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    citaId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuarioId = table.Column<long>(type: "bigint", nullable: false),
                    medicoId = table.Column<long>(type: "bigint", nullable: false),
                    fecha = table.Column<DateTime>(type: "DateTime", nullable: false),
                    descripcion = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.citaId);
                });

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    medicoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personaId = table.Column<long>(type: "bigint", nullable: false),
                    tipoMedicoId = table.Column<int>(type: "int", nullable: false),
                    fechaContrato = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.medicoId);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    personaId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreintegrado = table.Column<string>(type: "varchar(100)", nullable: false),
                    cedula = table.Column<long>(type: "bigint", nullable: false),
                    celular = table.Column<string>(type: "varchar(20)", nullable: false),
                    direccion = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.personaId);
                });

            migrationBuilder.CreateTable(
                name: "TipoMedicos",
                columns: table => new
                {
                    tipoMedicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cargo = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMedicos", x => x.tipoMedicoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoServicios",
                columns: table => new
                {
                    TipoServicioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcionPlan = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoServicios", x => x.TipoServicioId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    usuarioId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personaId = table.Column<long>(type: "bigint", nullable: false),
                    TipoServicioId = table.Column<int>(type: "int", nullable: false),
                    fechaIngreso = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.usuarioId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "TipoMedicos");

            migrationBuilder.DropTable(
                name: "TipoServicios");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
