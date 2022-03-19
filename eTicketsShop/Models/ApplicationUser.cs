using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace eTicketsShop.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Full name")]
        public string FullName { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string PIN { get; set; }

        [Required]
        [StringLength(9, MinimumLength = 9)]
        public string PersonalIdNumber { get; set; }
    }
}
