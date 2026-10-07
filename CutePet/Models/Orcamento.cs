namespace CutePet.Models
{
    public class Orcamento
    {
        public Pet PetDoCliente { get; set; }
        public bool IncluiBanho { get; set; }
        public bool IncluiTosa { get; set; }
        public bool IncluiHidratacao { get; set; }

        public Orcamento(Pet pet)
        {
            PetDoCliente = pet;
        }

        public virtual decimal CalcularValor()
        {
            decimal valorTotal = 0;
            if (IncluiBanho) valorTotal += 40.00m;
            if (IncluiTosa) valorTotal += 35.00m;
            if (IncluiHidratacao) valorTotal += 20.00m;

            if (PetDoCliente.Porte == "Grande") valorTotal += 30.00m;
            else if (PetDoCliente.Porte == "Medio") valorTotal += 15.00m;

            return valorTotal;
        }
    }
}
