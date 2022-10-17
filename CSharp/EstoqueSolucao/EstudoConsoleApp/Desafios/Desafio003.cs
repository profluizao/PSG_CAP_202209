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
    public static class Desafio003
    {
        public static void Executar()
        {
            Console.Write("Informe o primeiro número: ");
            int n1 = Int32.Parse(Console.ReadLine());
            Console.Write("Informe o segundo número: ");
            int n2 = Int32.Parse(Console.ReadLine());
            int soma = n1 + n2;
            Console.WriteLine("A soma de {0} com {1} é igual a {2}.", n1, n2, soma);
        }
    }
}
