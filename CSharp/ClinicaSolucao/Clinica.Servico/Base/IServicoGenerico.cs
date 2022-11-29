namespace Clinica.Servico.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

public interface IServicoGenerico<TDominio, TPoco> 
    where TDominio : class
    where TPoco : class
{
    List<TPoco> Listar();

    List<TPoco> Listar(int? take = null, int? skip = null);

    List<TPoco> Consultar(Expression<Func<TDominio, bool>>? predicate = null);

    TPoco? PesquisarPelaChave(object chave);

    TPoco? Inserir(TPoco obj);

    TPoco? Alterar(TPoco obj);

    TPoco? Excluir(object chave);

    TDominio ConverterPara(TPoco obj);

    TPoco ConverterPara(TDominio obj);

    List<TPoco> ConverterPara(IQueryable<TDominio> query);
}
