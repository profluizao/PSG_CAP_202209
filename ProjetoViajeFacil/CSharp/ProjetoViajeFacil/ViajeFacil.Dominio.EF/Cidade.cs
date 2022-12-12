using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ViajeFacil.Dominio.EF
{
    [Table("Cidade", Schema = "DBO")]
    public partial class Cidade
    {
        [Key]
        [Column(name: "id_cidade")]
        public long CodigoCidade { get; set; }

        [Column(name: "nome")]
        [Unicode(false)]
        [StringLength(100)]
        public string Nome { get; set; } = null!;

        [Column(name: "codigo_ibge7")]
        public long CodigoIbge7 { get; set; }

        [Column(name: "uf")]
        [Unicode(false)]
        [StringLength(2)]
        public string SiglaUf { get; set; } = null!;

        [Column(name: "id_estado")]
        public long CodigoEstado { get; set; }
    }
}










