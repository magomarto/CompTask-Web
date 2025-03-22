using System.ComponentModel.DataAnnotations;

namespace CompTask_Web.Models.Enums
{
    public enum Priority
    {
        [Display(Name = "Baixa")]
        Low,

        [Display(Name = "Média")]
        Medium,

        [Display(Name = "Alta")]
        High

    }
}