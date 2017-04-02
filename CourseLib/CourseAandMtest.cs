using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLib
{
    /// <summary>
    /// 课程定义属性+方法
    /// </summary>
    public class CourseAandMtest
    {
        private string _Temp = string.Empty;
        public CourseAandMtest()
        {
           //函数定义的多态性，可以有同名的函数，会根据所输入的数据，自动采用恰当的函数来调用 
        }
        public CourseAandMtest(string Temp)
        {
            _Temp = Temp;
        }
        /// <summary>
        /// 定义传属性递的参数打印
        /// </summary>
        /// <param name="Temp">内部参数</param>
        public string PrintTemp()
        {
            return _Temp;
        }


        //==================================属性===============================
        private int _Number;//课程代码
        private string _Name;//课程名称
        private string _TeacherName;//教师名称
        private int _CoursePeriod;//课时
        private string _Place;//地点
        private int _Grade;//学分
        private string _Time;//上课时间

        /// <summary>
        /// 课程代码
        /// </summary>
        public int Number
        {
            get { return _Number; }
            set { _Number = value; }
        }

        /// <summary>
        /// 课程名称
        /// </summary>
        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }

        /// <summary>
        /// 教师名称
        /// </summary>
        public string TeacherName
        {
            set { _TeacherName = value; }
            get { return _TeacherName; }
        }

        /// <summary>
        /// 课时
        /// </summary>
        public int CoursePeriod
        {
            set { _CoursePeriod = value; }
            get { return _CoursePeriod; }
        }

        /// <summary>
        /// 地点
        /// </summary>
        public string Place
        {
            set { _Place = value; }
            get { return _Place; }
        }

        /// <summary>
        /// 学分
        /// </summary>
        public int Grade
        {
            set { _Grade = value; }
            get { return _Grade; }
        }

        /// <summary>
        /// 上课时间
        /// </summary>
        public string Time
        {
            set { _Time = value; }
            get { return _Time; }
        }



        //===================================方法=======================================
        /// <summary>
        /// 是否等于001
        /// </summary>
        /// <param name="x">内部参数</param>
        /// <returns>回答</returns>
        public string Test(string x)
        {
            if (x.Equals("001"))
                return "是";
            else
                return "否";
        }

        /// <summary>
        /// 依据编号查询名称
        /// </summary>
        /// <param name="course">定义的course</param>
        /// <returns>返回值</returns>
        public string Test(CourseAandMtest course)
        {
            if (course.Number.Equals(Console.ReadLine()))
                return course.Name;
            else
                return "否";
        }
    }
}
