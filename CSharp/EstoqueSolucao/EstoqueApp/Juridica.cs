using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp
{
    public class Juridica : Pessoa
    {
        private string cnpj;
        private string razaoSocial;

        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }

        public Juridica()
        {
        }

        public Juridica(int codigo, string telefone, string email, string cnpj, string razaoSocial)
            : base(codigo, telefone, email)
        {
            this.cnpj = cnpj;
            this.razaoSocial = razaoSocial;
        }

        public override void Imprimir()
        {
            Console.WriteLine("{0}", this.codigo);
            Console.WriteLine("{0}", this.email);
            Console.WriteLine("{0}", this.telefone);

            Console.WriteLine("{0}", this.cnpj);
            Console.WriteLine("{0}", this.razaoSocial);
        }

        public override Ancestral Clone()
        {
            throw new NotImplementedException();
        }
    }
}
