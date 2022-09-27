using System;

namespace BibliotecaFeliz.Models

{
public class Categoria
    {
        public int CategoriaId { get; set; }
        // Fazer required
        public string NomeCategoria { get; set; }
        // Fazer required
        public int QtdEstoqueCategoria { get; set; }

        public Categoria(string NomeCategoria, int QtdEstoqueCategoria) {
            this.NomeCategoria = NomeCategoria;
            this.QtdEstoqueCategoria = QtdEstoqueCategoria;
        }
    }
}