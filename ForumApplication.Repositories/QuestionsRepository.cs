using ForumApplication.DataModels;
using System.Collections.Generic;

namespace ForumApplication.Repositories
{
    public interface IQuestionsRepository
    {
        void InsertQuestion(Question q);
        void UpdateQuestionDetails(Question q);
        void UpdateQuestionVotesCount(int qid, int value);
        void UpdateQuestionAnswersCount(int qid, int value);
        void UpdateQuestionViewsCount(int qid);
        void DeleteQuestion(int qid);
        List<Question> GetQuestions();
        Question GetQuestionByQuestionID(int qid);
    }
    public class QuestionsRepository
    {
    }
}
