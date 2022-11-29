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

        public int Id {get; set;}

        public string NomeLivro {get; set;}

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Livro Livro { get; set; }

        public Emprestimo(DateTime DataEmprestimo, int EmprestimoId) {
            this.DataEmprestimo = DataEmprestimo;
            this.EmprestimoId = EmprestimoId;
        }
    }
}