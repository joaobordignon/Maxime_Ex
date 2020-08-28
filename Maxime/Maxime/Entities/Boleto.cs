using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Maxime.Entities
{
    
    public class Boleto
    {
        private string comprador;
        private double valor;
        private DateTime vencimento;
        private const double TAXA = 2;
        private const int PRAZO = 5;

        public string Comprador { get => comprador; set => comprador = value; }
        public double Valor { get => valor; set => valor = value; }
        public DateTime Vencimento { get => vencimento; set => vencimento = value; }
    }
}
