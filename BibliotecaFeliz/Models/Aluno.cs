using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using BibliotecaFeliz.Validation;

namespace BibliotecaFeliz.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório!")]
        public string NomeAluno { get; set; }

        [Required(ErrorMessage = "O campo email é obrigatório!")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "O número de telefone é obrigatório!")]
        [StringLength(11, MinimumLength = 11,ErrorMessage = "Digite um número válido!")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Informe um RGM válido!")]
        [RGMExistente]
        public string RGM { get; set; }

        public DateTime CriadoEm { get; set; }

        public Aluno(string NomeAluno, string Email, string Telefone, string RGM) {
            this.NomeAluno = NomeAluno;
            this.Email = Email;
            this.Telefone = Telefone;
            this.RGM = RGM;
            this.CriadoEm = DateTime.Now;
        }

    }
}