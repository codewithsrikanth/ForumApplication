using System;
using System.ComponentModel.DataAnnotations;

namespace ForumApplication.ViewModels
{
    public class EditQuestionViewModel
    {
        public int QuestionID { get; set; }
        [Required]
        public string QuestionName { get; set; }
        [Required]
        public DateTime QuestionDateAndTime { get; set; }
        [Required]
        public int CategoryID { get; set; }
    }
}
