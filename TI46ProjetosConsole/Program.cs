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

            res = ((n1 + n2 + n3 + n4)/4);

            Console.WriteLine("O aluno " + nome + " teve média final de: " + res);


            Console.ReadKey();


        }
    }
}
