using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Atacado.Poco.Estoque;
using Atacado.Servico.Estoque;

namespace AtacadoApi.Controllers
{
    [Route("api/estoque/[controller]")]
    [ApiController]
    public class SubcategoriaController : ControllerBase
    {
        private SubcategoriaServico servico;

        public SubcategoriaController() : base()
        {
            this.servico = new SubcategoriaServico();
        }

        [HttpGet]
        public List<SubcategoriaPoco> Get()
        {
            return this.servico.Browse();
        }

        [HttpGet("{catId:int}")]
        public List<SubcategoriaPoco> GetPorCategoriaId(int catId)
        {
            return this.servico.Browse().Where(cat => cat.CodigoCategoria == catId).ToList();
        }

        [HttpGet("{id}")]
        public SubcategoriaPoco Get(int id)
        {
            return this.servico.Read(id);
        }

        [HttpPost]
        public SubcategoriaPoco Post([FromBody] SubcategoriaPoco poco)
        {
            return this.servico.Add(poco);
        }

        [HttpPut]
        public SubcategoriaPoco Put([FromBody] SubcategoriaPoco poco)
        {
            return this.servico.Edit(poco);
        }

        [HttpDelete("{id}")]
        public SubcategoriaPoco Delete(int id)
        {
            return this.servico.Delete(id);
        }
    }
}
