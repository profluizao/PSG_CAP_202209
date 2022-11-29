namespace Clinica.Mapeamento.Base;

using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MapeamentoGenerico<TDominio, TPoco>
    where TDominio : class
    where TPoco : class
{
    public IMapper Mapping { get; }

    public MapperConfiguration? Config { get; }

    public MapeamentoGenerico()
    {
        MapperConfiguration? config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<TDominio, TPoco>();
            cfg.CreateMap<TPoco, TDominio>();
        });
        this.Mapping = config.CreateMapper();
    }
}