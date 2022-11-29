namespace Clinica.Repositorio.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Clinica.Dominio.EF;
using Microsoft.EntityFrameworkCore;

public class RepositorioGenerico<TDominio> : IRepositorioGenerico<TDominio> 
    where TDominio : class
{
    private ClinicaContext context;

    private DbSet<TDominio> table;

    public RepositorioGenerico(ClinicaContext context)
    { 
        this.context = context;
        this.table = this.context.Set<TDominio>();
    }

    public IQueryable<TDominio> Browseable(Expression<Func<TDominio, bool>>? predicate = null)
    {
        if (predicate == null)
        {
            return this.table.AsQueryable();
        }
        else
        {
            return this.table.Where(predicate);
        }
    }

    public IQueryable<TDominio> GetAll(int? take = null, int? skip = null)
    {
        if (skip == null)
        {
            return this.table;
        }
        else
        { 
            return this.table.Skip(skip.Value).Take(take.Value);
        }
    }

    public TDominio? GetById(object id)
    {
        return this.table.Find(id);
    }

    public TDominio? Insert(TDominio obj)
    {
        this.table.Add(obj);
        this.context.SaveChanges();
        return obj;
    }

    public TDominio? Update(TDominio obj)
    {
        this.table.Attach(obj);
        this.context.Entry(obj).State = EntityState.Modified;
        this.context.SaveChanges();
        return obj;
    }

    public TDominio? Delete(object id)
    {
        TDominio? existing = this.GetById(id);
        if (existing != null)
        {
            this.table.Remove(existing);
            this.context.SaveChanges();
        }
        return existing;
    }

    public void Save()
    {
        this.context.SaveChanges();
    }
}
