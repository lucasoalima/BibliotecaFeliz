using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotecaFeliz.Migrations
{
    public partial class EmprestimoColuna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimo_Aluno_AlunoId",
                table: "Emprestimo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emprestimo",
                table: "Emprestimo");

            migrationBuilder.AlterColumn<int>(
                name: "AlunoId",
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
                name: "FK_Emprestimo_Aluno_AlunoId",
                table: "Emprestimo",
                column: "AlunoId",
                principalTable: "Aluno",
                principalColumn: "AlunoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimo_Aluno_AlunoId",
                table: "Emprestimo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emprestimo",
                table: "Emprestimo");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Emprestimo");

            migrationBuilder.AlterColumn<int>(
                name: "EmprestimoId",
                table: "Emprestimo",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "AlunoId",
                table: "Emprestimo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emprestimo",
                table: "Emprestimo",
                column: "EmprestimoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emprestimo_Aluno_AlunoId",
                table: "Emprestimo",
                column: "AlunoId",
                principalTable: "Aluno",
                principalColumn: "AlunoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
