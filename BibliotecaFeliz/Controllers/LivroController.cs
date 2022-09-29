using Microsoft.AspNetCore.Mvc;
using BibliotecaFeliz.Models;
using System.Collections.Generic;
using System.Linq;



namespace BibliotecaFeliz.Controllers
{
    
     [ApiController]
     [Route("api/biblioteca")]

   public class BibliotecaController : ControllerBase
    {

      private readonly DataContext _context;

   public BibliotecaController(DataContext context) => _context = context;
   

    private static List<Livro> livros = new List<Livro>();


    [HttpGet]
    [Route("Listar")]
    public IActionResult Listar() => Ok(_context.Livros.ToList());

    [HttpPost]
    [Route("cadastrar")]
   public IActionResult Cadastrar([FromBody] Livro livro)
   {
     _context.Livros.Add(livro);
     _context.SaveChanges();
     return Created("",livro);

   }

    [HttpGet]
    [Route("buscar/{codigo}")]
    public IActionResult Buscar([FromRoute] string codigo)
    {
      
      Livro livro = _context.Livros.FirstOrDefault(
      livroCadastrado => livroCadastrado.Codigo.Equals(codigo)
      );
     
     return livro != null ? Ok(livro) : NotFound();

   /*  if(funcionario != null)
     {
      return  Ok(funcionario);
     }

         return NotFound();*/

        /*foreach (Funcionario funcionarioCadastrado in funcionarios)
        {
           if(funcionarioCadastrado.Cpf.Equals(cpf))
            {
                return Ok(funcionarioCadastrado);
            } 
        }*/
     
    } 

    [HttpDelete]
    [Route("deletar/{codigo}")]
    public IActionResult deletar([FromRoute] string codigo)
    {
      
      Livro livro = livros.FirstOrDefault(livroCadastrado => livroCadastrado.Codigo.Equals(codigo));
      if(livro != null)
      {
        livros.Remove(livro);
        return Ok(livro);
      }
      return NotFound();
     
    } 

     [HttpPatch]
    [Route("alterar")]
    public IActionResult alterar([FromBody] Livro livro)
    {
      
      Livro livroBuscado = livros.FirstOrDefault(
        livroCadastrado => livroCadastrado.Codigo.Equals(livro.Codigo));
      if(livroBuscado != null)
      {
        livroBuscado.NomeLivro = livro.NomeLivro;
        return Ok(livro);
      }
      return NotFound();
     
    } 

  /*  [HttpPut]
    [Route("editar/{nome}")]
    public IActionResult Editar([FromRoute] string nome)
   {
   
   using (var funcionario = new Funcionario())
        {

            if (funcionario != null)
            {
                nome = funcionario.nome;

                funcionario.Add();
            }
            else
            {
                return NotFound();
            }
        }
   }  */
    }
}