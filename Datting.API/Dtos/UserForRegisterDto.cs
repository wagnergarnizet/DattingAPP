using System.ComponentModel.DataAnnotations;

namespace Datting.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }    
         
         [Required]
         [StringLength(8,MinimumLength=4,ErrorMessage="Senha deve conter 8 caracteres. Minimo de 4 caracteres.")]
         public string Password { get; set; }
    }
}