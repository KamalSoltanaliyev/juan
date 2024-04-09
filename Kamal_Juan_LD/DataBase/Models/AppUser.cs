using Microsoft.AspNetCore.Identity;

namespace Kamal_Juan_LD.DataBase.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
        public bool IsActive { get; set; }
    }
}
