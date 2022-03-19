using System.ComponentModel.DataAnnotations;

namespace eTicketsShop.Data.ValidationModels
{
    public class RegisterValidationModel
    {
        [Required(ErrorMessage = "Full name is required.")]
        [Display(Name = "Full name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email address is required.")]
        [Display(Name = "Email address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm password")]
        [Required(ErrorMessage = "Confirm password is required.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string PIN { get; set; }

        [Required]
        [StringLength(9, MinimumLength = 9)]
        public string PersonalIdNumber { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
    }
}
