using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp
{
    public class Fisica : Pessoa
    {
        private string nome;
        private string cpf;

        public Fisica() : base()
        { }

        public Fisica(int codigo, string telefone, string email, string nome, string cpf) 
            : base(codigo, telefone, email)
        {
            this.nome = nome;
            this.cpf = cpf;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }


        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Informações na classe Fisica:");
            Console.WriteLine("CPF: {0}", this.cpf);
            Console.WriteLine("Nome: {0}", this.nome);
            Console.WriteLine("-------------------------------");
        }

        public override Ancestral Clone()
        {
            throw new NotImplementedException();
        }
    }
}
