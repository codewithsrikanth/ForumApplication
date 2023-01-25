using ForumApplication.DataModels;
using System.Collections.Generic;

namespace ForumApplication.Repositories
{
    public interface IAnswersRepository
    {
        void InsertAnswer(Answer a);
        void UpdateAnswer(Answer a);
        void DeleteAnswer(int aid);
        void UpdateAnswerVotesCount(int aid, int uid, int value);
        List<Answer> GetAnswersByQuestionID(int qid);
        List<Answer> GetAnswersByAnswerID(int aid);
    }
    public class AnswersRepository
    {
    }
}
