using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using CompTask_Web.Models.Entities;

// estendendo as propriedades padrão do IdentityUser e adicionar campos personalizados ao usuário
namespace CompTask_Web.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
        
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Username")]
        [StringLength(100, ErrorMessage = "Máximo de 100 caracteres")]
        public string UserName { get; set; }

        [Display(Name = "Foto do Perfil")]
        public string ProfilePictureUrl { get; set; }

        [Display(Name = "Data de Registro")]
        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        // Relacionamento com Tasks 
        public ICollection<UserTask> Tasks { get; set; }
        
    }
}