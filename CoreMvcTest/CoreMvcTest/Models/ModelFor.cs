using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcTest.Models
{
    public class ModelFor
    {
        public static List<Student> students = new List<Student> {
            new Student{Name="张三",Birthday=Convert.ToDateTime("2001-03-01")},
             new Student{Name="李四",Birthday=Convert.ToDateTime("2002-05-03")},
              new Student{Name="王五",Birthday=Convert.ToDateTime("2011-03-05")},
               new Student{Name="赵六",Birthday=Convert.ToDateTime("2001-08-01")},
                new Student{Name="孙琦",Birthday=Convert.ToDateTime("2007-02-12")},
        };
    }

    public class Student
    {
        [Display(Name ="姓名",Description ="姓名字段")]
        public string Name { get; set; }
        [Display(Name="生日",Description ="生日字段")]
        public DateTime Birthday { get; set; }
        
    }
}
