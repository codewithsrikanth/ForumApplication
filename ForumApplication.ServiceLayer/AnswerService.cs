using ForumApplication.DataModels;
using ForumApplication.ViewModels;
using System.Collections.Generic;

namespace ForumApplication.ServiceLayer
{
    public interface IAnswerService
    {
        void InsertAnswer(AnswerViewModel a);
        void UpdateAnswer(EditAnswerViewModel a);
        void DeleteAnswer(int aid);
        void UpdateAnswerVotesCount(int aid, int uid, int value);
        List<AnswerViewModel> GetAnswersByQuestionID(int qid);
        List<AnswerViewModel> GetAnswersByAnswerID(int aid);
    }
    public class AnswerService
    {
    }
}
