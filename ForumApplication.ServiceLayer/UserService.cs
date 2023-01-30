using AutoMapper;
using ForumApplication.DataModels;
using ForumApplication.Repositories;
using ForumApplication.ViewModels;
using System.Collections.Generic;

namespace ForumApplication.ServiceLayer
{
    public interface IUserService
    {
        int InsertUser(RegisterViewModel rvm);
        void UpdateUserDetails(EditUserDetailsViewModel uvm);
        void UpdateUserPassword(EditUserPasswordViewModel uvm);
        void DeleteUser(int uid);
        List<UserViewModel> GetUsers();
        UserViewModel GetUserByEmailAndPassword(string email, string password);
        UserViewModel GetUserByEmail(string email);
    }
    public class UserService : IUserService
    {
        IUserRepository _ur;
        public UserService()
        {
            _ur = new UserRepository();
        }

        public void DeleteUser(int uid)
        {
            throw new System.NotImplementedException();
        }

        public UserViewModel GetUserByEmail(string email)
        {
            throw new System.NotImplementedException();
        }

        public UserViewModel GetUserByEmailAndPassword(string email, string password)
        {
            throw new System.NotImplementedException();
        }

        public List<UserViewModel> GetUsers()
        {
            throw new System.NotImplementedException();
        }

        public int InsertUser(RegisterViewModel uvm)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RegisterViewModel, User>();
                cfg.IgnoreUnmapped();
            });
            IMapper mapper = config.CreateMapper();
            User u = mapper.Map<RegisterViewModel, User>(uvm);
            _ur.InsertUser(u);
            return _ur.GetLatestUserID();
        }
        public void UpdateUserDetails(EditUserDetailsViewModel uvm)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EditUserDetailsViewModel, User>();
                cfg.IgnoreUnmapped();
            });
            IMapper mapper = config.CreateMapper();
            User u = mapper.Map<EditUserDetailsViewModel, User>(uvm);
            _ur.UpdateUserDetails(u);
        }

        public void UpdateUserPassword(EditUserPasswordViewModel uvm)
        {
            throw new System.NotImplementedException();
        }
    }
}
