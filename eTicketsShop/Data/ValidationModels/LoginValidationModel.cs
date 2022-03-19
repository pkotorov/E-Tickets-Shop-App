using System.ComponentModel.DataAnnotations;

namespace eTicketsShop.Data.ValidationModels
{
    public class LoginValidationModel
    {
        [Required(ErrorMessage = "Email address is required.")]
        [Display(Name = "Email address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
