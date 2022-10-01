using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BibliotecaFeliz.Validation;


namespace BibliotecaFeliz.Models

{
 public class Livro
 {

     public int Id {get; set; }

     [Required(ErrorMessage = "O nome do livro é obrigatório")]
     [LivroExistente]
     public string NomeLivro{get;set;}

     [Required(ErrorMessage = "A quantidade em estoque é obrigatória")]
     public int QuantidadeEstoque{get;set;}
     
     [Required(ErrorMessage = "Autor é obrigatório")]
     public string Autor{get;set;}

     [Required(ErrorMessage = "A categoria do livro é obrigatório")]
     [ForeignKey("Categoria")]
     [Column("Categoria")]
     public int Categorias_ID{get;set;}
     
     public virtual Categoria Categoria {get; set;}

 }
}
