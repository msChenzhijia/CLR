using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 参数
{
    class Program
    {   /**
         * 隐式类型的局部变量         
         **/
        static void Main(string[] args)
        {
            
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
       
    }
}
