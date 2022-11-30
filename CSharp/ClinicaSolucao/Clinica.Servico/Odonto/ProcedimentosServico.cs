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
    public class ProcedimentosServico : ServicoGenerico<Clinica.Dominio.EF.Servico, ServicoPoco>
    {
        public ProcedimentosServico(ClinicaContext contexto) : base(contexto) { }

        public override List<ServicoPoco> Consultar(Expression<Func<Clinica.Dominio.EF.Servico, bool>>? predicate = null)
        {
            IQueryable<Clinica.Dominio.EF.Servico> query;
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

        public override List<ServicoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Clinica.Dominio.EF.Servico> query;
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

        public override List<ServicoPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<Dominio.EF.Servico, bool>>? predicate = null)
        {
            if (predicate == null)
            {
                return this.Listar(take, skip);
            }
            else
            {
                IQueryable<Clinica.Dominio.EF.Servico> query;
                query = this.genrepo.Searchable(take, skip, predicate);
                return this.ConverterPara(query);
            }
        }

        public override List<ServicoPoco> ConverterPara(IQueryable<Clinica.Dominio.EF.Servico> query)
        {
            return query.Select(con =>
                new ServicoPoco()
                {
                    CodigoServico = con.CodigoServico,
                    DataAlteracao = con.DataAlteracao,
                    DataInclusao = con.DataInclusao,
                    Descricao = con.Descricao,
                    MedidaPreventiva = con.MedidaPreventiva,
                    Preco = con.Preco,
                    Situacao = con.Situacao,
                    TipoExame = con.TipoExame,
                    TipoServico = con.TipoServico,
                    DenteTratado= con.DenteTratado,
                    MaterialUsado= con.MaterialUsado
                }).ToList();
        }
    }
}
