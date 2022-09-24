using Microsoft.AspNetCore.Mvc;
using BibliotecaFeliz.Models;
using System.Collections.Generic;
using System.Linq;

namespace BibliotecaFeliz.Controllers
{
    class CategoriaController : ControllerBase<Categoria>
    {
        public Categoria getCategoriaByName(string nome)
        {
            try
            {
                return this.ctx.categorias.Where(c => c.nome.Equals(nome)).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public List<Categoria> getAllWithLimit(int limit)
        {
            try
            {
                return this.ctx.categorias.Take(limit).ToList();
            }
            catch
            {
                return null;
            }
        }
        public List<Categoria> getCategoriasByName(string nome)
        {
            try
            {
                return this.ctx.categorias.Where(c => c.nome.Contains(nome)).ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}