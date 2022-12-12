﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using ViajeFacil.Dominio.EF;
using ViajeFacil.Poco;
using ViajeFacil.Service.Base;

namespace ViajeFacil.Service.Agencia
{
    public class EventoServico : GenericService<Evento, EventoPoco>
    {
        public EventoServico(ViajeFacilContexto contexto) : base(contexto)
        { }

        public override List<EventoPoco> Consultar(Expression<Func<Evento, bool>>? predicate = null)
        {
            IQueryable<Evento> query;
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

        public override List<EventoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Evento> query;
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

        public override List<EventoPoco> ConverterPara(IQueryable<Evento> query)
        {
            return query.Select(eve =>
                new EventoPoco()
                {
                    EventoId = eve.CodigoEvento,
                    UsuarioResponsavelId = eve.CodigoUsuarioResponsavel,
                    Titulo = eve.Titulo,
                    Descricao = eve.Descricao,
                    EnderecoId = eve.CodigoEndereco,
                    DataIda = eve.DataIda,
                    RotaIdaId = eve.CodigoRotaIda,
                    DataVolta = eve.DataVolta,
                    RotaVoltaId = eve.CodigoRotaVolta,
                    InstituicaoId = eve.CodigoInstituicao
                }).ToList();
        }
    }
}