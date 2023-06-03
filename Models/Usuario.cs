using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace ProyectoSemana5.Models;
public class Usuario
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("usuarioId", TypeName = "bigint")]
    public long usuarioId { get; set; }

    [ForeignKey(nameof(Persona)), Required]
    [Column("personaId", TypeName = "bigint")]
    public long personaId { get; set; }

    [ForeignKey(nameof(TipoServicio)), Required]
    [Column("TipoServicioId", TypeName = "int")]
    public int TipoServicioId { get; set; }

    [Required]
    [Column("fechaIngreso", TypeName = "DateTime")]
    public DateTime fechaIngreso { get; set; }
}