using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp
{
    public class PessoasFisica : List<Fisica>
    {
        private List<Fisica> interna;

        public PessoasFisica() : base()
        {
            this.interna = new List<Fisica>();
        }

        public PessoasFisica(List<Fisica> fisicas) : base(fisicas)
        {
            this.interna = fisicas;
        }

        public PessoasFisica(int qtde) : base(qtde)
        { }

        public new Fisica Add(Fisica novo)
        {
            int novaChave = this.interna.Count + 1;
            novo.Codigo = novaChave;
            this.interna.Add(novo);
            return novo;
        }

        public new int Count()
        { 
            return this.interna.Count;
        }
    }
}
