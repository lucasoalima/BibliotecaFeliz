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
    [Route("buscar/{cpf}")]
    public IActionResult Buscar([FromRoute] string cpf)
    {
      
      Livro livro = _context.Livros.FirstOrDefault(
      livroCadastrado => livroCadastrado.Cpf.Equals(cpf)
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
    [Route("deletar/{cpf}")]
    public IActionResult deletar([FromRoute] string cpf)
    {
      
      Livro livro = livros.FirstOrDefault(livroCadastrado => livroCadastrado.Cpf.Equals(cpf));
      if(livro != null)
      {
        livros.Remove(livro);
        return Ok(livro);
      }
      return NotFound();
     
    } 

     [HttpPatch]
    [Route("alterar")]
    public IActionResult deletar([FromBody] Livro livro)
    {
      
      Livro livroBuscado = livros.FirstOrDefault(
        livroCadastrado => livroCadastrado.Cpf.Equals(livro.Cpf));
      if(livroBuscado != null)
      {
        livroBuscado.Nome = livro.Nome;
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