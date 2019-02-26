using System.ComponentModel.DataAnnotations;

namespace GigHub.ViewModel
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }
    }
}
