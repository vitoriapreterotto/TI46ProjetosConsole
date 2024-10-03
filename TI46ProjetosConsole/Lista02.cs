using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI46ProjetosConsole
{
    internal class Lista02
    {
        public void ex01()
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

        public void ex02()
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

        public void ex03()
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

        public void ex04()
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

        public void ex05()
        {
            //**PARA**: Faça um programa que conte de 1 a 10 e imprima cada número na tela.

            double i;

            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        public void ex06()
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

        public void ex07()
        {
            //**IF...ELSE Composto**: Escreva um programa que leia um número
            //e informe se ele é par ou ímpar.

            decimal numero;

            Console.WriteLine("Escolha um número");
            numero = decimal.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par!");
            }
            else
            {
                Console.WriteLine("O número é ímpar!");
            }

            Console.ReadKey();
        }

        public void ex08()
        {
            //IF Simples: Faça um programa que exiba "Bom dia" se a hora atual for menor que 12.

            decimal hora;

            Console.WriteLine("Qual é o horário atual? ");
            hora = decimal.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");

                Console.ReadKey();
            }
        }

        public void ex09()
        {
            //**PARA**: Crie um programa que imprima os números pares de 1 a 20.

            decimal i;

            for (i = 0; i <= 20; i++)
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            Console.ReadKey();
        }

        public void ex10()
        {
            //**IF...ELSE Composto**: Elabore um programa que leia um valor e verifique
            //se ele é positivo, negativo ou zero, exibindo a mensagem correspondente.

            decimal num;

            Console.WriteLine("Digite um valor inteiro: ");
            num = decimal.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("O número é positivo!");
            }
            else
            {
                if (num < 0)
                {
                    Console.WriteLine("O número é negativo!");
                }
                else
                {
                    Console.WriteLine("O número é zero!");
                }
            }

            Console.ReadKey();

        }
    }
}
