using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ImobControl.Models;

public class Estado
{
    [Key]
    [StringLength(2, MinimumLength = 2, ErrorMessage = "O campo Sigla deve ter 2 caracteres")]
    public string Sigla { get; set; } = string.Empty;

    [Required(ErrorMessage = "O campo Nome é obrigatório")]
    public string Nome { get; set; } = string.Empty;
}