namespace CutePet.Models
{
    public class Agendamento
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string NomePet {  get; set; }
        public string Servico { get; set; }
        public string Horario { get; set; }
        public string Status { get; set; }

        public Agendamento(int id, string cliente, string pet, string servico, string horario)
        {
            Id = id;
            NomeCliente = cliente;
            NomePet = pet;
            Servico = servico;
            Horario = horario;
            Status = "Pendente";
        }
    }
}
