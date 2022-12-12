﻿using ViajeFacil.Dominio.EF;
using ViajeFacil.Mapping;
using ViajeFacil.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ViajeFacil.Service.Base;

namespace ViajeFacil.Service.Base
{
    public class GenericService<TDominio, TPoco>
            : IGenericService<TDominio, TPoco>
            where TDominio : class
            where TPoco : class
    {

        protected GenericRepository<TDominio> genrepo;

        protected GenericMap<TDominio, TPoco> genmap;

        public GenericService(ViajeFacilContexto context)
        {
            this.genrepo = new GenericRepository<TDominio>(context);
            this.genmap = new GenericMap<TDominio, TPoco>();
        }

        public List<TPoco> Listar()
        {
            return Consultar(null);
        }

        public virtual List<TPoco> Listar(int? take = null, int? skip = null)
        {
            throw new NotImplementedException();
        }

        public virtual List<TPoco> Consultar(Expression<Func<TDominio, bool>>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public virtual List<TPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<TDominio, bool>>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public TPoco? PesquisarPelaChave(object chave)
        {
            TDominio? lida = genrepo.GetById(chave);
            TPoco? lidaPoco = null;
            if (lida != null)
            {
                lidaPoco = ConverterPara(lida);
            }
            return lidaPoco;
        }

        public TPoco? Inserir(TPoco poco)
        {
            TDominio? nova = ConverterPara(poco);
            TDominio? criada = genrepo.Insert(nova);
            TPoco? criadaPoco = null;
            if (criada != null)
            {
                criadaPoco = ConverterPara(criada);
            }
            return criadaPoco;
        }

        public TPoco? Alterar(TPoco poco)
        {
            TDominio? editada = ConverterPara(poco);
            TDominio? alterada = genrepo.Update(editada);
            TPoco? alteradaPoco = null;
            if (alterada != null)
            {
                alteradaPoco = ConverterPara(alterada);
            }
            return alteradaPoco;
        }

        public TPoco? Excluir(object chave)
        {
            TDominio? del = genrepo.Delete(chave);
            TPoco? delPoco = null;
            if (del != null)
            {
                delPoco = ConverterPara(del);
            }
            return delPoco;
        }

        public TDominio ConverterPara(TPoco poco)
        {
            return this.genmap.Mapping.Map<TDominio>(poco);
        }

        public TPoco ConverterPara(TDominio dominio)
        {
            return this.genmap.Mapping.Map<TPoco>(dominio);
        }

        public virtual List<TPoco> ConverterPara(IQueryable<TDominio> query)
        {
            throw new NotImplementedException();
        }
    }
}