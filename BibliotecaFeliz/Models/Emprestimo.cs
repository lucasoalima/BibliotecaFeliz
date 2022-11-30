using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using BibliotecaFeliz.Validation;

namespace BibliotecaFeliz.Models
{
    public class Emprestimo
    {
        public int EmprestimoId { get; set; }
      
        public int CategoriaId {get; set;}
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Categoria Categoria {get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Livro Livro {get; set;}
        public int LivroId { get; set; }

        public int AlunoId {get; set;}
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Aluno Aluno { get; set; }

        public DateTime DataEmprestimo { get; set; }


        public Emprestimo(int EmprestimoId, int AlunoId, int CategoriaId, int LivroId, DateTime DataEmprestimo) {
            this.DataEmprestimo = DataEmprestimo;
            this.EmprestimoId = EmprestimoId;
            this.AlunoId = AlunoId;
            this.CategoriaId = CategoriaId;
            this.LivroId = LivroId;
        }
    }
}