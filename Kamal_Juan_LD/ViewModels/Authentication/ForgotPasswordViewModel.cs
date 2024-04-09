using System.ComponentModel.DataAnnotations;

namespace Kamal_Juan_LD.ViewModels.Authentication
{
    public class ForgotPasswordViewModel
    {
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
