using System.ComponentModel.DataAnnotations;

namespace AuthenticationTry1.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name ="Name")]
        public string UserName { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(25,ErrorMessage ="The {0} must be between {2} and {1} length",MinimumLength =5)]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Password does not match")]
        public string ConfirmPassword { get; set; }
    }
}
