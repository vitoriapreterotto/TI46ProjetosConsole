using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI46ProjetosConsole
{
    internal class Lista03
    {

        public void questao01()
        {
            // Exibir a tabuada de multiplicação de um número utilizando o comando Para

            decimal i, num;

            Console.WriteLine("Escolha um número para ver sua taburada: ");
            num = decimal.Parse(Console.ReadLine());

            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine(num + " * " + i + " = " + num * i);
            }

            Console.ReadKey();
        }

        public void questao02()
        {
            // Somar números até a soma ser maior ou igual a 100 utilizando o comando Enquanto

            decimal i, soma;

            soma = 0;
            while (soma < 100)
            {
                Console.WriteLine("Digite um número: ");
                i = decimal.Parse(Console.ReadLine());
                soma = soma + i;
            }

            Console.WriteLine("A soma total é: " + soma);
            Console.WriteLine("A soma atingiu ou ultrapassou 100.");

            Console.ReadKey();


        }

        public void questao03()
        {
            // número positivo até que seja digitado um número negativo utilizando Faça Enquanto

            double num;

            do
            {
                Console.WriteLine("Escolha um número, seja ele positivo ou negativo: ");
                num = double.Parse(Console.ReadLine());
            }
            while (num >= 0);
            Console.WriteLine("Você digitou um número negativo!");

            Console.ReadKey();
        }

        public void questao04()
        {
            // Calcular a soma dos 10 primeiros números inteiros utilizando o comando Para

            decimal i, soma = 0;

            for (i = 1; i <= 10; i++)
            {
                soma = soma + i;
            }

            Console.WriteLine("A soma dos 10 primeiros números é: " + soma);

            Console.ReadKey();
        }

        public void questao05()
        {
            // Fazer uma contagem regressiva de 10 até 0 utilizando o comando Enquanto

            decimal num;

            num = 0;

            while (num <= 10)
            {
                Console.WriteLine(num);
                num = num + 1;
            }

            Console.WriteLine("Fim da contagem regressiva!");

            Console.ReadKey();
        }

        public void questao06()
        {
            // Calcular o fatorial de um número informado pelo usuário utilizando o comando Para

            double num, fatorial = 1, i;

            Console.WriteLine("Digite um número: ");
            num = double.Parse(Console.ReadLine());

            for (i = 1; i <= num; i++)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine("O fatorial de " + num + " é " + fatorial);

            Console.ReadKey();
        }

        public void questao07()
        {
            // Pedir uma senha e continuar solicitando até que seja digitada
            // a senha correta utilizando Faça Enquanto

            decimal senha;

            do
            {
                Console.WriteLine("Digite a senha");
                senha = decimal.Parse(Console.ReadLine());
            }
            while (senha != 1234);
            {
                Console.WriteLine("Senha correta!");
            }

            Console.ReadKey();
        }
    }
}
