using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoSemana5.Models
{
    public class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("personaId", TypeName = "bigint")]
        public long personaId { get; set; }

        [Required]
        [Column("nombreintegrado", TypeName = "varchar(100)")]
        public string? nombre { get; set; }

        [Required]
        [Column("cedula", TypeName = "bigint")]
        public long cedula { get; set; }

        [Required]
        [Column("celular", TypeName = "varchar(20)")]
        public string? celular { get; set; }

        [Required]
        [Column("direccion", TypeName = "varchar(50)")]
        public string? direccion { get; set; }
    }
}