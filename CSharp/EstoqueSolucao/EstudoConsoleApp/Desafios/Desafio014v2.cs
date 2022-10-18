using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    public static class Desafio014v2
    {
        private static List<string> nomes = new List<string>();

        public static void Executar()
        {
            bool sair = false;
            while (sair == false)
            {
                sair = PreencherLista();
            }
            ImprimirLista();
        }

        private static bool PreencherLista()
        {
            Console.WriteLine("Nomes na lista: {0}.", nomes.Count);
            bool testar = true;
            while (testar == true)
            {
                testar = DigitarNome();
            }
            Console.Write("Deseja sair <S/N>:");
            string teste = Console.ReadLine();
            if (teste.ToUpper() == "S")
            {
                return true;
            }
            else
            {
                Console.Clear();
                return false;
            }
        }

        private static bool DigitarNome()
        {
            Console.Write("Digite um nome de aluno:");
            string nome = Console.ReadLine();

            if (string.IsNullOrEmpty(nome.Trim()) == true)
            {
                Console.WriteLine("Nome é obrigatório.");
                Console.WriteLine("Tente novamente.");
                return true;
            }
            else
            {
                nomes.Add(nome);
                return false;
            }
        }

        private static void ImprimirLista()
        {
            Console.Clear();
            Console.WriteLine("Imprimindo nomes na lista.");
            foreach (string nome in nomes)
            {
                Console.WriteLine("\t Nome: {0}", nome);
            }
        }
    }
}
