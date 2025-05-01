using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CallManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colaboradores",
                columns: table => new
                {
                    Matricula = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Gestor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Setor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Turno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaboradores", x => x.Matricula);
                });

            migrationBuilder.CreateTable(
                name: "Chamados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatriculaColaborador = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Tratativa = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    AbertoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DataAbertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcluidoPor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DataConclusao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chamados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chamados_Colaboradores_MatriculaColaborador",
                        column: x => x.MatriculaColaborador,
                        principalTable: "Colaboradores",
                        principalColumn: "Matricula",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_MatriculaColaborador",
                table: "Chamados",
                column: "MatriculaColaborador");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chamados");

            migrationBuilder.DropTable(
                name: "Colaboradores");
        }
    }
}
