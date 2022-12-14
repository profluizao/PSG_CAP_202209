using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Prova_N1.PSGCAP
{
    public abstract class BaseVeiculo : BaseCampos
    {
        protected string cor;

        protected string chassi;

        protected string placa;

        protected string marca;

        protected string modelo;

        public string Cor { get => cor; set => cor = value; }
        public string Chassi { get => chassi; set => chassi = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
    }
}
