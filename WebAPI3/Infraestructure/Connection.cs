using Microsoft.EntityFrameworkCore;
using WebAPI3.Domain.Model.CompaniaAggregate;
using WebAPI3.Domain.Model.FuncionarioAggregate;

namespace WebAPI3.Infraestructure;
public class Connection : DbContext
{
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Companhia> Companhias { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        => optionsBuilder.UseNpgsql(
            "Server=localhost;" +
            "Port=5432;" +
            "Database=WebAPI;" +
            "User Id=postgres;" +
            "Password=Senai115@"
        );
}
