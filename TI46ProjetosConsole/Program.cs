using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI46ProjetosConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercicioMedia();
            //exercicio1();
            //exercicio2();
            //exercicio3();
            //exercicio4();
            //exercicio5();
            exercicio6();
        }

        private static void exercicio6()
        {
            //Ex.6: Construa um algoritmo que converte temperatura de graus
            //Celsius para Fahrenheit usando uma fórmula F = (C×95)+32F = (C×59)+32.

            double celsius, fahrenheit;

            Console.WriteLine("Escreva a temperatura em graus Celsius: ");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = ((celsius * 9 / 5) + 32);

            Console.WriteLine("A temperatura em Fahrenheit é: " + fahrenheit);

            Console.ReadKey();

        }

        private static void exercicio5()
        {
            //Ex.5: Crie uma variável para o preço de um produto e
            //aplique um desconto de 10 %. Mostre o valor final.

            double valor, des;

            Console.WriteLine("Digite um valor para receber 10% de desconto: ");
            valor = double.Parse(Console.ReadLine());

            des = (valor) - (valor * 0.1);

            Console.WriteLine("O valor de " + valor + " com 10% de desconto fica: " + des);

            Console.ReadKey();
        }

        private static void exercicio4()
        {
            // Ex.4, Prioridade dos Operadores: Calcule uma expressão:
            // 2 + 3×42 / (1−5)2 + 3×42 / (1−5)

            decimal e1, e2, e3, res;

            Console.WriteLine("O resultado da expressão 2 + 3×42 / (1−5)2 + 3×42 / (1−5) é: ");

            e1 = (2 + (3 * 42));
            e2 = ((1 - 5) * 2 + (3 * 42));
            e3 = (1 - 5);
            res = (e1 / e2 / e3);

            Console.WriteLine(res);

            Console.ReadKey();
        } 

        private static void exercicio3()
        {
            // Ex.3, Operações Aritméticas: Calcular a média aritmética de três números inteiros

            decimal n1, n2, n3, media;

            Console.WriteLine("Escolha 3 números inteiros para calcular sua média: ");
            n1 = decimal.Parse(Console.ReadLine());
            n2 = decimal.Parse(Console.ReadLine());
            n3 = decimal.Parse(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;

            Console.WriteLine("A média é: " + media);

            Console.ReadKey();
        }

        private static void exercicio2()
        {
            // Ex. 2: Crie uma constante para o valor de Pi(3.14159) e
            // use-a para calcular a área de um círculo com raio.

            double pi = 3.14159, raio, area;
           

            Console.WriteLine("Digite o raio do círculo: "); 
            raio = double.Parse (Console.ReadLine());

            area = (pi * Math.Pow(raio, 2));

            Console.WriteLine("A área do circulo é " + area);

            Console.ReadKey();
        }

        private static void exercicio1()
        {
            // Ex. 1: Declarar três variáveis de tipos diferentes (inteiro, real e caractere) e atributos.

            int numero1;
            double real;
            string caractere;

        }

        private static void exercicioMedia()
        {
            string nome;
            decimal n1, n2, n3, n4, res;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Seja bem vindo, " + nome);

            Console.WriteLine("Digite as notas: ");
            n1 = decimal.Parse(Console.ReadLine());
            n2 = decimal.Parse(Console.ReadLine());
            n3 = decimal.Parse(Console.ReadLine());
            n4 = decimal.Parse(Console.ReadLine());

            res = ((n1 + n2 + n3 + n4) / 4);

            Console.WriteLine("O aluno " + nome + " teve média final de: " + res);


            Console.ReadKey();
        }
    }
}
