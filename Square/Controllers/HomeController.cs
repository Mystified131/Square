using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Square.Models;
using Square.ViewModels;

namespace Square.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    
        public IActionResult Result()
        {
            ResultViewModel resultViewModel = new ResultViewModel();

            resultViewModel.Error = "There is no value to asses the square's area. Please return to the Home page.";

            return View(resultViewModel);
        }

        [HttpPost]
        public IActionResult Result(ResultViewModel resultViewModel)

        {
            if (ModelState.IsValid)
            {

                Squareshape qbert = new Squareshape("qbert", resultViewModel.sidelength);

                resultViewModel.Area = qbert.Area(resultViewModel.sidelength);
                resultViewModel.Perimeter = qbert.Perimeter(resultViewModel.sidelength);

                return View(resultViewModel);
            }

            return Redirect("/");
        }

    }





}
