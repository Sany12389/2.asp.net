
using System.ComponentModel.DataAnnotations;

public class Tipo
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo Nome é obrigatório.")]
    [MinLength(2, ErrorMessage = "O campo Nome deve ter no mínimo 2 caracteres.")]
    [MaxLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres.")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "O campo Nome é obrigatório.")]
    [MinLength(5, ErrorMessage = "O campo Nome deve ter no mínimo 5 caracteres.")]
    [MaxLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres.")]
    public string Descricao { get; set; } = string.Empty;

    [DataType(DataType.DateTime)]
    [Display(Name = "Data de Criação")]
    public DateTime DataCriacao { get; set; }

    [DataType(DataType.DateTime)]
    [Display(Name = "Data de Concluisão")]
    public DateTime DataConclusao { get; set; }

    public int TipoId { get; set; }
    public Tipo? TipoPai { get; set; }
    public bool Concluida { get; set; } = false;

    public () { DataCriacao = DateTime.Now; }
}
