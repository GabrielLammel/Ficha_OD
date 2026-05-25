using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoRPG.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personagens",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Forca = table.Column<int>(type: "INTEGER", nullable: false),
                    Destreza = table.Column<int>(type: "INTEGER", nullable: false),
                    Constituicao = table.Column<int>(type: "INTEGER", nullable: false),
                    Inteligencia = table.Column<int>(type: "INTEGER", nullable: false),
                    Sabedoria = table.Column<int>(type: "INTEGER", nullable: false),
                    Carisma = table.Column<int>(type: "INTEGER", nullable: false),
                    Classe = table.Column<string>(type: "TEXT", nullable: false),
                    PontosVida = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagens", x => x.PersonagemId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personagens");
        }
    }
}
