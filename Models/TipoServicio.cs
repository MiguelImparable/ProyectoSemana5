using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoSemana5.Models
{
    public class TipoServicio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("TipoServicioId", TypeName = "int")]
        public int TipoServicioId { get; set; }

        [Required]
        [Column("descripcionPlan", TypeName = "vachar(100)")]
        public string? descripcionPlan { get; set; }
    }
}