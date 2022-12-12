using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using ViajeFacil.Dominio.EF;
using ViajeFacil.Poco;
using ViajeFacil.Service.Base;

namespace ViajeFacil.Service.Agencia
{
    public class CidadeServico : GenericService<Cidade, CidadePoco>
    {
        public CidadeServico(ViajeFacilContexto contexto) : base(contexto)
        { }

        public override List<CidadePoco> Consultar(Expression<Func<Cidade, bool>>? predicate = null)
        {
            IQueryable<Cidade> query;
            if (predicate == null)
            {
                query = this.genrepo.Browseable(null);
            }
            else
            {
                query = this.genrepo.Browseable(predicate);
            }
            return this.ConverterPara(query);
        }

        public override List<CidadePoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Cidade> query;
            if (skip == null)
            {
                query = this.genrepo.GetAll();
            }
            else
            {
                query = this.genrepo.GetAll(take, skip);
            }
            return this.ConverterPara(query);
        }

        public override List<CidadePoco> ConverterPara(IQueryable<Cidade> query)
        {
            return query.Select(cid =>
                new CidadePoco()
                {
                    CidadeId = cid.CodigoCidade,
                    Nome = cid.Nome,
                    CodigoIBGE7 = cid.CodigoIbge7,
                    UF = cid.SiglaUf,
                    EstadoId = cid.CodigoEstado
                }).ToList();
        }
    }
}