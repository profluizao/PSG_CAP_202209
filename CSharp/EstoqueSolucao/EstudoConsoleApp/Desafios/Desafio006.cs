using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 006 - Escreva um programa que leia um valor em metros e o exiba convertido em
    /// centímetros e milímetros.
    /// </summary>
    public static class Desafio006
    {
        public static void Executar()
        {
            Console.Write("Informe o número em metros: ");
            double num = Convert.ToDouble(Console.ReadLine());
            double cent = num * 100;
            double mil = num * 1000;
            Console.WriteLine("{0} metros valem {1} centimetros.", num, cent);
            Console.WriteLine("{0} metros valem {1} milimetros.", num, mil);
        }
    }
}
