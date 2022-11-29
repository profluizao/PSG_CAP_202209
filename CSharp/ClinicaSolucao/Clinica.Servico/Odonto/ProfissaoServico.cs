namespace Clinica.Servico.Odonto;

using Clinica.Dominio.EF;
using Clinica.Poco;
using Clinica.Servico.Base;

public class ProfissaoServico : ServicoGenerico<Profissao, ProfissaoPoco>
{
    public ProfissaoServico(ClinicaContext context) : base(context)
    { }
}

