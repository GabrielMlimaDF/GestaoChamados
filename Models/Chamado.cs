using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using GestaoChamados.Models.Enum;

namespace GestaoChamados.Models
{
    public class Chamado
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ClienteId { get; set; }

        [Required]
        public int OperadorId { get; set; }

        [Required]
        public int TecnicoId { get; set; }

        [Required]
        public int StatusChamadoId { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public DateTime DataAbertura { get; set; } = DateTime.Now;

        public DateTime? DataFechamento { get; set; }
       
        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }

        [ForeignKey("OperadorId")]
        public virtual Operador Operador { get; set; }

        [ForeignKey("TecnicoId")]
        public virtual Tecnico Tecnico { get; set; }

        [ForeignKey("StatusChamadoId")]
        public virtual StatusChamadoEnum StatusChamado { get; set; }
    }
}

