using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APP_CRUD.Models;

public partial class Usuario
{
    public int Id { get; set; }
    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(50)]
    public string? Nombre { get; set; }
  
    public DateOnly? Fecha { get; set; }

    [Required(ErrorMessage = "La contraseña es obligatoria")]
    [DataType(DataType.Password)]
    public string? Contrasenia { get; set; }
}
