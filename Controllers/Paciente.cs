namespace MeritoHealth.Controllers
{
    public class Paciente
    {
        public int IdPaciente { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Genero { get; set; }
        public string Endereco { get; set; }
        public int IdContato { get; set; }
        public string TipoSanguineo { get; set; }
        public int IdAlergia { get; set; }
        public string CondicoesCronicas { get; set; }
        public string ContatoEmergencia { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
