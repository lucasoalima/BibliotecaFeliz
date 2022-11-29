using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using BibliotecaFeliz.Models;

namespace BibliotecaFeliz.Controllers
{
    [Route("api/aluno")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly DataContext _context;

        public AlunoController(DataContext context) => _context = context;

        [Route("cadastrar")]
        [HttpPost]
        public IActionResult CadastrarAluno([FromBody] Aluno aluno)
        {
            _context.Aluno.Add(aluno);
            _context.SaveChanges();
            return Created("", aluno); 
        }

        [Route("listar")]
        [HttpGet]
        public IActionResult ListarAlunos() {
            return Ok(_context.Aluno.ToList());
        }


        [Route("deletar/{id}")]
        [HttpDelete]
        public IActionResult DeletarAluno([FromRoute] int id)
        {
            Aluno aluno = _context.Aluno.Find(id);

            if(aluno != null)
            {
                _context.Aluno.Remove(aluno);
                _context.SaveChanges();
                return Ok(aluno);
            }

            return NotFound("Nenhum aluno de " + id + " ID foi encontrado ");
        }


        [Route("alterar")]
        [HttpPatch]
        public IActionResult Alterar([FromBody] Aluno aluno)
        {

        if(aluno.AlunoId == 0){
        return NotFound();
        }
        
            _context.Aluno.Update(aluno);
            _context.SaveChanges();
            return Ok(aluno);
        }
            
    }
}