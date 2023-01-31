using AutoMapper;
using ForumApplication.DataModels;
using ForumApplication.Repositories;
using ForumApplication.ViewModels;
using System.Collections.Generic;
using System.Data.Common;

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
            _ur.DeleteUser(uid);
        }

        public UserViewModel GetUserByEmail(string email)
        {
            User u = _ur.GetUserByEmail(email);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserViewModel>();
                cfg.IgnoreUnmapped();
            });
            var mapper = config.CreateMapper();
            UserViewModel uvm =  mapper.Map<User, UserViewModel>(u);
            return uvm;
        }

        public UserViewModel GetUserByEmailAndPassword(string email, string password)
        {
            User u =  _ur.GetUserByEmailAndPassword(email, password);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserViewModel>();
                cfg.IgnoreUnmapped();
            });
            IMapper mapper = config.CreateMapper();
            UserViewModel uvm = mapper.Map<User, UserViewModel>(u);
            return uvm;
        }

        public List<UserViewModel> GetUsers()
        {
            List<User> u =  _ur.GetUsers();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserViewModel>();
                cfg.IgnoreUnmapped();
            });
            IMapper mapper = config.CreateMapper();
            List<UserViewModel> users = mapper.Map<List<User>, List<UserViewModel>>(u);
            return users;
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
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EditUserPasswordViewModel, User>();
                cfg.IgnoreUnmapped();
            });
            IMapper mapper = config.CreateMapper();
            User u = mapper.Map<EditUserPasswordViewModel, User>(uvm);
            _ur.UpdateUserPassword(u);
        }
    }
}
