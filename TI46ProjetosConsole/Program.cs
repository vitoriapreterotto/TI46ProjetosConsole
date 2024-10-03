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
            string opcao;

            Lista01 lista01 = new Lista01();
            Lista02 lista02 = new Lista02();
            Lista03 lista03 = new Lista03();

            do
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
                Console.WriteLine("15 - Exercício 8 da lista do dia 19");
                Console.WriteLine("16 - Exercício 9 da lista do dia 19");
                Console.WriteLine("17 - Exercício 10 da lista do dia 19");
                Console.WriteLine("18 - Exercício 1 da lista do dia 20");
                Console.WriteLine("19 - Exercício 2 da lista do dia 20");
                Console.WriteLine("20 - Exercício 3 da lista do dia 20");
                Console.WriteLine("21 - Exercício 4 da lista do dia 20");
                Console.WriteLine("22 - Exercício 5 da lista do dia 20");
                Console.WriteLine("23 - Exercício 6 da lista do dia 20");
                Console.WriteLine("24 - Exercício 7 da lista do dia 20");


                int escolha = Convert.ToInt32(Console.ReadLine());


                switch (escolha)
                {
                    case 1:
                        exercicioMedia();
                        break;

                    case 2:
                        lista01.exercicio1();
                        break;

                    case 3:
                        lista01.exercicio2();
                        break;

                    case 4:
                        lista01.exercicio3();
                        break;

                    case 5:
                        lista01.exercicio4();
                        break;

                    case 6:
                        lista01.exercicio5();
                        break;

                    case 7:
                        lista01.exercicio6();
                        break;

                    case 8:
                        lista02.ex01();
                        break;

                    case 9:
                        lista02.ex02();
                        break;

                    case 10:
                        lista02.ex03();
                        break;

                    case 11:
                        lista02.ex04();
                        break;

                    case 12:
                        lista02.ex05();
                        break;

                    case 13:
                        lista02.ex06();
                        break;

                    case 14:
                        lista02.ex07();
                        break;

                    case 15:
                        lista02.ex08();
                        break;

                    case 16:
                        lista02.ex09();
                        break;

                    case 17:
                        lista02.ex10();
                        break;

                    case 18:
                        lista03.questao01();
                        break;

                    case 19:
                        lista03.questao02();
                        break;

                    case 20:
                        lista03.questao03();
                        break;

                    case 21:
                        lista03.questao04();
                        break;

                    case 22:
                        lista03.questao05();
                        break;

                    case 23:
                        lista03.questao06();
                        break;

                    case 24:
                        lista03.questao07();
                        break;

                    default:
                        Console.WriteLine("Operação inválida.");
                        break;
                }

                Console.WriteLine("Deseja continuar no programa? (S/N)");
                opcao = Console.ReadLine().ToUpper();

            } while (opcao == "S");

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
