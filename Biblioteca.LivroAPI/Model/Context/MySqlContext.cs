using Microsoft.EntityFrameworkCore;

namespace Biblioteca.LivroAPI.Model.Context
{
    public class MySqlContext : DbContext
	{
		public MySqlContext() { }

		public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { } //Faz a busca da tabela no BD

		public DbSet<Livro> Livros { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Livro>().HasData(new Livro
        //    {
        //        Id = 1,
        //        Titulo = "1984",
        //        Genero = "Ficção - Distopia",
        //        Autor = "George Orwell",
        //        Editora = "Tricaju",
        //        Descricao = String.Empty,
        //        ImageUrl = String.Empty,
        //        AnoPublicacao = "1949",
        //    });
        //}
    }
}
