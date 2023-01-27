using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace ForumApplication.ViewModels
{
    public class EditUserDetailsViewModel
    {
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Mobile { get; set; }
    }
}
