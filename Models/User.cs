#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;

namespace DateValidator.Models;

public class User
{
    [Required(ErrorMessage = "Campo Obligatorio")]
    [MinLength(5)]
    public string Nombre { get; set; }
    [Required(ErrorMessage = "Campo Obligatorio")]
    [MinLength(5)]
    public string Apellido { get; set; }
    [Required]
    [FutureDate]
    public DateTime FechaNacimiento { get; set; }
}