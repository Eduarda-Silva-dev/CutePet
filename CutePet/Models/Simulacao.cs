namespace CutePet.Models
{
    public class Simulacao
    {
        public static List<Cliente> ClientesList = new List<Cliente>
        {
            new Cliente(1, "Huguinho Silva", "(11) 98888-1111") { Pets = { new Pet { NomePet = "Mel", Raca = "Poodle", Porte = "Pequeno" } } },
            new Cliente(2, "Zezinho Silva", "(11) 97777-2222") { Pets = { new Pet { NomePet = "Thor", Raca = "Golden Retriever", Porte = "Grande" } } }
        };

        public static List<Agendamento> AgendaList = new List<Agendamento>
        {
            new Agendamento(1, "Luizinho", "Mel", "Banho e Tosa", "09:00"),
            new Agendamento(2, "Donalds Silva", "Thor", "Banho", "11:30")
        };
    }
}
