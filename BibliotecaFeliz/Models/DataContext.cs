using Microsoft.EntityFrameworkCore;

namespace BibliotecaFeliz.Models

{
    public class DataContext : DbContext
    {

   public DataContext(DbContextOptions<DataContext> options) : base(options)
   {

   }
    
    public DbSet<Livro> Livros { get; set; }

    public DbSet<Categoria> Categoria {get; set; }

    public DbSet<Aluno> Aluno { get; set; }
    }
}