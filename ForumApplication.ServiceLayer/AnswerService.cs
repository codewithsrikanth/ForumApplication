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
    public class AnswerService : IAnswerService
    {
        public void DeleteAnswer(int aid)
        {
            throw new System.NotImplementedException();
        }

        public List<AnswerViewModel> GetAnswersByAnswerID(int aid)
        {
            throw new System.NotImplementedException();
        }

        public List<AnswerViewModel> GetAnswersByQuestionID(int qid)
        {
            throw new System.NotImplementedException();
        }

        public void InsertAnswer(AnswerViewModel a)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateAnswer(EditAnswerViewModel a)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateAnswerVotesCount(int aid, int uid, int value)
        {
            throw new System.NotImplementedException();
        }
    }
}
