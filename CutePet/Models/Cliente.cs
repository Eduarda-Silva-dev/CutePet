namespace CutePet.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string Telefone { get; set; }
        public List<Pet> Pets { get; set; } = new List<Pet>();

        public Cliente(int id, string nomeCliente, string telefone)
        {
            Id = id;
            NomeCliente = nomeCliente;
            Telefone = telefone;
        }
    }
}
