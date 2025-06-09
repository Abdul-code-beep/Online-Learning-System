using System.Linq;
using System.Web.Mvc;
using OnlineLearningSystem.Models;

namespace OnlineLearningSystem.Controllers
{
    public class AccountController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // Registration Page
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            var existingUser = db.Users.FirstOrDefault(u => u.Email == user.Email);
            if (existingUser != null)
            {
                ViewBag.AlreadyRegistered = "You already have an account. Please login.";
                return View();
            }

            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View();
        }

        // Login Page
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password, string role)
        {
            if (role == "Admin")
            {
                if (email == "rehmanshaikabdul116@gmail.com" && password == "nationalRJC07@")
                {
                    Session["UserName"] = "Admin"; // Store admin name
                    Session["UserRole"] = "Admin";
                    return RedirectToAction("AdminDashboard", "Admin");
                }
            }
            else
            {
                var user = db.Users.FirstOrDefault(u => u.Email == email && u.Password == password && u.Role == role);
                if (user != null)
                {
                    Session["UserName"] = user.Name; // Store student/faculty name
                    Session["UserRole"] = user.Role;

                    if (role == "Student")
                        return RedirectToAction("StudentDashboard", "Student");

                    if (role == "Faculty")
                        return RedirectToAction("FacultyDashboard", "Faculty");
                }
            }

            ViewBag.Error = "Invalid login credentials";
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear(); // Clears all session data
            return RedirectToAction("Login", "Account"); // Redirects to the login page
        }

    }
}
