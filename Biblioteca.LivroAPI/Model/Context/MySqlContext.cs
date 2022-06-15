using Microsoft.EntityFrameworkCore;

namespace Biblioteca.LivroAPI.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext() { }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { } //Faz a busca da tabela no BD

        public DbSet<Livro> Livros { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelbuilder)
        //{
        //    {
        //        modelbuilder.Entity<Livro>().HasData(new Livro
        //        {
        //            Id = 1,
        //            Titulo = "1984",
        //            Genero = "ficção - distopia",
        //            Autor = "george orwell",
        //            Editora = "tricaju",
        //            Descricao = string.Empty,
        //            ImageUrl = string.Empty,
        //            AnoPublicacao = "1949",
        //        });
        //    }
        //}
    }
}
