using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 转换操作符方法
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Rational r1 = 1;
        }
    }
    /// <summary>
    /// CLR规范要求转换操作符重载方法必须时public 和static
    /// </summary>
    public sealed class Rational
    {
        /// <summary>
        /// 由一个Int32构造一个Rational
        /// </summary>
        /// <param name="x"></param>
        public Rational(Int32 x)
        {
            
        }
        //public Int32 ToInt32(Int32 X)
        //{
        //    return X;
        //}
        /// <summary>
        /// implicit关键字是告诉编译器位了生成代码来调用方法的,不需要在调用的时候进行显示转换
        /// explicit关键字告诉编译器只有在发现了显示转型时,才调用方法
        /// operator关键字告诉编译器该方法时一个转换操作符
        /// </summary>
        /// <param name="X"></param>
        public static implicit operator Rational(Int32 X)
        {
            return new Rational(X);
        }
    }
}
