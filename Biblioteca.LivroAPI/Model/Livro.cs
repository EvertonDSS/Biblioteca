using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.LivroAPI.Model
{
    public class Livro
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("titulo")]
        [Required]
        [StringLength(100)]
        public string Titulo { get; set; }

        [Column("autor")]
        [Required]
        [StringLength(50)]
        public string Autor { get; set; }
        
        [Column("genero")]
        [Required]
        [StringLength(100)]
        public string Genero { get; set; }

        [Column("editora")]
        [Required]
        [StringLength(100)]
        public string Editora { get; set; }

        [Column("ano_publicacao")]
        [Required]
        [StringLength(4)]
        public string AnoPublicacao { get; set; } 

        [Column("image_url")]
        [StringLength(300)]
        public string ImageUrl { get; set; }

        [Column("descricao")]
        [StringLength(100)]
        public string Descricao { get; set; }

        [Column("quantidade")]
        public int Quantidade { get; set; } = 0;

    }
}
