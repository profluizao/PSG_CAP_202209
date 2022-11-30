namespace Clinica.Servico.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Clinica.Dominio.EF;
using Clinica.Poco;
using Clinica.Repositorio.Base;
using Clinica.Mapeamento.Base;

public class ServicoGenerico<TDominio, TPoco> :
    IServicoGenerico<TDominio, TPoco>
    where TDominio : class
    where TPoco : class
{
    protected RepositorioGenerico<TDominio> genrepo;

    protected MapeamentoGenerico<TDominio, TPoco> genmap;

    public ServicoGenerico(ClinicaContext context)
    { 
        this.genrepo = new RepositorioGenerico<TDominio>(context);
        this.genmap = new MapeamentoGenerico<TDominio, TPoco>();
    }

    public virtual List<TPoco> Listar()
    {
        return this.Consultar(null);
    }

    public virtual List<TPoco> Listar(int? take = null, int? skip = null)
    {
        throw new NotImplementedException("Deixa de ser preguiçoso!!!");
    }

    public virtual List<TPoco> Consultar(Expression<Func<TDominio, bool>>? predicate = null)
    {
        throw new NotImplementedException("Deixa de ser preguiçoso!!!");
    }

    public virtual List<TPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<TDominio, bool>>? predicate = null)
    {
        throw new NotImplementedException("Deixa de ser preguiçoso!!!");
    }

    public virtual TPoco? PesquisarPelaChave(object chave)
    {
        TDominio? lida = this.genrepo.GetById(chave);
        TPoco? lidaPoco = null;
        if (lida != null)
        {
            lidaPoco = this.ConverterPara(lida);
        }
        return lidaPoco;
    }

    public virtual TPoco? Inserir(TPoco obj)
    {
        TDominio? nova = this.ConverterPara(obj);
        TDominio? criada = this.genrepo.Insert(nova);
        TPoco? criadaPoco = null;
        if (criada != null)
        {
            criadaPoco = this.ConverterPara(criada);
        }
        return criadaPoco;
    }


    public virtual TPoco? Alterar(TPoco obj)
    {
        TDominio? editada = this.ConverterPara(obj);
        TDominio? alterada = this.genrepo.Update(editada);
        TPoco? alteradaPoco = null;
        if (alterada != null)
        { 
            alteradaPoco = this.ConverterPara(alterada);
        }
        return alteradaPoco;
    }

    public virtual TPoco? Excluir(object chave)
    {
        TDominio? del = this.genrepo.Delete(chave);
        TPoco? delPoco = null;
        if (del != null)
        {
            delPoco = this.ConverterPara(del);
        }
        return delPoco;
    }

    public virtual TDominio ConverterPara(TPoco obj)
    {
        return this.genmap.Mapping.Map<TDominio>(obj);
    }

    public virtual TPoco ConverterPara(TDominio obj)
    {
        return this.genmap.Mapping.Map<TPoco>(obj);
    }

    public virtual List<TPoco> ConverterPara(IQueryable<TDominio> query)
    {
        throw new NotImplementedException("Deixa de ser preguiçoso!!!");
    }
}

