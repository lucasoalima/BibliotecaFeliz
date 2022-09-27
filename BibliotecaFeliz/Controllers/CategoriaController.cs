using Microsoft.AspNetCore.Mvc;
using BibliotecaFeliz.Models;
using System.Collections.Generic;
using System.Linq;


namespace BibliotecaFeliz.Controllers
{
    
     [ApiController]
     [Route("api/biblioteca")]

   public class CategoriaController : ControllerBase
    {

      private readonly DataContext _context;

   public BibliotecaController(DataContext context) => _context = context;
   

    private static List<Categoria> categorias = new List<Categorias>();


    [HttpGet]
    [Route("Listar")]
    public IActionResult Listar() => Ok(_context.Categorias.ToList());

    [HttpPost]
    [Route("cadastrar")]
   public IActionResult Cadastrar([FromBody] Categoria categoria)
   {
     _context.Categorias.Add(categoria);
     _context.SaveChanges();
     return Created("",categoria);

   }

    [HttpGet]
    [Route("buscar/{CategoriaCodigo}")]
    public IActionResult Buscar([FromRoute] string CategoriaCodigo)
    {
      
      Categoria categoria = _context.Categorias.FirstOrDefault(
      categoriaCadastrado => categoriaCadastrado.CategoriaCodigo.Equals(CategoriaCodigo)
      );
     
     return categoria != null ? Ok(categoria) : NotFound();

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
    [Route("deletar/{CategoriaCodigo}")]
    public IActionResult deletar([FromRoute] string CategoriaCodigo)
    {
      
      Categoria categoria = categorias.FirstOrDefault(categoriaCadastrado => categoriaCadastrado.CategoriaCodigo.Equals(CategoriaCodigo));
      if(categoria != null)
      {
        categorias.Remove(categoria);
        return Ok(categoria);
      }
      return NotFound();
     
    } 

     [HttpPatch]
    [Route("alterar")]
    public IActionResult deletar([FromBody] Categoria categoria)
    {
      
      Categoria categoriaBuscado = categorias.FirstOrDefault(
        categoriaCadastrado => categoriaCadastrado.CategoriaCodigo.Equals(categoria.CategoriaCodigo));
      if(categoriaBuscado != null)
      {
        categoriaBuscado.Nomecategoria = categoria.Nomecategoria;
        return Ok(categoria);
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