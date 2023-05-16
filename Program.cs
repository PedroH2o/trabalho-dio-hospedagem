using EntregaProjetoHospedagem.models;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa (nome: "Hóspede 1");
Pessoa p2 = new Pessoa (nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valor:30);

Reserva reserva = new Reserva(diasReservados:10);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor Diária: {reserva.CalcularValorDiaria()}");
