namespace MeritoHealth.Controllers
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Funcao { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Status { get; set; }
    }
}
