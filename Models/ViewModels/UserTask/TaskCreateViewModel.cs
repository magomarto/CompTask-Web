using System.ComponentModel.DataAnnotations;
using CompTask_Web.Models.Enums;

namespace CompTask_Web.Models.ViewModels.UserTask
{
    public class TaskCreateViewModel
    {
        [Required(ErrorMessage ="Campo obrigatório")]
        [StringLength(100, ErrorMessage = "Máximo de 100 caracteres")]
        public string Title { get; set; }

        [StringLength(500, ErrorMessage = "Máximo de 500 caracteres")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Prazo")]
        public DateTime DueDate { get; set; } = DateTime.Now.AddDays(1);

        [Display(Name = "Prioridade")]
        public Priority TaskPriority { get; set; } = Priority.Medium;


    }
}