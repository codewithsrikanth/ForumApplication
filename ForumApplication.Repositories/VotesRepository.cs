using ForumApplication.DataModels;
using System.Linq;

namespace ForumApplication.Repositories
{
    public interface IVotesRepository
    {
        void UpdateVote(int aid, int uid, int value);
    }
    public class VotesRepository:IVotesRepository
    {
        private ForumAppDbContext _dbContext;
        public VotesRepository()
        {
            _dbContext = new ForumAppDbContext();
        }

        public void UpdateVote(int aid, int uid, int value)
        {
            int updateValue;
            if (value > 0)
                updateValue = 1;
            else if (value < 0)
                updateValue = -1;
            else
                updateValue = 0;

            var vote = _dbContext.Votes.Where(x => x.AnswerID == aid && x.UserID == uid).FirstOrDefault();
            if(vote != null)
            {
                vote.VoteValue = updateValue;
            }
            else
            {
                Vote newVote = new Vote()
                {
                    UserID = uid,
                    AnswerID = aid,
                    VoteValue = updateValue
                };
                _dbContext.Votes.Add(newVote);
            }
            _dbContext.SaveChanges();
        }
    }
}
