using Microsoft.EntityFrameworkCore;
using WebAPIFucionarios.Models;

namespace WebAPIFucionarios.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<FuncionarioModel> Funcionario { get; set; }
    }
}
