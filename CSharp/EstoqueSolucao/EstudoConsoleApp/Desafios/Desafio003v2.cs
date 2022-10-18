using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 003 – Crie um programa que leia dos números e tente mostrar a soma entre eles.
    /// </summary>
    public static class Desafio003v2
    {
        public static void Executar()
        {
            int n1, n2;
            Console.Write("Informe o primeiro número: ");
            if (Int32.TryParse(Console.ReadLine(), out n1) == false)
            {
                Console.WriteLine("Mensagem de erro.");
                return;
            }
            Console.Write("Informe o segundo número: ");
            if (Int32.TryParse(Console.ReadLine(), out n2) == false)
            {
                Console.WriteLine("Mensagem de erro.");
                return;
            }
            int soma = n1 + n2;
            Console.WriteLine("A soma de {0} com {1} é igual a {2}.", n1, n2, soma);
        }
    }
}
