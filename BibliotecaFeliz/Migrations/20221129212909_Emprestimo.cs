using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotecaFeliz.Migrations
{
    public partial class Emprestimo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emprestimo",
                columns: table => new
                {
                    EmprestimoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataEmprestimo = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AlunoId = table.Column<int>(type: "INTEGER", nullable: false),
                    LivroId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprestimo", x => x.EmprestimoId);
                    table.ForeignKey(
                        name: "FK_Emprestimo_Aluno_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Aluno",
                        principalColumn: "AlunoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Emprestimo_Livros_LivroId",
                        column: x => x.LivroId,
                        principalTable: "Livros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimo_AlunoId",
                table: "Emprestimo",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimo_LivroId",
                table: "Emprestimo",
                column: "LivroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emprestimo");
        }
    }
}
