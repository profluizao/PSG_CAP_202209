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
    [Table("Instituicao", Schema = "DBO")]
    public partial class Instituicao
    {
        [Key]
        [Column(name: "id_instituicao")]
        public long CodigoInstituicao { get; set; }

        [Column(name: "nome")]
        [Unicode(false)]
        [StringLength(100)]
        public string Nome { get; set; } = null!;

        [Column(name: "telefone")]
        [Unicode(false)]
        [StringLength(20)]
        public string Telefone { get; set; } = null!;

        [Column(name: "id_endereco")]
        public long CodigoEndereco { get; set; }
    }
}







