using Microsoft.AspNetCore.Identity;

namespace GeekShopping.Idenetity.Server.Model
{
    public class ApplicationUser : IdentityUser
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
    }
}
