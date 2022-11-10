using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Atacado.Poco.Estoque;
using Atacado.Servico.Estoque;
using System.Collections.Generic;

namespace AtacadoApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/estoque/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private CategoriaServico servico;

        /// <summary>
        /// 
        /// </summary>
        public CategoriaController() : base()
        {
            this.servico = new CategoriaServico();
        }

        /// <summary>
        /// Listar todos os registros da tabela.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<CategoriaPoco>> ObterTodos()
        {
            try
            {
                List<CategoriaPoco> lista = this.servico.Listar();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        [HttpGet("{codigo:int}")]
        public ActionResult<CategoriaPoco> ObterPorId(int codigo)
        {
            try
            {
                CategoriaPoco poco = this.servico.PesquisarPelaChave(codigo);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<CategoriaPoco> Adicionar([FromBody] CategoriaPoco poco)
        {
            try
            {
                CategoriaPoco novoPoco = this.servico.Inserir(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult<CategoriaPoco> Atualizar([FromBody] CategoriaPoco poco)
        {
            try
            {
                CategoriaPoco alterPoco = this.servico.Alterar(poco);
                return Ok(alterPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        [HttpDelete("{codigo:int}")]
        public ActionResult<CategoriaPoco> ExcluirPorId(int codigo)
        {
            try
            {
                CategoriaPoco delPoco = this.servico.Excluir(codigo);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpDelete]
        public ActionResult<CategoriaPoco> ExcluirPorInstancia([FromBody] CategoriaPoco poco)
        {
            try
            {
                CategoriaPoco delPoco = this.servico.Excluir(poco.Codigo);
                return Ok(delPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
