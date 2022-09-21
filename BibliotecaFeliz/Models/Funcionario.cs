using System;

namespace BibliotecaFeliz.Models

{
 public class Funcionario
 {
   
     public Funcionario() => CriadoEm = DateTime.Now;

     public int Id {get; set; }
     public string Nome{get;set;}
     public string Cpf{get;set;}
     public string Email{get;set;}
     public DateTime DataNascimento{get;set;}
     public DateTime CriadoEm{get;set;}

 }
}
