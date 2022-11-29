using System.ComponentModel.DataAnnotations;
using System.Linq;
using BibliotecaFeliz.Models;

namespace BibliotecaFeliz.Validation
{
    public class RGMExistente : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
            string RGM = (string)value;

            DataContext context = (DataContext) validationContext.GetService(typeof(DataContext));

            Aluno result = context.Aluno.FirstOrDefault(f => f.RGM.Equals(RGM));
            return result == null ? ValidationResult.Success : new ValidationResult("Um aluno com esse RGM já existe!");
        }
    }
}