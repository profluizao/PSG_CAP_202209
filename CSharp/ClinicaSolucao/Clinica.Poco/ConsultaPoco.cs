﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Poco
{
    public partial class ConsultaPoco
    {
        public int CodigoConsulta { get; set; }

        public string Historico { get; set; } = null!;

        public DateTime Data { get; set; }

        public TimeSpan Hora { get; set; }

        public DateTime DataHora { get; set; }

        public bool? Situacao { get; set; }

        public DateTime? DataInclusao { get; set; }

        public DateTime? DataAlteracao { get; set; }
    }
}
