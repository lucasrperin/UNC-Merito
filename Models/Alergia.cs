using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MeritoHealth.Models
{
    public class Alergia
    {
        [Key]
        [Display(Name = "ID Alergia")]
        public int IdAlergia { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [Column(TypeName = "varchar")]
        [StringLength(50, ErrorMessage = "O nome deve ter no máximo 50 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Column(TypeName = "varchar")]
        [StringLength(255, ErrorMessage = "A descrição deve ter no máximo 255 caracteres.")]
        public string Descricao { get; set; }
    }
}
