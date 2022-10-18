using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    public static class Desafio018
    {
        public static void Executar()
        {
            List<string> nomes = new List<string>();
            bool sair = false;
            while (sair == false)
            {
                Console.WriteLine("Nomes na lista: {0}.", nomes.Count);
                bool testar = true;
                while (testar == true)
                {
                    Console.Write("Digite um nome de aluno:");
                    string nome = Console.ReadLine();
                    nome = nome.Trim();
                    if (string.IsNullOrEmpty(nome) == true)
                    {
                        Console.WriteLine("Nome é obrigatório.");
                        Console.WriteLine("Tente novamente.");
                        testar = true;
                    }
                    else
                    {
                        nomes.Add(nome);
                        testar = false;
                    }
                }
                Console.Write("Deseja sair <S/N>:");
                string teste = Console.ReadLine();
                if (teste.ToUpper() == "S")
                {
                    sair = true;
                }
                else
                {
                    Console.Clear();
                    sair = false;
                }
            }

            //Ordenação
            nomes.Sort();

            Console.Clear();
            Console.WriteLine("Imprimindo nomes na lista.");
            foreach (string nome in nomes)
            {
                Console.WriteLine("\t Nome: {0}", nome);
            }

            //Sorteio
            Random rnd = new Random();

            List<int> pos = new List<int>();
            int indice = 0;
            while (indice < nomes.Count)
            {
                int posicao = rnd.Next(nomes.Count);
                if (pos.Count == 0)
                {
                    pos.Add(posicao);
                    indice++;
                }
                else
                {
                    if (pos.Contains(posicao) == false)
                    {
                        pos.Add(posicao);
                        indice++;
                    }
                }
            }

            //Imprimindo lista sorteada.
            Console.WriteLine("Imprimindo lista sorteada.");
            for (int i = 0; i < pos.Count; i++)
            {
                int num = pos[i];
                Console.WriteLine("\t Nome: {0}", nomes[pos[i]]);
            }

            //Escolhendo alguém da lista sorteada.
            int sorteado = rnd.Next(pos.Count);
            Console.WriteLine("Sorteado: {0}", nomes[sorteado]);
        }
    }
}
