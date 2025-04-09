namespace CRMApplicationWeb.ViewModels
{
    public class ClientViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Empresa { get; set; }
        public string Status { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
