using System.Web.Mvc;

namespace OnlineLearningSystem.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult AdminDashboard()
        {
            ViewBag.UserName = Session["UserName"];
            return View();
        }

        public ActionResult AdminCourses()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }

        public ActionResult Payment()
        {
            return View();
        }

        public ActionResult Notices()
        {
            return View();
        }

        public ActionResult Feedback()
        {
            return View();
        }

        public ActionResult Changepassword()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
