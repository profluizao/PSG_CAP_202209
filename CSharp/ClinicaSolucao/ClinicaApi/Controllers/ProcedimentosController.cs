using Clinica.Dominio.EF;
using Clinica.Poco;
using Clinica.Servico.Odonto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

using LinqKit;

namespace ClinicaApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/clinica/[controller]")]
    [ApiController]
    public class ProcedimentosController : ControllerBase
    {
        private ProcedimentosServico servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public ProcedimentosController(ClinicaContext contexto) : base()
        { 
            this.servico = new ProcedimentosServico(contexto);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tipoServico"></param>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [HttpGet("{tipoServico}")]
        public ActionResult<List<ServicoPoco>> GetAll(string tipoServico, int? take = null, int? skip = null)
        {
            try
            {
                List<ServicoPoco> listPoco;
                var predicado = PredicateBuilder.New<Clinica.Dominio.EF.Servico>(true);
                if (take == null) //OPCIONAL
                {
                    if (skip != null)
                    {
                        return BadRequest("Informe os parâmetros take e skip.");
                    }
                    else
                    {
                        predicado = predicado.And(s => s.TipoServico == "EX");
                        listPoco = this.servico.Consultar(predicado);
                        return Ok(listPoco);
                    }
                }
                else
                {
                    if (skip == null) //OPCIONAL
                    {
                        return BadRequest("Informe os parâmetros take e skip.");
                    }
                    else
                    {
                        predicado = predicado.And(s => s.TipoServico == tipoServico);
                        listPoco = this.servico.Vasculhar(take, skip, predicado);
                        return Ok(listPoco);
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{tipoServico}/{id:int}")]
        public ActionResult<ServicoPoco> Get(string tipoServico, int id)
        {
            try
            {
                List<ServicoPoco> listPoco = this.servico.Consultar(s => (s.TipoServico == tipoServico) && (s.CodigoServico == id));
                return Ok(listPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
