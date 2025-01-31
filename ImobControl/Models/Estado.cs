using System.ComponentModel.DataAnnotations;

namespace ImobControl.Models;

public class Estado
{
    [Key]
    [StringLength(2, MinimumLength = 2, ErrorMessage = "A Sigla do estado deve ter 2 caracteres")]
    public string Sigla { get; set; } = string.Empty;

    [Required(ErrorMessage = "O nome do estado é obrigatório")]
    public string Nome { get; set; } = string.Empty;
}