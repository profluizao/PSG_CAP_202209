using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ViajeFacil.Dominio.EF
{
    [Table("Endereco", Schema = "DBO")]
    public partial class Endereco
    {
        [Key]
        [Column(name: "id_endereco")]
        public long CodigoEndereco { get; set; }

        [Column(name: "Rua")]
        [Unicode(false)]
        [StringLength(100)]
        public string Rua { get; set; } = null!;

        [Column(name: "Numero")]
        public int Numero { get; set; }

        [Column(name: "Complemento")]
        [Unicode(false)]
        [StringLength(255)]
        public string? Complemento { get; set; }

        [Column(name: "Bairro")]
        [Unicode(false)]
        [StringLength(100)]
        public string Bairro { get; set; } = null!;

        [Column(name: "Cep")]
        [Unicode(false)]
        [StringLength(9)]
        public string Cep { get; set; } = null!;

        [Column(name: "id_cidade")]
        public long CodigoCidade { get; set; }
    }
}











