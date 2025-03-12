namespace MeritoHealth.Controllers
{
    public class Prontuario
    {
        public int IdProntuario { get; set; }
        public string Medico { get; set; }
        public string Relato { get; set; }
        public string Exames { get; set; }
        public string Diagnostico { get; set; }
        public DateTime DataConsulta { get; set; }
        public string TipoConsulta { get; set; }
        public string Medicamentos { get; set; }
        public string Observacoes { get; set; }
        public int IdPaciente { get; set; }
    }
}
