using System;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaFeliz.Models

{
public class Categoria
    {
        public int CategoriaId { get; set; }
        // Fazer required
        [Required(ErrorMessage = "A categoria é obrigatória")]
        public string NomeCategoria { get; set; }
        // Fazer required
        [Required(ErrorMessage = "A quantidade em estoque é obrigatória")]
        public int QtdEstoqueCategoria { get; set; }

        public Categoria(string NomeCategoria, int QtdEstoqueCategoria) {
            this.NomeCategoria = NomeCategoria;
            this.QtdEstoqueCategoria = QtdEstoqueCategoria;
        }
    }
}