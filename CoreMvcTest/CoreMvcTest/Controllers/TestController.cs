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

        public IActionResult TurnTo (){
            //TempData用来在不同Action之间传递数据，就像Session一样，其实TempData内部也是用Session来存储传递数据
            //TempData的数据取出一次，第二次就取不了了，如果还希望能继续取数据，则当前可以使用TempData.Peek来取值，则下一次还能取出数据
            TempData["Test"] = "hello";
            return RedirectToAction("Turnto", "HtmlHelperTest");
        }

        public IActionResult Receive()
        {
            return View();
        }
    }
}