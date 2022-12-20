using Microsoft.AspNetCore.Mvc;
using Assessment8.Models;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Linq;

namespace Assessment8.Controllers
{
    public class DishController : Controller
    {
        public IActionResult Index()
        {
            List<Dish> dishes = DAL.GetAllDishes();
            return View(dishes);
        }

        public IActionResult AddForm()
        {
            return View();
        }

        public IActionResult Add(Dish dish)
        {
            bool isValid = true;
            if(dish.TMName == null)
            {
                ViewBag.TMNameMessage = "*TM Name is required. Try again.";
                isValid = false;
            }
            if (dish.DishName == null || dish.DishName.Count() < 2)
            {
                ViewBag.DishNameMessage = "*Name is required, and at least 2 characters. Try Again.";
                isValid = false;
            }
            Regex validatePhoneNumberRegex = new Regex(@"^\d{3}-\d{3}-\d{4}$");
            bool validPhone = validatePhoneNumberRegex.IsMatch(dish.PhoneNumber); // returns True
            if (validPhone == false)
            {

                isValid = false;
                ViewBag.PhoneMessage = "*Please enter phone number as 111-111-1111 format. Try again.";
            }
            if (isValid)
            {
                DAL.AddDish(dish);
                return View(dish);
            }
            else
            {
                
                ViewBag.TMName = dish.TMName;
                ViewBag.PhoneNumber = dish.PhoneNumber;
                ViewBag.DishName = dish.DishName;
                ViewBag.DishDescription = dish.DishDescription;
                ViewBag.Category = dish.Category;
                return View("AddForm");
            }
        }

        // Delete Dish
        public IActionResult Delete(int Id)
        {
            DAL.DeleteDish(Id);
            return Redirect("/dish");
        }

        //Edit a Dish
        public IActionResult EditForm(int Id)
        {

            return View(DAL.GetOneDish(Id));
        }
        public IActionResult SaveChanges(Dish dish)
        {
                DAL.UpdateDish(dish);
                return Redirect("/dish");
        }

    }
}
