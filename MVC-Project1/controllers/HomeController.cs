 using Microsoft.AspNetCore.Mvc;
using MVC_Project1.controller;

namespace MVC_Project1.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //    //C# HTML 

            //    Movies movie = new Movies()
            //    {
            //        Id = 10,
            //        Name="a"



            //    };
            //    return View("IndexOfHome");
              return View();
        }
        public IActionResult AboutUs()
        {

            return View();


        }

        public IActionResult Privacy()
        {

            return View();


        }




    }
}
