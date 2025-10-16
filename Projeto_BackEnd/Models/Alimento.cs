using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_BackEnd.Models
{
    [Table("Alimentos")]
    public class Alimento
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatorio informar o Alimento!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatorio informar o Tipo do Alimento!")]
        public string Tipo { get; set; }
    }
}
