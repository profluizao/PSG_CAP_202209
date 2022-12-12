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
    [Table("Evento", Schema = "DBO")]
    public partial class Evento
    {
        [Key]
        [Column(name: "id_evento")]
        public long CodigoEvento { get; set; }

        [Column(name: "titulo")]
        [Unicode(false)]
        [StringLength(255)]
        public string Titulo { get; set; } = null!;

        [Column(name: "descricao")]
        [Unicode(false)]
        [StringLength(255)]
        public string Descricao { get; set; } = null!;

        [Column(name: "data_ida", TypeName = "Date")]
        public DateTime DataIda { get; set; }

        [Column(name: "data_volta", TypeName = "Date")]
        public DateTime DataVolta { get; set; }

        [Column(name: "id_instituicao")]
        public long CodigoInstituicao { get; set; }

        [Column(name: "id_endereco")]
        public long CodigoEndereco { get; set; }

        [Column(name: "id_rota_ida")]
        public long CodigoRotaIda { get; set; }

        [Column(name: "id_rota_volta")]
        public long CodigoRotaVolta { get; set; }

        [Column(name: "id_usuario_responsavel")]
        public long CodigoUsuarioResponsavel { get; set; }
    }
}









