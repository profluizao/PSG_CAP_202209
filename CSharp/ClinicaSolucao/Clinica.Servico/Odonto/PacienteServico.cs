namespace Clinica.Servico.Odonto;

using Clinica.Dominio.EF;
using Clinica.Poco;
using Clinica.Servico.Base;

public class PacienteServico : ServicoGenerico<Paciente, PacientePoco>
{
    public PacienteServico(ClinicaContext context) : base(context)
    { }
}
