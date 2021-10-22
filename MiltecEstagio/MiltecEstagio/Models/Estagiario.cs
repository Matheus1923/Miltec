using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MiltecEstagio.Models
{
    [Table("Estagiario")]
    public class Estagiario
    {
        [Key]
        [Column("idestagiario")]
        [Required(ErrorMessage = "O campo é obrigatório")]

        public Int32 IdEstagiario { get; set; }

        [Column("nome")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo é obrigatório")]
        public string Nome { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "O campo é obrigatório")]
        [Column("email")]

        public string Email { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 10, ErrorMessage = "O campo deve conter entre 10 á 11 caracteres")]
        [Column("telefone")]

        public string Telefone { get; set; }

        [Column("salario")]
        [Required(ErrorMessage = "O campo é obrigatório")]

        public decimal Salario { get; set; }

    }
}
