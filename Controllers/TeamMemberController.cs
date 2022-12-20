using Assessment8.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assessment8.Controllers
{
    public class TeamMemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddForm()
        {
            return View();
        }

        //Need to Fix Date
        public IActionResult Add(TeamMember tm)
        {
            bool isValid = true;
            if (tm.FirstName == null)
            {
                ViewBag.NameMessage = "Name is required, at least 1 character. Try again.";
                isValid = false;
            }
            if (tm.LastName == null)
            {
                ViewBag.NameMessage = "Name is required, at least 1 character. Try again.";
                isValid = false;
            }
            if (tm.EmailAddress == null || tm.EmailAddress.Contains("@") == false)
            {
                ViewBag.EmailMessage = "Email is required and must contain @.";
                isValid = false;
            }
            if (isValid)
            {
                DAL.AddTM(tm);
                return View(tm);
            }
            else
            {
                ViewBag.FirstName = tm.FirstName;
                ViewBag.LastName = tm.LastName;
                ViewBag.EmailAddress = tm.EmailAddress;
                ViewBag.Guest = tm.GuestName;
                return View("AddForm");
            }
        }
    }
}
