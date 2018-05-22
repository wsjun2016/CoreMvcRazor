using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMvcTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcTest.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = ModelFor.students;
            return View(students);
        }
    }
}