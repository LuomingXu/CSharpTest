using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseLib;

namespace CSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CourseAandMtest course1 = new CourseAandMtest()
            {
                Number = 07900039,
                Name = "高级英语阅读",
                TeacherName = "丁金淑",
                CoursePeriod = 3,
                Place = "瑶光C304",
                Grade = 3,
                Time = "3-12周，8,9,10节"
            };

            Console.WriteLine("传递course:" + course1.Test(course1));

            CourseAandMtest course2 = new CourseAandMtest(Console.ReadLine());
            Console.WriteLine(course2.PrintTemp());
            Console.WriteLine(course2.Test("001"));

            CourseAandMtest course3 = new CourseAandMtest("徐络溟")
            {

            };
            Console.WriteLine(course3.PrintTemp());
            Console.WriteLine("请输入十个数");
            
        }
    }
}
