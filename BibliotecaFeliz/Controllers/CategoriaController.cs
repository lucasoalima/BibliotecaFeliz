using Microsoft.AspNetCore.Mvc;
using BibliotecaFeliz.Models;
using System.Collections.Generic;
using System.Linq;


namespace BibliotecaFeliz.Controllers
{
    [Route("api/categoria")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly DataContext _context;

        public CategoriaController(DataContext context) => _context = context;


        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() => Ok(_context.Categoria.ToList());

        [Route("cadastrar")]
        [HttpPost]
        public IActionResult CriarNovaCategoria([FromBody] Categoria categoria)
        {
            _context.Categoria.Add(categoria);
            _context.SaveChanges();
            return Created("", categoria);
        }

        [HttpDelete]
        [Route("deletar/{CategoriaId}")]
        public IActionResult deletar([FromRoute] int CategoriaId)
        {
      
        Categoria categoria = _context.Categoria.Find(CategoriaId);
        if(categoria != null)
        {

        _context.Categoria.Remove(categoria);
        _context.SaveChanges();
        return Ok(categoria);
        }
        return NotFound();
     
        }

        [HttpPatch]
        [Route("alterar")]
        public IActionResult alterar([FromBody] Categoria categoria){
                {   
            
            _context.Categoria.Update(categoria);
            _context.SaveChanges();
            return Ok(categoria);
            }
        }  
    }
}
  