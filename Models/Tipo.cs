using System.ComponentModel.DataAnnotations;

namespace _2.asp.net.Models;

public class Tipo
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo Nome é obrigatório.")]
    [MinLength(2, ErrorMessage = "O campo Nome deve ter no mínimo 2 caracteres.")]
    [MaxLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres.")]
    public string Nome { get; set; } = null!;

    [Required(ErrorMessage = "O campo Nome é obrigatório.")]
    [MinLength(2, ErrorMessage = "O campo Nome deve ter no mínimo 2 caracteres.")]
    [MaxLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres.")]
    public string Descricao { get; set; } = null!;

    public ICollection<Tarefa> Tarefas { get; set; } = new List<Tarefa>();
}
