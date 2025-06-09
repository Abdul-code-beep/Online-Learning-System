using System.Web;
using System;
using System.Web.Mvc;

namespace OnlineLearningSystem.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult StudentDashboard()
        {
            ViewBag.UserName = Session["UserName"];
            return View();
        }

        public ActionResult Courses()
        {
            return View();
        }

        public ActionResult WishList()
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

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult ChangePassword()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }
    }
}
