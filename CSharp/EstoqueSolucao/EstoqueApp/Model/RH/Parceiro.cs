using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Model.RH
{
    public class Parceiro : BaseJuridica
    {
        private double desempenho;
        private double comissao;
        private string setor;

        public double Desempenho { get => desempenho; set => desempenho = value; }
        public double Comissao { get => comissao; set => comissao = value; }
        public string Setor { get => setor; set => setor = value; }

        public Parceiro() : base()
        {
        }

        public Parceiro(int id, string nomeFantasia, string razaoSocial, string cnpj, string inscricaoEstadual, 
            DateTime fundacao, string emailCorporativo, double desempenho, double comissao, string setor)
            : base(id, nomeFantasia, razaoSocial, cnpj, inscricaoEstadual, fundacao, emailCorporativo)
        {
            this.desempenho = desempenho;
            this.comissao = comissao;
            this.setor = setor;
        }
    }
}
