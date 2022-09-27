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

    }
}
    // Erro Identificador Esperado 
//     [HttpPatch]
//     [Route("alterarCategoria")]
//     public IActionResult AtualizarCategoria([FromBody] Categoria categoria)
//     {
      
//       Categoria categoriaBuscada = categoria.FirstOrDefault(
//         categoriaCadastrada => categoriaCadastrada.CategoriaId.Equals(categoria.CategoriaId));
//       if(categoriaBuscada != null)
//       {
//         categoriaBuscada. = categoria.NomeCategoria;
//         return Ok(categoria);
//       }
//       return NotFound();
     
//     }
//     }
// }

    // // ERRO NO DELETAR Trabalho\BibliotecaFeliz\BibliotecaFeliz\Controllers\CategoriaController.cs(35,30): error CS0116: Um namespace não pode conter diretamente membros, como campos ou métodos 
    // [C:\Users\lucas\OneDrive\Área de Trabalho\BibliotecaFeliz\BibliotecaFeliz\BibliotecaFeliz.csproj]
    //     [Route("deletar/{CategoriaId}")]
    //     [HttpDelete]
    //     public IActionResult DeletarCategoria([FromRoute] int CategoriaId)
    //     {
    //         Categoria categoria = _context.Categoria.Find(CategoriaId);

    //         if(categoria != null)
    //         {
    //             _context.categoria.Remove(categoria);
    //             _context.SaveChanges();
    //             return Ok(categoria);
    //         }

    //         return NotFound("Nenhuma categoria foi encontrada");
    //     }
    // }

     
