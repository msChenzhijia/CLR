using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 参数
{
    class Program
    {   /**
         * 隐式类型的局部变量         
         * var 只是一种简化语法只能申明方法内部局部变量
         * dynamic适用于局部变量,字段和参数
         * 表达式不能转var可以转dynamic
         * 
         **/
        static void Main(string[] args)
        {
            //int x;
            //GetVal(out x);
            //Console.WriteLine(x);
            //int x = 5;
            //AddVal(ref x);
            //Console.WriteLine(x);
            //Console.ReadLine();
            FileStream Fs;
            //StartProcessingFiles(out Fs);
            //for (;Fs!=null;ContinueProcessingFile)
            //{

            //}
        }
        /// <summary>
        /// 在使用out的时候方法内部的参数一定要赋值
        /// </summary>
        /// <param name="v"></param>
        private static void GetVal(out Int32 v)
        {
            v = 10;
        }
        private static void AddVal(ref Int32 v)
        {
            v += 10;
        }
        private static void ImplicitlyTypedLocalVariables()
        {
            var name = "jeff";
            ShowVariableType(name);
            //var n = null;//不能将null赋值给隐式类型的局部变量
            var x = (String)null;//可以这么写,但是意义不大
            ShowVariableType(x);
            //复杂类型能少打一些字
            var collection = new Dictionary<String, Single>() { { "A", 5.5f} };

        }
        private static void ShowVariableType<T>(T t)
        {
            Console.WriteLine(typeof(T));
        }
        //private static void StartProcessingFiles(out FileStream fs)
        //{
        //    fs=new FileStream()
        //}
        //参数和返回类型的设计规范
        //1.在申明参数类型的时候,尽可能的使用最弱的类型,宁愿要接口也不要基类
        //2.返回类型的时候一般都是返回最强的类型
    }
}
