using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoSemana5.Models
{
    public class Medico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("medicoId", TypeName = "bigint")]
        public long medicoId { get; set; }

        [ForeignKey(nameof(Persona)), Required]
        [Column("personaId", TypeName = "bigint")]
        public long personaId { get; set; }

        [ForeignKey(nameof(TipoMedico)), Required]
        [Column("tipoMedicoId", TypeName = "int")]
        public int tipoMedicoId { get; set; }

        [Required]
        [Column("fechaContrato", TypeName = "DateTime")]
        public DateTime fechaContrato { get; set; }
    }
}