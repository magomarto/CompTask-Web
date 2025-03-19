using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

// estendendo as propriedades padrão do IdentityUser e adicionar campos personalizados ao usuário
namespace CompTask_Web.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
        
        [Required(ErrorMessage = "O nome de usuário é obrigatório")]
        [Display(Name = "Username")]
        [StringLength(100, ErrorMessage = "Máximo de 100 caracteres")]
        public string UserName { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Foto do Perfil")]
        public string ProfilePictureUrl { get; set; }

        public string Address { get; set; }

        [Display(Name = "Data de Registro")]
        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        // Relacionamento com Tasks 
        public ICollection<Task> Tasks { get; set; }
        
    }
}