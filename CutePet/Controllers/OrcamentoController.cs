using Microsoft.AspNetCore.Mvc;
using CutePet.Models;

namespace CutePet.Controllers
{
    public class OrcamentoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(string nomeCliente, string telefone, string nomePet, string raca, string porte, bool incluiBanho, bool incluiTosa, bool incluiHidratacao, string horario)
        {
            Pet pet = new Pet { NomePet = nomePet, Raca = raca, Porte = porte };

            Orcamento orcamento = new Orcamento(pet)
            {
                IncluiBanho = incluiBanho,
                IncluiTosa = incluiTosa,
                IncluiHidratacao = incluiHidratacao
            };

            decimal valorTotal = orcamento.CalcularValor();

            int novoIdCliente = Simulacao.ClientesList.Count + 1;
            Cliente novoCliente = new Cliente(novoIdCliente, nomeCliente, telefone);
            novoCliente.Pets.Add(pet);
            Simulacao.ClientesList.Add(novoCliente);

            string servicoDescricao = (incluiBanho ? "Banho " : "") + (incluiTosa ? "Tosa " : "") + (incluiHidratacao ? "Hidratação" : "").Trim();
            if (string.IsNullOrWhiteSpace(servicoDescricao)) servicoDescricao = "Serviço Geral";

            int novoIdAgenda = Simulacao.AgendaList.Count + 1;
            Agendamento novoAgendamento = new Agendamento(novoIdAgenda, nomeCliente, nomePet, servicoDescricao, string.IsNullOrEmpty(horario) ? "08:00" : horario);
            Simulacao.AgendaList.Add(novoAgendamento);

            ViewBag.NomeCliente = nomeCliente;
            ViewBag.NomePet = pet.NomePet;
            ViewBag.ValorTotal = valorTotal;

            return View("Index");
        }
    }
}
