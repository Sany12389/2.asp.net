using System.ComponentModel.DataAnnotations;
namespace app_tarefas.Models;

public class Tarefas
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo Título é obrigatório.")]
    [MinLength(2, ErrorMessage = "O campo Título deve ter no mínimo 2 caracteres.")]
    [MaxLength(100, ErrorMessage = "O campo Título deve ter no máximo 100 caracteres.")]
    public string Nome { get; set; } = null!;

    [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
    [MinLength(5, ErrorMessage = "O campo Descrição deve ter no mínimo 5 caracteres.")]
    [MaxLength(500, ErrorMessage = "O campo Descrição deve ter no máximo 500 caracteres.")]
    public string Descricao { get; set; } = null!;

    [DataType(DataType.DateTime)]
    [Display(Name = "Data de Criação")]
    public DateTime DataCriacao { get; set; }

    [DataType(DataType.DateTime)]
    [Display(Name = "Data de Conclusão")]
    public DateTime? DataConclusao { get; set; }

    public int TipoId { get; set; }
    public Tipo Tipo { get; set; }
    public bool Concluida { get; set; } = false;
    
    public Tarefas() { DataCriacao = DateTime.Now; }

    public List<Tarefa> Tarefas { get; set; } = new List<Tarefa>();
}