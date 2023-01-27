using System.ComponentModel.DataAnnotations;

namespace ForumApplication.ViewModels
{
    public class EditUserPasswordViewModel
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
