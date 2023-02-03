using AutoMapper;
using ForumApplication.DataModels;
using ForumApplication.Repositories;
using ForumApplication.ViewModels;
using System.Collections.Generic;

namespace ForumApplication.ServiceLayer
{
    public interface IQuestionService
    {
        void InsertQuestion(NewQuestionViewModel qvm);
        void UpdateQuestionDetails(EditQuestionViewModel q);
        void UpdateQuestionVotesCount(int qid, int value);
        void UpdateQuestionAnswersCount(int qid, int value);
        void UpdateQuestionViewsCount(int qid);
        void DeleteQuestion(int qid);
        List<QuestionViewModel> GetQuestions();
        QuestionViewModel GetQuestionByQuestionID(int qid);
    }
    public class QuestionService : IQuestionService
    {
        private IQuestionsRepository _qr;
        public QuestionService()
        {
            _qr = new QuestionsRepository();
        }
       
        public void DeleteQuestion(int qid)
        {
            throw new System.NotImplementedException();
        }

        public QuestionViewModel GetQuestionByQuestionID(int qid)
        {
            throw new System.NotImplementedException();
        }

        public List<QuestionViewModel> GetQuestions()
        {
            List<Question> questions =  _qr.GetQuestions();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Question, QuestionViewModel>();
                cfg.IgnoreUnmapped();
            });
            var mapper = config.CreateMapper();
            var qs = mapper.Map<List<Question>,List<QuestionViewModel>>(questions);

            return qs;
        }

        public void InsertQuestion(NewQuestionViewModel qvm)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateQuestionAnswersCount(int qid, int value)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateQuestionDetails(EditQuestionViewModel q)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateQuestionViewsCount(int qid)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateQuestionVotesCount(int qid, int value)
        {
            throw new System.NotImplementedException();
        }
    }
}
