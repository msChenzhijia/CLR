using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[]
            {
                new Point(1,2),
                new Point(2,3)
            };
            if (points[0].CompareTo(points[1])>0)
            {
                Point temPoint = points[0];
                points[0] = points[1];
                points[1] = temPoint;
            }
        }
    }
    internal sealed class Point:IComparable<Point>
    {
        private Int32 m_x, m_y;
        public Point(Int32 x,Int32 y)
        {
            m_x = x;
            m_y = y;
        }
        public Int32 CompareTo(Point p)
        {
            return Math.Sign(Math.Sqrt(m_x * m_x + m_y * m_y) - Math.Sqrt(p.m_x * p.m_x + p.m_y * p.m_y));
        }
        public override string ToString()
        {
            return String.Format($"{m_x},{m_y}");
        }
        #region 泛型接口 
        /*
         泛型接口的好处
         1.提供了出色的编译时类型安全性
         2.处理值的时候减少了装箱和拆箱
         3.一个接口可以多次继承
         4.泛型接口的参数可以标记逆变和协变,为泛型接口的使用提供更大的灵活性
          */
        private void SomeMethod()
        {
            Int32 x = 1, y = 2;
            IComparable c = x;
            //CompareTo期待一个是Object的值,传如Int32的值没问题
            //这里进行了装箱
            c.CompareTo(y);
            //编译没问题,但是运行时出问题
            c.CompareTo("222");
        }
         #endregion
    }
    internal sealed class Number : IComparable<String>, IComparable<Int32>
    {
        public int CompareTo(string other)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(int other)
        {
            throw new NotImplementedException();
        }
    }
    #region 泛型和接口约束

    #endregion

}
