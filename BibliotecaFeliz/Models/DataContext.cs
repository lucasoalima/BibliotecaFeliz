using Microsoft.EntityFrameworkCore;

namespace BibliotecaFeliz.Models

{
    public class DataContext : DbContext
    {

   public DataContext(DbContextOptions<DataContext> options) : base(options)
   {

   }
    
    public DbSet<Funcionario> Funcionarios { get; set; }

    public DbSet<FolhaPagamento> Folhas {get; set; }
    }
}