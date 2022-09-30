using System;
using System.ComponentModel.DataAnnotations.Schema;
using BibliotecaFeliz.Validation;


namespace BibliotecaFeliz.Models

{
 public class Livro
 {

     public int Id {get; set; }
     [LivroExistente]
     public string NomeLivro{get;set;}
     public string Codigo{get;set;}
     public int QuantidadeEstoque{get;set;}
     public string Autor{get;set;}

     [ForeignKey("Categoria")]
     [Column("Categoria")]
     public int Categorias_ID{get;set;}
     
     public virtual Categoria Categoria {get; set;}

 }
}
