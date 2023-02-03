using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ForumApplication.ServiceLayer;
using ForumApplication.ViewModels;

namespace UIForumAPP.Controllers
{
    public class HomeController : Controller
    {
        private IQuestionService _qs;
        public HomeController(IQuestionService qs)
        {
            this._qs = qs;
        }
        public ActionResult Index()
        {
            List<QuestionViewModel> questions =  this._qs.GetQuestions();
            return View(questions);
        }
    }
}