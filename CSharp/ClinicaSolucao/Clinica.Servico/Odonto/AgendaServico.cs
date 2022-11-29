namespace Clinica.Servico.Odonto;

using Clinica.Dominio.EF;
using Clinica.Poco;
using Clinica.Servico.Base;

public class AgendaServico : ServicoGenerico<Agenda, AgendaPoco>
{
    public AgendaServico(ClinicaContext context) : base(context)
    { }
}
