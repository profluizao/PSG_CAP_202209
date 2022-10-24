using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp
{
    public abstract class Pessoa : Ancestral
    {
        protected int codigo;
        protected string telefone;
        protected string email;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }

        public Pessoa()
        {
        }

        public Pessoa(int codigo, string telefone, string email)
        {
            this.codigo = codigo;
            this.telefone = telefone;
            this.email = email;
        }

        public abstract void Imprimir();

    }
}
