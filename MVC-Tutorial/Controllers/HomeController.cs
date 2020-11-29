using System;
using Microsoft.AspNetCore.Mvc;
using MVC_Tutorial.Models;

namespace MVC_Tutorial.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            Models.Movie movie = new Movie()
            {
                Title = "The Godfather",
                ReleaseDate = new DateTime(1972, 3, 24)
            };
            return View();
        }
    }
}