using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    /// <summary>
    /// Desafio 001 - Crie um programa que leia o nome de uma pessoa e mostre uma mensagem de
    /// boas-vindas de acordo com o valor digitado.
    /// </summary>
    public static class Desafio001
    {
        public static void Executar()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Seja bem vindo, {0}.", nome);
            //Console.WriteLine($"Seja bem vindo, {nome}.");
        }
    }
}
