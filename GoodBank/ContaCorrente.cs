using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodBank
{
    public class ContaCorrente
    {
        public static int TotalContasCriadas { get; private set; }

        private int _agencia = 564;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
        }

        private int _numeroConta = 1000 + TotalContasCriadas;
        public int NumeroConta
        {
            get
            {
                return _numeroConta;
            }
        }
        public string nomeCliente { get; set; }
        public string CPF { get; }



        public ContaCorrente(string cpf)
        {
            CPF = cpf;

            TotalContasCriadas++;
        }
    }
}
