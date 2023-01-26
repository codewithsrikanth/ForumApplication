﻿using ForumApplication.DataModels;
using System.Collections.Generic;
using System.Linq;

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
    public class QuestionsRepository: IQuestionsRepository
    {
        private ForumAppDbContext _dbContext;
        public QuestionsRepository()
        {
            _dbContext = new ForumAppDbContext();
        }

        public void DeleteQuestion(int qid)
        {
            var qus = _dbContext.Questions.Where(x => x.QuestionID == qid).FirstOrDefault();
            _dbContext.Questions.Remove(qus);
            _dbContext.SaveChanges();
        }

        public Question GetQuestionByQuestionID(int qid)
        {
            return _dbContext.Questions.Find(qid);
        }

        public List<Question> GetQuestions()
        {
            return _dbContext.Questions.ToList();
        }

        public void InsertQuestion(Question q)
        {
            _dbContext.Questions.Add(q);
            _dbContext.SaveChanges();
        }

        public void UpdateQuestionAnswersCount(int qid, int value)
        {
            var qus = _dbContext.Questions.Where(x => x.QuestionID == qid).FirstOrDefault();
            if(qus != null)
            {
                qus.AnswersCount += value;
                _dbContext.SaveChanges();
            }
        }

        public void UpdateQuestionDetails(Question q)
        {
            var qus = _dbContext.Questions.Where(x => x.QuestionID == q.QuestionID).FirstOrDefault();
            if(qus != null)
            {
                qus.QuestionName = q.QuestionName;
                qus.QuestionDateAndTime = q.QuestionDateAndTime;
                qus.CategoryID = q.CategoryID;
                _dbContext.SaveChanges();
            }
        }

        public void UpdateQuestionViewsCount(int qid)
        {
            var qus = _dbContext.Questions.Where(x => x.QuestionID == qid).FirstOrDefault();
            if (qus != null)
            {
                qus.ViewsCount += 1;
                _dbContext.SaveChanges();
            }
        }

        public void UpdateQuestionVotesCount(int qid, int value)
        {
            var qus = _dbContext.Questions.Where(x => x.QuestionID == qid).FirstOrDefault();
            if(qus != null)
            {                
                qus.VotesCount += value;
                _dbContext.SaveChanges();
            }
        }
    }
}
