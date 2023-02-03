using ForumApplication.ServiceLayer;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using Unity;
using Unity.Mvc5;
using Unity.WebApi;


namespace UIForumAPP
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IQuestionService, QuestionService>();
            container.RegisterType<IAnswerService, AnswerService>();
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<ICategoryService, CategoryService>();

            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
           GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);


        }
    }
}