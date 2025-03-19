using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CompTask_Web.Models.Identity;

namespace CompTask_Web.Models.Entities
{
    public class Task
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage ="O titulo é obrigatório")]
        [StringLength(100, ErrorMessage ="O titulo deve ter no máximo 100 caracteres")]
        public string Title { get; set; }


        [StringLength(500, ErrorMessage = "A descrição deve ter no máximo 500 caracteres")]
        public string Description { get; set; }


        [Required(ErrorMessage ="A data de vencimento é obrigatória")]
        [Display(Name = "Prazo")]
        public DateTime DueDate { get; set; } = DateTime.Now.AddDays(1); // data de vencimento


        [Required(ErrorMessage = "A prioridade é obrigatoria")]
        [Display(Name ="Prioridade")]
        public Priority TaskPriority { get; set; } = Priority.Medium;


        [Display(Name = "Status")]
        public Status IsCompleted { get; set; } // RELACIONAMENTO COM DATA? PARA VENCIMENTO?
        
        //RELACIONAMENTO COM USUÁRIO:
        [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

    }

    public enum Priority
    {
        [Display(Name = "Baixa")]
        Low,

        [Display(Name = "Média")]
        Medium,

        [Display(Name = "Alta")]
        High

    }

    public enum Status{ // depois pensar em lógica para relação de vencimento e data, no DB ou lógica?
        [Display(Name ="🟠 Pendente")]
        Pending,

        [Display(Name ="🟢 Concluída")]
        Completed,

        [Display(Name ="🔴 Atrasada")]
        Overdue

    }
}