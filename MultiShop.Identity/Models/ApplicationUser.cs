using Microsoft.AspNetCore.Identity;

namespace MultiShop.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}