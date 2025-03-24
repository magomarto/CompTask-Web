using CompTask_Web.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace CompTask_Web.Models.ViewModels.UserTask
{
    public class TaskEditViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100, ErrorMessage = "Máximo de 100 caracteres")]
        public string Title { get; set; }
        
        [StringLength(500, ErrorMessage ="Máximo de 500 caracteres")]
        public string Description { get; set; }

        [Required(ErrorMessage ="Campo obrigatório")]
        [Display(Name ="Prazo")]
        public DateTime DueDate { get ; set; } = DateTime.Now.AddDays(1);

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Prioridade")]
        public Priority TaskPriority { get; set; } = Priority.Medium;

        [Display(Name = "Status")]
        public Status TaskStatus { get; set; }

    }
}