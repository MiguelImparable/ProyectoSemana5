using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoSemana5.Models
{
    public class Cita
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("citaId", TypeName = "bigint")]
        public long citaId { get; set; }

        [ForeignKey(nameof(Persona)), Required]
        [Column("usuarioId", TypeName = "bigint")]
        public long usuarioId { get; set; }

        [ForeignKey(nameof(Medico)), Required]
        [Column("medicoId", TypeName = "bigint")]
        public long medicoId { get; set; }

        [Required]
        [Column("descripcion", TypeName = "vachar(100)")]
        public string? descripcion { get; set; }
    }
}

