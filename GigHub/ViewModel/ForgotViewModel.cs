using System.ComponentModel.DataAnnotations;

namespace GigHub.ViewModel
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }
    }
}