using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace 扩张方法
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int c = sb.IndexOf('X');
            "AAA".ShowItem();
            new[] { "陈", "Song" }.ShowItem();
            new List<Int32> { 1, 2, 3 }.ShowItem();
            
        }
    }
    /// <summary>
    /// 拓展类型
    /// C#只支持拓展方法,不支持拓展属性,拓展事件,拓展操作符等等
    /// 拓展方法（第一个参数面前由this的方法）必须在非泛型的静态类中声明
    /// 最少有一个参数，第一个参数只能用this关键字标记
    /// C#编译器在静态类中查找拓展方法时 ,要求静态类本身必须具有文件作用域
    /// </summary>
    public static class StringBuilderExtensions
    {
        public static Int32 IndexOf(this StringBuilder sb,Char value)
        {
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i]==value)
                {
                    return i;
                }
               
            }
            return -1;
        }
        /// <summary>
        /// 接口类型定义扩展方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable"></param>
        public static void ShowItem<T>(this IEnumerable<T> enumerable)
        {
            foreach (var item in enumerable)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }
        }
        /// <summary>
        /// 委托类型定义拓展方法
        /// </summary>
        /// <typeparam name="TException"></typeparam>
        /// <param name="action"></param>
        /// <param name="o"></param>
        public static void InvokeAndCatch<TException>(this Action<Object> action,Object o)where TException:Exception
        {
            try
            {
                action(o);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
