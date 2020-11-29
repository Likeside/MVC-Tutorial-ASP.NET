using Microsoft.AspNetCore.Mvc;
using MVC_Tutorial.Models;

namespace MVC_Tutorial.Controllers
{
    public class WebUserController: Controller
    {
        WebUser _webUser = new WebUser(AllUsers.ListOfAllUsers)
        {
            FirstName = "Bob",
            LastName = "Bobson",
            NickName = "Bobby"
        };
        [HttpGet]
        public IActionResult UserInformation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserInformation(WebUser webUser)
        {
            {
                if (ModelState.IsValid)
                {
                    return Content("Thank you!");
                }
                else
                {
                    return View(webUser);
                }
            }
        }
        
     
        
    }
}