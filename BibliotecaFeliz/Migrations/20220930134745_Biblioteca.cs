using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotecaFeliz.Migrations
{
    public partial class Biblioteca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeCategoria = table.Column<string>(type: "TEXT", nullable: true),
                    QtdEstoqueCategoria = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeLivro = table.Column<string>(type: "TEXT", nullable: true),
                    Codigo = table.Column<string>(type: "TEXT", nullable: true),
                    QuantidadeEstoque = table.Column<int>(type: "INTEGER", nullable: false),
                    Autor = table.Column<string>(type: "TEXT", nullable: true),
                    Categoria = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Livros_Categoria_Categoria",
                        column: x => x.Categoria,
                        principalTable: "Categoria",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livros_Categoria",
                table: "Livros",
                column: "Categoria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livros");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
