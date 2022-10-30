using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Prova_N1.PSGCAP
{
    public abstract class BaseCampos
    {
        protected int codigo;

        protected DateOnly dataInclusao;

        private bool ativo;

        public int Codigo { get => codigo; set => codigo = value; }
        public DateOnly DataInclusao { get => dataInclusao; set => dataInclusao = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
    }
}
