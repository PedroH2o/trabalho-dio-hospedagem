using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntregaProjetoHospedagem.models
{
    public class Suite
    {
        public Suite(string tipoSuite, int capacidade, decimal valor)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valor;

        }
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}