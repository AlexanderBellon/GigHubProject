using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }
    }
}