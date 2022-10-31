using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Prova_N1.PSGCAP
{
    public class EventoFrota : BaseCampos
    {
        private DateOnly dataInicial;

        private DateOnly dataFinal;

        private int kmInicial;

        private int kmFinal;

        private Colaborador condutor;

        private string motivoEvento;

        public DateOnly DataInicial { get => dataInicial; set => dataInicial = value; }
        public DateOnly DataFinal { get => dataFinal; set => dataFinal = value; }
        public int KmInicial { get => kmInicial; set => kmInicial = value; }
        public int KmFinal { get => kmFinal; set => kmFinal = value; }
        public Colaborador Condutor { get => condutor; set => condutor = value; }
        public string MotivoEvento { get => motivoEvento; set => motivoEvento = value; }
    }

    public class Colaborador
    { }
}
