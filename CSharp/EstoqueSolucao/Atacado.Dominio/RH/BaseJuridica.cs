﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Dominio.RH
{
    public abstract class BaseJuridica : BasePessoa
    {
        protected string nomeFantasia;
        protected string razaoSocial;
        protected string cnpj;
        protected string inscricaoEstadual;
        protected DateTime fundacao;
        protected string emailCorporativo;

        public string NomeFantasia { get => nomeFantasia; set => nomeFantasia = value; }
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string InscricaoEstadual { get => inscricaoEstadual; set => inscricaoEstadual = value; }
        public DateTime Fundacao { get => fundacao; set => fundacao = value; }
        public string EmailCorporativo { get => emailCorporativo; set => emailCorporativo = value; }

        public BaseJuridica() : base()
        {
        }

        public BaseJuridica(int id, string nomeFantasia, string razaoSocial, string cnpj, string inscricaoEstadual, DateTime fundacao, string emailCorporativo) 
            : base(id)
        {
            this.nomeFantasia = nomeFantasia;
            this.razaoSocial = razaoSocial;
            this.cnpj = cnpj;
            this.inscricaoEstadual = inscricaoEstadual;
            this.fundacao = fundacao;
            this.emailCorporativo = emailCorporativo;
        }
    }
}
