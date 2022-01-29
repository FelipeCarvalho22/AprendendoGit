using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo ao GoodBank - O seu banco online");
            Console.WriteLine("Esta é ainda uma versão piloto, por isso podemos criar apenas 05 contas");
            Console.WriteLine();

            Inicio:

            if (ContaCorrente.TotalContasCriadas > 0)
            {
                Console.WriteLine("O que o senhor(a) deseja fazer: 1-Criar uma nova conta corrente, 2-Acessar sua conta ou qualquer outro numero para encerrar");
                Console.WriteLine();

                try
                {
                    int a = Convert.ToInt32(Console.ReadLine());

                    switch (a)
                    {
                        case 1:
                            Console.WriteLine();
                            CriarContaCorrente();
                            goto Inicio;

                        case 2:
                            Console.WriteLine("Digite o numero da sua conta");
                            goto Inicio;

                        case 3:
                            goto Fim;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ops.. Você não digitou um numero, por favor tente novamente.");
                    goto Inicio;
                }
            }
            else
            {
                Console.WriteLine("Não há nenhuma conta corrente, escolha uma das opções:");
                Console.WriteLine();
                Console.WriteLine("Digite: 1-Criar Conta Corrente ou qualquer numero para fechar a aplicação");

                try
                {
                    int a = Convert.ToInt32(Console.ReadLine());

                    switch (a)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.WriteLine("Ok, vamos criar sua conta:");
                            Console.WriteLine();

                            CriarContaCorrente();

                            goto Inicio;

                        case 2:
                            goto Fim;
                    }
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ops.. Você não digitou um numero, por favor tente novamente.");
                    goto Inicio;
                }
            }

            Fim:
            Console.WriteLine("Obrigado pela visita, aperte Enter para encerrar!");
            Console.ReadLine();
        }
        public static void CriarContaCorrente()
        {
            if (ContaCorrente.TotalContasCriadas <= 4)
            {
                Console.Write("Por favor, digite seu CPF:");
                string cpf = Convert.ToString(Console.ReadLine());
                CriandoContaCorrente(cpf);
            }
            else
            {
                Console.WriteLine("Ops... Excedido o numero de contas correntes possiveis de criar");
            }
        }
        public static void CriandoContaCorrente(string cpf)
        {
            switch (ContaCorrente.TotalContasCriadas)
            {
                case 0:
                    ContaCorrente contaCorrente = new ContaCorrente(cpf);

                    Console.Write("Por favor, digite seu primeiro nome:");
                    string nome = Convert.ToString(Console.ReadLine());
                    contaCorrente.nomeCliente = nome;

                    Console.WriteLine("Parabens " + contaCorrente.nomeCliente + " ,você acaba de criar uma conta corrente no GoodBank");
                    Console.WriteLine("O numero da sua agencia é: " + contaCorrente.Agencia);
                    Console.WriteLine("O numero da sua conta é: " + contaCorrente.NumeroConta);
                    Console.WriteLine();
                    break;
                case 1:
                    ContaCorrente contaCorrente1 = new ContaCorrente(cpf);

                    Console.Write("Por favor, digite seu primeiro nome:");
                    string nome1 = Convert.ToString(Console.ReadLine());
                    contaCorrente1.nomeCliente = nome1;

                    Console.WriteLine("Parabens " + contaCorrente1.nomeCliente + " ,você acaba de criar uma conta corrente no GoodBank");
                    Console.WriteLine("O numero da sua agencia é: " + contaCorrente1.Agencia);
                    Console.WriteLine("O numero da sua conta é: " + contaCorrente1.NumeroConta);

                    break;
                case 2:
                    ContaCorrente contaCorrente2 = new ContaCorrente(cpf);

                    Console.Write("Por favor, digite seu primeiro nome:");
                    string nome2 = Convert.ToString(Console.ReadLine());
                    contaCorrente2.nomeCliente = nome2;

                    Console.WriteLine("Parabens " + contaCorrente2.nomeCliente + " ,você acaba de criar uma conta corrente no GoodBank");
                    Console.WriteLine("O numero da sua agencia é: " + contaCorrente2.Agencia);
                    Console.WriteLine("O numero da sua conta é: " + contaCorrente2.NumeroConta);
                    break;
                case 3:
                    ContaCorrente contaCorrente3 = new ContaCorrente(cpf);

                    Console.Write("Por favor, digite seu primeiro nome:");
                    string nome3 = Convert.ToString(Console.ReadLine());
                    contaCorrente3.nomeCliente = nome3;

                    Console.WriteLine("Parabens " + contaCorrente3.nomeCliente + " ,você acaba de criar uma conta corrente no GoodBank");
                    Console.WriteLine("O numero da sua agencia é: " + contaCorrente3.Agencia);
                    Console.WriteLine("O numero da sua conta é: " + contaCorrente3.NumeroConta);
                    break;
                case 4:
                    ContaCorrente contaCorrente4 = new ContaCorrente(cpf);

                    Console.Write("Por favor, digite seu primeiro nome:");
                    string nome4 = Convert.ToString(Console.ReadLine());
                    contaCorrente4.nomeCliente = nome4;

                    Console.WriteLine("Parabens " + contaCorrente4.nomeCliente + " ,você acaba de criar uma conta corrente no GoodBank");
                    Console.WriteLine("O numero da sua agencia é: " + contaCorrente4.Agencia);
                    Console.WriteLine("O numero da sua conta é: " + contaCorrente4.NumeroConta);
                    break;
            }
        }
    }
}
