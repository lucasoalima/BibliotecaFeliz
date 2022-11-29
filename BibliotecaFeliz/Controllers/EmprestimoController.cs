using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using BibliotecaFeliz.Models;


namespace BibliotecaFeliz.Controllers
{
    [Route("emprestimo")]
    [ApiController]
    public class EmprestimoController : ControllerBase
    {
        private readonly DataContext _context;

        public EmprestimoController(DataContext context) => _context = context;

        [Route("emprestar")]
        [HttpPost]
        public IActionResult Emprestar([FromBody] Emprestimo emprestimo)
        {
            _context.Emprestimo.Add(emprestimo);
            _context.SaveChanges();
            return Created("", emprestimo); 
        }

        [Route("listar")]
        [HttpGet]
        public IActionResult ListarAgendamentos()
        {
            var emprestimos = _context.Emprestimo
                .Include(emprestimo => emprestimo.Aluno)
                .Include(emprestimo => emprestimo.Livro)
                .ToList();
            
            return Ok(emprestimos);
        }

        [Route("devolver/{id}")]
        [HttpDelete]
        public IActionResult DevolverEmprestimo([FromRoute] int id)
        {
            Emprestimo emprestimo = _context.Emprestimo.Find(id);

            if(emprestimo != null)
            {
                _context.Emprestimo.Remove(emprestimo);
                _context.SaveChanges();
                return Ok(emprestimo);
            }

            return NotFound("Nenhum emprestimo foi encontrado");
        }
    }
}