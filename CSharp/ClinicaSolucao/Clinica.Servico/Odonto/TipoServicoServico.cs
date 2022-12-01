using Clinica.Dominio.EF;
using Clinica.Poco;
using Clinica.Servico.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Servico.Odonto
{
    public class TipoServicoServico : ServicoGenerico<TipoServico, TipoServicoPoco>
    {
        public TipoServicoServico(ClinicaContext contexto) : base(contexto)
        { }

        public override List<TipoServicoPoco> Consultar(Expression<Func<TipoServico, bool>>? predicate = null)
        {
            IQueryable<TipoServico> query;
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

        public override List<TipoServicoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<TipoServico> query;
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

        public override List<TipoServicoPoco> ConverterPara(IQueryable<TipoServico> query)
        {
            return query.Select(con =>
                new TipoServicoPoco()
                {
                    CodigoTipoServico = con.CodigoTipoServico,
                    DescricaoTipoServico = con.DescricaoTipoServico,
                    SiglaTipoServico =con.SiglaTipoServico
                }).ToList();
        }
    }
}
