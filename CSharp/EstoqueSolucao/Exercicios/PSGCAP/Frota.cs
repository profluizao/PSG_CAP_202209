using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Prova_N1.PSGCAP
{
    public class Frota : BaseCampos
    {
        private List<BaseVeiculo> veiculos;

        private string finalidade;

        public List<BaseVeiculo> Veiculos { get => veiculos; set => veiculos = value; }
        public string Finalidade { get => finalidade; set => finalidade = value; }
    }
}
