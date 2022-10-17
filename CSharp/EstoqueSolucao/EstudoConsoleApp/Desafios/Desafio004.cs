using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 004 - Crie um programa que leia um número e mostre o seu dobro, seu triplo e sua raiz
    /// quadrada.
    /// </summary>
    public static class Desafio004
    {
        public static void Executar()
        {
            Console.Write("Informe um número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int dobro = num * 2;
            int triplo = num * 3;
            double raiz = Math.Sqrt(Convert.ToDouble(num));
            Console.WriteLine("Para o número {0}:", num);
            Console.WriteLine("\t O dobro vale {0}", dobro);
            Console.WriteLine("\t O triplo vale {0}", triplo);
            Console.WriteLine("\t E a raiz vale {0}", raiz);
        }
    }
}
