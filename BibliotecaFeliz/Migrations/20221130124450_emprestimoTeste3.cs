using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotecaFeliz.Migrations
{
    public partial class emprestimoTeste3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimo_Livros_LivroId",
                table: "Emprestimo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emprestimo",
                table: "Emprestimo");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Emprestimo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Livros",
                newName: "LivroId");

            migrationBuilder.AlterColumn<int>(
                name: "LivroId",
                table: "Emprestimo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmprestimoId",
                table: "Emprestimo",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emprestimo",
                table: "Emprestimo",
                column: "EmprestimoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emprestimo_Livros_LivroId",
                table: "Emprestimo",
                column: "LivroId",
                principalTable: "Livros",
                principalColumn: "LivroId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimo_Livros_LivroId",
                table: "Emprestimo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emprestimo",
                table: "Emprestimo");

            migrationBuilder.RenameColumn(
                name: "LivroId",
                table: "Livros",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "LivroId",
                table: "Emprestimo",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emprestimo",
                table: "Emprestimo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Emprestimo_Livros_LivroId",
                table: "Emprestimo",
                column: "LivroId",
                principalTable: "Livros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
