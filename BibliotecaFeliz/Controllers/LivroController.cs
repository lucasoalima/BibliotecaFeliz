using Microsoft.AspNetCore.Mvc;
using BibliotecaFeliz.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaFeliz.Controllers
{
    
     [ApiController]
     [Route("api/livro")]

   public class LivroController : ControllerBase
    {

      private readonly DataContext _context;

    public LivroController(DataContext context) => _context = context;
   

    private static List<Livro> livros = new List<Livro>();


    [HttpGet]
    [Route("Listar")]
    public IActionResult Listar() => Ok(_context.Livros.Include(Livros => Livros.Categoria).ToList());

    [HttpPost]
    [Route("cadastrar")]
   public IActionResult Cadastrar([FromBody] Livro livro)
   {
     _context.Livros.Add(livro);
     _context.SaveChanges();
     return Created("",livro);

   }

    [HttpGet]
    [Route("buscar/{id}")]
    public IActionResult Buscar([FromRoute] int id)
    {
      
      Livro livro = _context.Livros.Find(id);
      return livro != null ? Ok(livro) : NotFound();
     
    } 

    [HttpDelete]
    [Route("deletar/{id}")]
    public IActionResult deletar([FromRoute] int id)
    {
      
      Livro livro = _context.Livros.Find(id);
      if(livro != null)
      {

        _context.Livros.Remove(livro);
        _context.SaveChanges();
        return Ok(livro);
      }
      return NotFound();
     
    } 

     [HttpPatch]
    [Route("alterar")]
    public IActionResult alterar([FromBody] Livro livro)
    {

      if(livro.Categorias_ID == 0){
        return NotFound();
      }
      
        _context.Livros.Update(livro);
        _context.SaveChanges();
        return Ok(livro);
     
    } 
    }
}