using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using GestaoChamados.Models.Enum;

namespace GestaoChamados.Models
{
    public class Tecnico
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 11)]
        [Phone]
        public string Telefone { get; set; }

        [Required]
        public string Especialidade { get; set; }

        [Required]
        public string Senha { get; set; }

        [Required]
        public StatusOperadoresEnum StatusId { get; set; }

        [Required]
        public DateTime DataCadastro { get; set; } = DateTime.Now;
       
    }
}

