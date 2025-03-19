using System.ComponentModel.DataAnnotations;

namespace CompTask_Web.Models.ViewModels
{
    public class RegisterViewModel // para registro de novos users
    {
        [Required(ErrorMessage = "nome de usuário obrigatório")]
        [Display(Name ="Nome de usuário")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "email obrigatório")]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "senha obrigatória")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="As senha não concidem")]
        [Display(Name ="confirme a senha")]
        public string ConfirmPassword { get; set; }

    }
}