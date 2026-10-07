namespace CutePet.Models
{
    public class Funcionario : Usuario
    {
        public string Cargo { get; private set; }

        public Funcionario(string nome, string email, string cargo) : base(nome, email)
        {
            Cargo = cargo;
        }

        public override bool Autenticar(string senha)
        {
            return !string.IsNullOrEmpty(senha);
        }
    }
}
