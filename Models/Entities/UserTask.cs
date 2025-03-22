using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CompTask_Web.Models.Identity;
using CompTask_Web.Models.Enums;


namespace CompTask_Web.Models.Entities
{
    public class UserTask
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; } = DateTime.Now.AddDays(1);
        public Priority TaskPriority { get; set; } = Priority.Medium;
        public Status IsCompleted { get; set; } // RELACIONAMENTO COM DATA? PARA VENCIMENTO?

        [ForeignKey("User")]
        public string UserId { get; set; }//RELACIONAMENTO COM USUÁRIO:
        public ApplicationUser User { get; set; }

    }

}