using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeritoHealth.Models
{
    public class Paciente
    {
        [Key]
        [Display(Name = "ID Paciente")]
        public int IdPaciente { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [Column(TypeName = "varchar")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DtNascimento { get; set; }

        [Required(ErrorMessage = "O gênero é obrigatório.")]
        [Column(TypeName = "char")]
        [StringLength(1)]
        public string Genero { get; set; }

        [Required(ErrorMessage = "O endereço é obrigatório.")]
        [StringLength(200, ErrorMessage = "O endereço deve ter no máximo 200 caracteres.")]
        public string Endereco { get; set; }

        // Se o id_contato for uma chave estrangeira para outra tabela, 
        // pode ser interessante definir a propriedade de navegação posteriormente.
        [Display(Name = "ID Contato")]
        public int IdContato { get; set; }

        [Required(ErrorMessage = "O tipo sanguíneo é obrigatório.")]
        [Display(Name = "Tipo Sanguíneo")]
        [Column(TypeName = "char")]
        [StringLength(2)]
        public string TipoSanguineo { get; set; }

        // Caso id_alergia seja uma chave estrangeira para outra tabela (por exemplo, Alergias), ajuste conforme necessário.
        [Display(Name = "ID Alergia")]
        public int IdAlergia { get; set; }

        [Display(Name = "Condições Crônicas")]
        public string CondicoesCronicas { get; set; }

        [Required(ErrorMessage = "O contato de emergência é obrigatório.")]
        [Display(Name = "Contato de Emergência")]
        public string ContatoEmergencia { get; set; }

        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.DateTime)]
        public DateTime DtCadastro { get; set; }
    }
}
