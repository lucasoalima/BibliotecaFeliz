using System;
using System.ComponentModel.DataAnnotations;
using BibliotecaFeliz.Validation;

namespace BibliotecaFeliz.Models

{
public class Categoria
    {
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "A categoria é obrigatória")]
        [CategoriaExistente]
        public string NomeCategoria { get; set; }

        [Required(ErrorMessage = "A quantidade em estoque é obrigatória")]
        public int QtdEstoqueCategoria { get; set; }

        public Categoria(string NomeCategoria, int QtdEstoqueCategoria) {
            this.NomeCategoria = NomeCategoria;
            this.QtdEstoqueCategoria = QtdEstoqueCategoria;
        }
    }
}