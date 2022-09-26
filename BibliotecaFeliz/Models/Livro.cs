using System;

namespace BibliotecaFeliz.Models

{
 public class Livro
 {

     public int Id {get; set; }
     public string NomeLivro{get;set;}
     public string Codigo{get;set;}
     public int QuantidadeEstoque{get;set;}
     public string Autor{get;set;}
     public Categoria Categorias{get;set;}

 }
}
