namespace Biblioteca.Web.Models
{
    public class LivroModel
    {
        public long Id { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Autor { get; set; }
        public string Descricao { get; set; }
        public string Editora { get; set; }
        public string AnoPublicacao { get; set; }
        public string ImageUrl { get; set; }
        public int Quantidade { get; set; } = 0;
    }
}
