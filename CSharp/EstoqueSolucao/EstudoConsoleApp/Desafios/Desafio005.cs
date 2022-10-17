using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 005 - Desenvolva um programa que leia as duas notas de um aluno, calcule e mostre a
    /// sua média.
    /// </summary>
    public static class Desafio005
    {
        public static void Executar()
        {
            Console.Write("Informe a primeira nota: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a segunda nota: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            double media = (n1 + n2) / 2;

            Console.WriteLine("A média vale {0}.", media);
        }
    }
}
