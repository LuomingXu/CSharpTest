using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputMaxMin
{
    public class MaxMin
    {
        private int max = 0;

        private int _One;
        private int _two = 0;
        private int _three = 0;
        private int _four = 0;
        private int _five = 0;
        private int _six = 0;
        private int _seven = 0;
        private int _eight = 0;
        private int _nine = 0;
        private int _ten = 0;

        public int One
        {
            set { _One = value; }
            get { return _One; }
        }

        public int Two
        {
            set { _two = value; }
            get { return _two; }
        }

        public int Three
        {
            set { _three = value; }
            get { return _three; }
        }
        public int Four
        {
            set { _four = value; }
            get { return _four; }
        }
        public int Five
        {
            set { _five = value; }
            get { return _five; }
        }
        public int Six
        {
            set { _six = value; }
            get { return _six; }
        }
        public int Seven
        {
            set { _seven = value; }
            get { return _seven; }
        }
        public int Eight
        {
            set { _eight = value; }
            get { return _eight; }
        }
        public int Nine
        {
            set { _nine = value; }
            get { return _nine; }
        }
        public int Ten
        {
            set { _ten = value; }
            get { return _ten; }
        }



        /// <summary>
        /// 是个数比较
        /// </summary>
        /// <param name="number">十个数的定义</param>
        /// <returns>最大值</returns>
        public int Max(MaxMin number)
        {
            max = number.One;
            if (max<number.Two)
            {
                max = number.Two;
            }
            else
            {

            }
            return max;
        }
    }
}
