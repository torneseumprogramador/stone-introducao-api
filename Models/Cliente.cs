
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_stone.Models
{
    [Table("clientes")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(name: "nome")]
        [MaxLength(150)]
        public string Nome { get; set; }

        [Required]
        [Column(name: "telefone")]
        [MaxLength(15)]
        public string Telefone { get; set; }
    }
}
