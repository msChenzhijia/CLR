using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTuple类型
{
    class Program
    {
        static void Main(string[] args)
        {
            var minmax=GET(5, 4);
            Console.WriteLine(minmax.Item1.ToString(), minmax.Item2.ToString());
            Console.ReadLine();
            //创建多于8个元素的Tuple
            var tuple = Tuple.Create(0, 1, 2, 3, 4, 5, 6, Tuple.Create(7, 8));
            //下面的写法C#和py这样的动态语言传递ExpandoObject对象
            dynamic e = new System.Dynamic.ExpandoObject();
            e.x = 6;
            e.y = "ss";
            e.z = null;
            //查看所有的属性和值
            foreach (var item in (IDictionary<String,Object>)e)
            {
                Console.WriteLine($"Key={item.Key},Value={item.Value}");                
            }
            Console.ReadLine();
            //删除x属性的值
            var d = (IDictionary<String, Object>)e;
            d.Remove("x");
        }
        public static Tuple<Int32 ,Int32>GET(Int32 a,Int32 b)
        {
            //return new Tuple<Int32, Int32>(Math.Min(a, b), Math.Max(a, b));
            return Tuple.Create(Math.Min(a, b), Math.Max(a, b));
        }
    }
    public class Text
    {
        public String CarNo { set; get; }
        public DateTime time { set; get;}
    }
     
}
