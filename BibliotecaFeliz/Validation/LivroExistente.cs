using System.ComponentModel.DataAnnotations;
using System.Linq;
using BibliotecaFeliz.Models;

namespace BibliotecaFeliz.Validation
{
    public class LivroExistente : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
            string NomeLivro = (string)value;

            DataContext context = (DataContext) validationContext.GetService(typeof(DataContext));

            Livro result = context.Livros.FirstOrDefault(f => f.NomeLivro.Equals(NomeLivro));
            return result == null ? ValidationResult.Success : new ValidationResult("Um livro com esse nome já existe!");
        }
    }
}