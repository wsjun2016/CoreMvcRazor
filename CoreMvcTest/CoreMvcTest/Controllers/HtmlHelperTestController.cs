using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMvcTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcTest.Controllers
{
    public class HtmlHelperTestController : Controller
    {
        public IActionResult Index()
        {
            
            List<Student> students = ModelFor.students;
            return View(students);
        }

        public IActionResult Turnto()
        {            
            TempData.TryGetValue("Test",out object test) ;
            return RedirectToAction("Receive", "Test");
        }
    }
}