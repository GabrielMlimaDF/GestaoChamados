using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using GestaoChamados.Models.Enum;

namespace GestaoChamados.Models
{
    public class Operador
    {

        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }

        [Required]
        public TipoEnum TipoId { get; set; }

        [Required]
        public StatusOperadoresEnum StatusId { get; set; }

        [Required]
        public DateTime DataCadastro { get; set; } = DateTime.Now;
      
    }
}

