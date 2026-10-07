namespace CutePet.Models { 
 public abstract class Usuario
{
    private string _nome;
    private string _email;

    public string Nome
    {
        get => _nome;
        set => _nome = string.IsNullOrWhiteSpace(value) ? "Usuário" : value;
    }

    public string Email
    {
        get => _email;
        set => _email = value;
    }

    protected Usuario(string nome, string email)
    {
        Nome = nome;
        Email = email;
    }

    public abstract bool Autenticar(string senha); // Polimorfismo / Método abstrato
  }

}
