using System;

namespace ForumApplication.ViewModels
{
    public class AnswerViewModel
    {
        public int AnswerID { get; set; }
        public string AnswerText { get; set; }
        public DateTime AnswerDateAndTime { get; set; }
        public int UserID { get; set; }
        public int QuestionID { get; set; }
        public int VotesCount { get; set; }
        public UserViewModel User { get; set; }
        public QuestionViewModel Question { get; set; }
        public int CurrentUserVoteType { get; set; }
    }
}
