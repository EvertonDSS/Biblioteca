using Microsoft.EntityFrameworkCore;

namespace Biblioteca.UsuarioAPI.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext() { }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { } //Faz a busca da tabela no BD

        public DbSet<Usuario> Usuario { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelbuilder)
        //{
        //    {
        //        modelbuilder.Entity<Usuario>().HasData(new Usuario
        //        {
        //            Id = 1,
        //            Nome = "Everton David",
        //            Cpf = "11111111111"
        //        });
        //    }
        //}
    }
}
