using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.UsuarioAPI.Model
{
    public class Usuario
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("nome")]
        [Required]
        [StringLength(100)]
        public string Nome{ get; set; }

        [Column("cpf")]
        [Required]
        [StringLength(15)]
        public string Cpf { get; set; }
        
        [Column("count")]
        [Required]
        [StringLength(10)]
        public int Count { get; set; } = 0;

    }
}
