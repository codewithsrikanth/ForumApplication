using System.ComponentModel.DataAnnotations;

namespace ForumApplication.ViewModels
{
    public class CategoryViewModel
    {
        public int CategoryID { get; set; }
        [Required]
        public string CategoryName { get; set; }
    }
}
