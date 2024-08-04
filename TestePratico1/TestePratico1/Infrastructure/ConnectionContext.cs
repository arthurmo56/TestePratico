using Microsoft.EntityFrameworkCore;
using TestePratico1.Model;

namespace TestePratico1.Infrastructure
{
    public class ConnectionContext : DbContext 
    {
        public DbSet<PessoaFisica> PessoasFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(
            "Server=localhost;" +
            "Port=5432;Database=postgres;" +
            "User Id=postgres;" +
            "Password=ti@cc;");
    }
}
