using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Atacado.Poco.Estoque;
using Atacado.Servico.Estoque;
using Atacado.DB.EF.Database;

namespace AtacadoApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/estoque/[controller]")]
    [ApiController]
    public class SubcategoriaController : ControllerBase
    {
        private SubcategoriaServico servico;

        /// <summary>
        /// 
        /// </summary>
        public SubcategoriaController(ProjetoAcademiaContext contexto) : base()
        {
            this.servico = new SubcategoriaServico(contexto);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<SubcategoriaPoco> Get()
        {
            return this.servico.Listar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="catid"></param>
        /// <returns></returns>
        [HttpGet("PorCategoria/{catid:int}")]
        public List<SubcategoriaPoco> GetPorCategoria(int catid)
        {
            return this.servico.Consultar(sub => sub.CodigoCategoria == catid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public SubcategoriaPoco Get(int id)
        {
            return this.servico.PesquisarPelaChave(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPost]
        public SubcategoriaPoco Post([FromBody] SubcategoriaPoco poco)
        {
            return this.servico.Inserir(poco);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="poco"></param>
        /// <returns></returns>
        [HttpPut]
        public SubcategoriaPoco Put([FromBody] SubcategoriaPoco poco)
        {
            return this.servico.Alterar(poco);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public SubcategoriaPoco Delete(int id)
        {
            return this.servico.Excluir(id);
        }
    }
}
