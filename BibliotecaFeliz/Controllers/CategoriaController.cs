using Microsoft.AspNetCore.Mvc;
using BibliotecaFeliz.Models;
using System.Collections.Generic;
using System.Linq;


namespace BibliotecaFeliz.Controllers
{
    [Route("livro/categoria")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly DataContext _context;

        public CategoriaController(DataContext context) => _context = context;

        [Route("criar")]
        [HttpPost]
        public IActionResult CriarNovaCategoria([FromBody] Categoria categoria)
        {
            _context.Categoria.Add(categoria);
            _context.SaveChanges();
            return Created("", categoria);
        }
    }
}