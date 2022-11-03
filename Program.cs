using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

Random random = new Random();
int numeroCapacidade = random.Next(1, 5);
int numeroDias = random.Next(1, 15);

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);


Suite suite = new Suite(tipoSuite: "Premium", capacidade: numeroCapacidade, valorDiaria: 30);


Reserva reserva = new Reserva(diasReservados: numeroDias);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor total: {reserva.CalcularValorDiaria():C} para {numeroDias} dia(s).");
