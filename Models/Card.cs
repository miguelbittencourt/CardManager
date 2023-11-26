using System.ComponentModel.DataAnnotations;

namespace CardManager.Models;

public class Card
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Campo Obrigatório")]
    [MaxLength(50, ErrorMessage = "O máximo é 50 caracteres")]
    [MinLength(3, ErrorMessage = "O mínimo é 3 caracteres")]
    public string Title { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo Obrigatório")]
    [MaxLength(100, ErrorMessage = "O máximo é 100 caracteres")]
    [MinLength(3, ErrorMessage = "O mínimo é 3 caracteres")]
    public string Description { get; set; } = string.Empty;
    public int ManaCost { get; set; }
    public ETypes Type { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int Health { get; set; }
    [Required(ErrorMessage = "Campo Obrigatório")]
    public string ImageUrl { get; set; } = string.Empty;

}