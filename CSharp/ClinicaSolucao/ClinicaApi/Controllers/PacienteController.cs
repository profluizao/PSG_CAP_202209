using Clinica.Dominio.EF;
using Clinica.Servico.Odonto;
using Clinica.Poco;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaApi.Controllers;

/// <summary>
/// 
/// </summary>
[ApiController]
[Route("api/odonto/[controller]")]
public class PacienteController : ControllerBase
{
    private PacienteServico servico;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public PacienteController(ClinicaContext context) : base()
    { 
        this.servico = new PacienteServico(context);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public ActionResult<List<PacientePoco>> ObterTodos()
    {
        try
        {
            List<PacientePoco> lista = this.servico.Listar();
            return Ok(lista);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
