using System.ComponentModel.DataAnnotations;
using System.Linq;
using BibliotecaFeliz.Models;

namespace BibliotecaFeliz.Validation
{
    public class CategoriaExistente : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
            string NomeCategoria = (string)value;

            DataContext context = (DataContext) validationContext.GetService(typeof(DataContext));

            Categoria result = context.Categoria.FirstOrDefault(f => f.NomeCategoria.Equals(NomeCategoria));
            return result == null ? ValidationResult.Success : new ValidationResult("Uma categoria com esse nome já existe!");
        }
    }
}