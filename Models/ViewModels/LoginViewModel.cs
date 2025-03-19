using System.ComponentModel.DataAnnotations;

namespace CompTask_Web.Models.ViewModels
{
    public class LoginViewModel // autenticar usuários
    {

        [Required(ErrorMessage = "O email é obrigatório")]
        [EmailAddress]
        public String Email { get; set;}

        [Required(ErrorMessage ="A senha é obrigatória")]
        [DataType(DataType.Password)]
        public string Password { get; set;}

        [Display(Name ="Lembre-se de mim")]
        public bool RememberMe { get; set; }

    }
}