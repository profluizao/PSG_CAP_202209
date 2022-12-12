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
    [Table("Participante_Evento", Schema = "DBO")]
    public partial class ParticipanteEvento
    {
        [Key]
        [Column(name: "id_participante")]
        public long CodigoParticipanteEvento { get; set; }

        [Column(name: "pagamento")]
        public int Pagamento { get; set; }

        [Column(name: "sugestao")]
        [Unicode(false)]
        [StringLength(255)]
        public string Sugestao { get; set; } = null!;

        [Column(name: "avaliacao")]
        public int? Avaliacao { get; set; }

        [Column(name: "id_evento")]
        public long CodigoEvento { get; set; }

        [Column(name: "id_usuario")]
        public long CodigoUsuario { get; set; }

    }
}