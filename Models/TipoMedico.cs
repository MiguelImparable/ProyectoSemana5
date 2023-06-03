using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace ProyectoSemana5.Models;
public class TipoMedico
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("tipoMedicoId", TypeName = "int")]
    public int tipoMedicoId { get; set; }

    [Column("cargo", TypeName = "varchar(100)")]
    public string? cargo { get; set; }
}