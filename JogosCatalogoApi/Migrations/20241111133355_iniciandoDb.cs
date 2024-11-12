using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JogosCatalogoApi.Migrations
{
    /// <inheritdoc />
    public partial class iniciandoDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catalogos",
                columns: table => new
                {
                    CatalogoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogos", x => x.CatalogoId);
                });

            migrationBuilder.CreateTable(
                name: "Distribuidoras",
                columns: table => new
                {
                    DistribuidoraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagemUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatalogoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribuidoras", x => x.DistribuidoraId);
                    table.ForeignKey(
                        name: "FK_Distribuidoras_Catalogos_CatalogoId",
                        column: x => x.CatalogoId,
                        principalTable: "Catalogos",
                        principalColumn: "CatalogoId");
                });

            migrationBuilder.CreateTable(
                name: "Jogos",
                columns: table => new
                {
                    JogoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagemUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JaAdquirido = table.Column<bool>(type: "bit", nullable: false),
                    DistribuidoraId = table.Column<int>(type: "int", nullable: false),
                    CatalogoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogos", x => x.JogoId);
                    table.ForeignKey(
                        name: "FK_Jogos_Catalogos_CatalogoId",
                        column: x => x.CatalogoId,
                        principalTable: "Catalogos",
                        principalColumn: "CatalogoId");
                    table.ForeignKey(
                        name: "FK_Jogos_Distribuidoras_DistribuidoraId",
                        column: x => x.DistribuidoraId,
                        principalTable: "Distribuidoras",
                        principalColumn: "DistribuidoraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Distribuidoras_CatalogoId",
                table: "Distribuidoras",
                column: "CatalogoId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogos_CatalogoId",
                table: "Jogos",
                column: "CatalogoId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogos_DistribuidoraId",
                table: "Jogos",
                column: "DistribuidoraId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jogos");

            migrationBuilder.DropTable(
                name: "Distribuidoras");

            migrationBuilder.DropTable(
                name: "Catalogos");
        }
    }
}
