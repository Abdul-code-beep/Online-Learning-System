using System.Linq;
using System.Web.Mvc;
using OnlineLearningSystem.Models; // Ensure this is your namespace

namespace OnlineLearningSystem.Controllers
{
    public class FacultyController : Controller
    {
        private AppDbContext db = new AppDbContext(); // Database context

        public ActionResult FacultyDashboard()
        {
            ViewBag.UserName = Session["UserName"];
            return View();
        }

        // GET: Change Password Page
        public ActionResult ChangePassword()
        {
            return View();
        }

        // POST: Change Password Logic
        [HttpPost]
        public ActionResult ChangePassword(string currentPassword, string newPassword, string confirmPassword)
        {
            string userEmail = Session["UserEmail"] as string; // Get logged-in user's email

            if (string.IsNullOrEmpty(userEmail))
            {
                ViewBag.Error = "Session expired. Please log in again.";
                return View();
            }

            var faculty = db.Users.FirstOrDefault(u => u.Email == userEmail && u.Role == "Faculty");

            if (faculty == null || faculty.Password != currentPassword)
            {
                ViewBag.Error = "Incorrect current password!";
                return View();
            }

            if (newPassword != confirmPassword)
            {
                ViewBag.Error = "New password and confirm password do not match!";
                return View();
            }

            // Update password
            faculty.Password = newPassword;
            db.SaveChanges();

            ViewBag.Success = "Password changed successfully!";
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult FacultyProfile()
        {
            return View();
        }


        public ActionResult Notices()
        {
            return View();
        }


        public ActionResult payment()
        {
            return View();
        }

        public ActionResult UploadCourse()
        {
            return View();
        }

        public ActionResult Timetable()
        {
            return View();
        }

        public ActionResult Upcoming()
        {
            return View();
        }

        
    }
}
