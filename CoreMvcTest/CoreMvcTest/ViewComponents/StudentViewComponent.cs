using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMvcTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcTest.ViewComponents
{
    //默认的组件名为Student
    public class StudentViewComponent: ViewComponent {

        public IViewComponentResult Invoke(string name)
        {
            var stu = ModelFor.students.Find(it => it.Name == name);
            return View(stu);
        }
    }

    //创建一个视图组件名为ImpStudent，外部显示调用
    public class ImpStudentViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(List<Student> list)
        {
            if((list?.Count??0)<=0)
                list = ModelFor.students.Take(3).ToList();
            //显示指定一个视图名称
            return View("ImpVStudent",list);
        }
    }
}
