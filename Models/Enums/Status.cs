using System.ComponentModel.DataAnnotations;

namespace CompTask_Web.Models.Enums
{
    public enum Status
    { // depois pensar em lógica para relação de vencimento e data, no DB ou lógica?
        [Display(Name ="🟠 Pendente")]
        Pending,

        [Display(Name ="🟢 Concluída")]
        Completed,

        [Display(Name ="🔴 Atrasada")]
        Overdue

    }
}