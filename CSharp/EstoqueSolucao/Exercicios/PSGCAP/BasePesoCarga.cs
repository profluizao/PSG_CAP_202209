using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Prova_N1.PSGCAP
{
    public abstract class BasePesoCarga : BaseVeiculo
    {
        protected double pesoLiquido;

        protected double pesoBruto;

        protected double pesoTotal;

        public double PesoLiquido { get => pesoLiquido; set => pesoLiquido = value; }
        public double PesoBruto { get => pesoBruto; set => pesoBruto = value; }
        public double PesoTotal { get => pesoTotal; set => pesoTotal = value; }
    }
}
