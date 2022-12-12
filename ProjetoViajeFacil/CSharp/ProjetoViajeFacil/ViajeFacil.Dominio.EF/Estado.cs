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
    [Table("Estado", Schema = "DBO")]
    public partial class Estado
    {
        [Key]
        [Column(name: "id_estado")]
        public long CodigoEstado { get; set; }

        [Column(name: "nome")]
        [Unicode(false)]
        [StringLength(100)]
        public string Nome { get; set; } = null!;

        [Column(name: "codigouf")]
        public long? CodigoUf { get; set; }

        [Column(name: "uf")]
        [Unicode(false)]
        [StringLength(2)]
        public string SiglaUf { get; set; } = null!;

        [Column(name: "id_regiao")]
        public long CodigoRegiao { get; set; }
    }
}









