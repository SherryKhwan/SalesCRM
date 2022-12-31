using Microsoft.AspNetCore.Identity;

namespace SalesCRMApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string UserName { get; set; }
    }
}
