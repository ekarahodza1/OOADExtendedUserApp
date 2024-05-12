using Microsoft.AspNetCore.Identity;

namespace ExtendedUserApp.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string ProfilePicture {  get; set; }
    }
}
