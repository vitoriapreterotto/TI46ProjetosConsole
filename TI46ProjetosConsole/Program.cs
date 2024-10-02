using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TI46ProjetosConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando um manu com switch case

            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1 - Programa média");
            Console.WriteLine("2 - Exercício 1");
            Console.WriteLine("3 - Exercício 2");
            Console.WriteLine("4 - Exercício 3");
            Console.WriteLine("5 - Exercício 4");
            Console.WriteLine("6 - Exercício 5");
            Console.WriteLine("7 - Exercício 6");
            Console.WriteLine("8 - Exercício 1 da lista do dia 19");
            Console.WriteLine("9 - Exercício 2 da lista do dia 19");
            Console.WriteLine("10 - Exercício 3 da lista do dia 19");
            Console.WriteLine("11 - Exercício 4 da lista do dia 19");
            Console.WriteLine("12 - Exercício 5 da lista do dia 19");
            Console.WriteLine("13 - Exercício 6 da lista do dia 19");
            Console.WriteLine("14 - Exercício 7 da lista do dia 19");


            int escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    exercicioMedia();
                    break;

                case 2:
                    exercicio1();
                    break;

                case 3:
                    exercicio2();
                    break;

                case 4:
                    exercicio3();
                    break;

                case 5:
                    exercicio4();
                    break;

                case 6:
                    exercicio5();
                    break;

                case 7:
                    exercicio6();
                    break;

                case 8:
                    ex01();
                    break;

                case 9:
                    ex02();
                    break;

                case 10:
                    ex03();
                    break;

                case 11:
                    ex04();
                    break;

                case 12:
                    ex05();
                    break;

                case 13:
                    ex06();
                    break;

                case 14:
                    ex07();
                    break;

                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }

        }

        private static void ex07()
        {
            //**IF...ELSE Composto**: Escreva um programa que leia um número
            //e informe se ele é par ou ímpar.

            decimal numero;

            Console.WriteLine("Escolha um número");
            numero = decimal.Parse(Console.ReadLine());

            if (numero %2 == 0)
            {
                Console.WriteLine("O número é par!");
            }
            else
            {
                Console.WriteLine("O número é ímpar!");
            }

            Console.ReadKey();
        }

        private static void ex06()
        {
            //**PARA**: Crie um programa que some os números de 1 a 100 e exiba o resultado.

            double i, soma;

            soma = 0;
            for (i = 0; i <= 100; i++)
            {
                soma = soma + i;
            }

            Console.WriteLine(soma);
            Console.ReadKey();

        }

        private static void ex05()
        {
            //**PARA**: Faça um programa que conte de 1 a 10 e imprima cada número na tela.

            double i;

            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        private static void ex04()
        {
            // **IF...ELSE Composto**: Crie um programa que leia a temperatura e exiba "Frio"
            // se estiver abaixo de 15 graus, "Agradável" se estiver entre 15 e 25 graus,
            // e "Quente" se estiver acima de 25 graus.

            decimal temp;

            Console.WriteLine("Digite a temperatura atual: ");
            temp = decimal.Parse(Console.ReadLine());

            if (temp < 15)
            {
                Console.WriteLine("Está frio!");
            }
            else
            {
                if (temp >= 15 || temp <= 25)
                {
                    Console.WriteLine("O clima está agradável!");
                }
                else 
                {
                    Console.WriteLine("Está quente!");
                }
                    
            }
            
            Console.ReadKey();

        }

        private static void ex03()
        {
            //**IF...ELSE Composto**: Elabore um programa que receba a idade de
            //uma pessoa e informe se ela é maior de idade (18 anos ou mais) ou menor de idade.

            decimal idade;

            Console.WriteLine("Qual sua idade? ");
            idade = decimal.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade!");
            }
            else
            {
                Console.WriteLine("Você é menor de idade.");
            }

            Console.ReadKey();

        }

        private static void ex02()
        {
            //**IF Simples**: Faça um programa que verifique se um aluno passou em um teste.
            //Se a nota for maior ou igual a 7, exiba "Aprovado".

            decimal questoes;

            Console.WriteLine("Escreva quantas questões o aluno acertou no teste de 10 perguntas: ");
            questoes = decimal.Parse(Console.ReadLine());

            if (questoes >= 7) 
            { 
                Console.WriteLine("Aprovado!");
            }

            Console.ReadLine();
        }

        private static void ex01()
        {
            //**IF Simples**: Crie um programa que verifique se
            //um número é positivo. Se for, exiba "Número positivo".

            double numero;

            Console.WriteLine("Escolha um número: ");
            numero = double.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("Número positivo!");
            }

            Console.ReadKey();
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
