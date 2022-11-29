using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotecaFeliz.Migrations
{
    public partial class EmprestimoCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Emprestimo",
                table: "Emprestimo");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Emprestimo");

            migrationBuilder.DropColumn(
                name: "NomeLivro",
                table: "Emprestimo");

            migrationBuilder.AlterColumn<int>(
                name: "EmprestimoId",
                table: "Emprestimo",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Emprestimo",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emprestimo",
                table: "Emprestimo",
                column: "EmprestimoId");

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimo_CategoriaId",
                table: "Emprestimo",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emprestimo_Categoria_CategoriaId",
                table: "Emprestimo",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimo_Categoria_CategoriaId",
                table: "Emprestimo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emprestimo",
                table: "Emprestimo");

            migrationBuilder.DropIndex(
                name: "IX_Emprestimo_CategoriaId",
                table: "Emprestimo");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Emprestimo");

            migrationBuilder.AlterColumn<int>(
                name: "EmprestimoId",
                table: "Emprestimo",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Emprestimo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "NomeLivro",
                table: "Emprestimo",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emprestimo",
                table: "Emprestimo",
                column: "Id");
        }
    }
}
