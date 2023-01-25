using ForumApplication.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ForumApplication.Repositories
{
    public interface IUserRepository
    {
        void InsertUser(User u);
        void UpdateUserDetails(User u);
        void UpdateUserPassword(User u);
        void DeleteUser(int userid);
        List<User> GetUsers();
        User GetUserByEmailAndPassword(string email, string password);
        User GetUserByEmail(string email);
        int GetLatestUserID();
    }
    public class UserRepository:IUserRepository
    {
        private ForumAppDbContext _dbContext;
        public UserRepository()
        {
            _dbContext = new ForumAppDbContext();
        }
        public void InsertUser(User u)
        {
            _dbContext.Users.Add(u);
            _dbContext.SaveChanges();
        }
        public void UpdateUserDetails(User u)
        {
            try
            {
                if (u != null && u.UserID > 0)
                {
                    User user = _dbContext.Users.Where(x => x.UserID == u.UserID).FirstOrDefault();
                    if (user != null)
                    {
                        user.Name = u.Name;
                        user.Mobile = u.Mobile;
                        _dbContext.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }
        public void UpdateUserPassword(User u)
        {
            User user = _dbContext.Users.Find(u.UserID);
            user.PasswordHash = u.PasswordHash;
            _dbContext.SaveChanges();
        }
        public void DeleteUser(int uid)
        {
            _dbContext.Users.Remove(_dbContext.Users.Find(uid));
            _dbContext.SaveChanges();
        }
        public List<User> GetUsers()
        {
            return _dbContext.Users.ToList();
        }
        public User GetUserByEmailAndPassword(string email, string password)
        {
            User u = _dbContext.Users.Where(x => x.Email == email && x.PasswordHash == password).FirstOrDefault();
            return u;
        }
        public User GetUserByEmail(string email)
        {
            User u = _dbContext.Users.Where(x => x.Email == email).FirstOrDefault();
            return u;
        }
        public int GetLatestUserID()
        {
            User user =  _dbContext.Users.OrderByDescending(x => x.UserID).Take(1).FirstOrDefault();
            return user.UserID;
        }
    }
}
