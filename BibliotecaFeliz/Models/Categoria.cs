using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFeliz.Models
{
    public class Categoria
    {
        public int id { get; set; }
        public string nome { get; set; }
        public override string ToString()
        {
            return nome;
        }
    }
}