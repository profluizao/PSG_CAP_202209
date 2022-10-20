using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Model.Estoque
{
    public class Produto : BaseEstoque
    {
        private int codigoSubcategoria;

        public int CodigoSubcategoria { get => this.codigoSubcategoria; set => this.codigoSubcategoria = value; }

        public Produto(int codigoSubcategoria) : base()
        {
            this.codigoSubcategoria = codigoSubcategoria;
        }

        public Produto(int codigo, string descricao, bool ativo, DateTime dataInclusao, int codigoSubcategoria)
            : base(codigo, descricao, ativo, dataInclusao)
        {
            this.codigoSubcategoria = codigoSubcategoria;
        }
    }
}
