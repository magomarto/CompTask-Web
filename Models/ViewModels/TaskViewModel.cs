using System.ComponentModel.DataAnnotations;
using CompTask_Web.Models.Entities;

namespace CompTask_Web.Models.ViewModels
{
    public class TaskViewModel // criar e editar tarefas
    {
        [Required(ErrorMessage = "O título é obrigatório")]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Selecione uma prioridade")]
        public Priority Priority { get; set; }

        [Required(ErrorMessage = "Informe a data de vencimento")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; } = DateTime.Today.AddDays(1);
        
    }
}