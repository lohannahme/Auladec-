using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeaula
{
    class Conta
    {
        public int Nconta { get; private set; }
        public string Nome { get; private set; }
        public double Vinicial { get; private set; }

        public Conta(int nconta, string nome)
        {
            Nconta = nconta;
            Nome = nome;
            Vinicial = 0;
        }

        public Conta(int nconta, string nome, double vinicial) : this(nconta, nome)
        {
            Vinicial = vinicial;
        }

        public void Deposito(double dep)
        {
            Vinicial += dep;
        }

        public void Saque(double saq)
        {
            Vinicial -= saq+5;
        }

        public override string ToString()
        {
            return $"Conta {Nconta}, Titular: {Nome}, Saldo: $ {Vinicial.ToString("F2")}. ";
        }
    }
}
