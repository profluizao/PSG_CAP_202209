using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp
{
    public abstract class Ancestral
    {
        protected DateOnly dataInclusao;

        public DateOnly DataInclusao { get => dataInclusao; set => dataInclusao = value; }

        public Ancestral()
        {
        }

        public Ancestral(DateOnly dataInclusao)
        {
            this.dataInclusao = dataInclusao;
        }

        public abstract Ancestral Clone();
    }
}
