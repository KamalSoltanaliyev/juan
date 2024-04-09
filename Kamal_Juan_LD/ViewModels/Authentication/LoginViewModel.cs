using System.ComponentModel.DataAnnotations;

namespace Kamal_Juan_LD.ViewModels.Authentication
{
    public class LoginViewModel
    {
        [Required]
        public string UsernameOrEmail { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }

    }
}
