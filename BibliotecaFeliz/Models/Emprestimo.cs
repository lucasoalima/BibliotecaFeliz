using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using BibliotecaFeliz.Validation;

namespace BibliotecaFeliz.Models
{
    public class Emprestimo
    {
        public int EmprestimoId { get; set; }
      
        public DateTime DataEmprestimo { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Aluno Aluno { get; set; }

        public Livro Livro { get; set; }

        public Categoria Categoria {get; set;}

        public Emprestimo(DateTime DataEmprestimo, int EmprestimoId) {
            this.DataEmprestimo = DataEmprestimo;
            this.EmprestimoId = EmprestimoId;
        }
    }
}