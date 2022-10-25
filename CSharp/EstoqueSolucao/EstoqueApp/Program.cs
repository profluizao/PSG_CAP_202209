using System;

namespace EstoqueApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Fisica f1 = new Fisica(0, "321", "f1@teste", "Akira", "987");
            Fisica f2 = new Fisica(0, "654", "f2@teste", "Renato", "654");
            Fisica f3 = new Fisica(0, "987", "f3@teste", "Inoue", "321");

            PessoasFisica pessoas = new PessoasFisica();
            pessoas.Add(f1);
            pessoas.Add(f2);
            pessoas.Add(f3);

            foreach (Fisica item in pessoas)
            {
                item.Imprimir();
            }






            //Juridica j1 = new Juridica(1, "741", "j1@teste", "963", "Gimelli e Cia");
            //Juridica j2 = new Juridica(2, "852", "j2@teste", "753", "Souza e Cia");
            //Juridica j3 = new Juridica(3, "963", "j3@teste", "159", "Barreto e Cia");


            //List<Pessoa> pessoas = new List<Pessoa>();
            //pessoas.Add(f1);
            //pessoas.Add(f2);
            //pessoas.Add(f3);

            //pessoas.Add(j1);
            //pessoas.Add(j2);
            //pessoas.Add(j3);

            //foreach (Pessoa item in pessoas)
            //{
            //    item.Imprimir();
            //}
        }
    }
}