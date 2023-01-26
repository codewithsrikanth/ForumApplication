using ForumApplication.DataModels;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

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
    public class AnswersRepository : IAnswersRepository
    {
        private ForumAppDbContext _dbContext;
        private IQuestionsRepository _qr;
        private IVotesRepository _vr;
        public AnswersRepository()
        {
            _dbContext = new ForumAppDbContext();
            _qr = new QuestionsRepository();
            _vr = new VotesRepository();
        }
        public void DeleteAnswer(int aid)
        {
            var ans = _dbContext.Answers.Find(aid);
            _dbContext.Answers.Remove(ans);
            _dbContext.SaveChanges();
        }

        public List<Answer> GetAnswersByAnswerID(int aid)
        {
            return _dbContext.Answers.Where(x=>x.AnswerID == aid).ToList();
        }

        public List<Answer> GetAnswersByQuestionID(int qid)
        {
            return _dbContext.Answers.Where(x => x.QuestionID == qid).ToList();
        }

        public void InsertAnswer(Answer a)
        {
            _dbContext.Answers.Add(a);
            _dbContext.SaveChanges();
            _qr.UpdateQuestionAnswersCount(a.QuestionID, 1);
        }

        public void UpdateAnswer(Answer a)
        {
            Answer ans = _dbContext.Answers.Where(x => x.AnswerID == a.AnswerID).FirstOrDefault();
            if(ans != null)
            {
                ans.AnswerText = a.AnswerText;
                ans.AnswerDateAndTime = a.AnswerDateAndTime;
                _dbContext.SaveChanges();
            }
        }

        public void UpdateAnswerVotesCount(int aid, int uid, int value)
        {
            Answer ans = _dbContext.Answers.Where(x => x.AnswerID == aid).FirstOrDefault();
            if(ans != null)
            {
                ans.VotesCount += value;
                _dbContext.SaveChanges();
                _qr.UpdateQuestionVotesCount(ans.QuestionID, value);
            }
        }
    }
}
