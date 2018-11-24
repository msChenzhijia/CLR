using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 约束
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var sl=new  PrimaryConstraintOfStram<FileStream>();
            
        }
        

        #region 次要约束
        private static List<TBase> ConverIList<T, TBase>(IList<T> list) where T : TBase
        {
            List<TBase> baseList = new List<TBase>(list.Count);
            for (Int32 index = 0; index < list.Count; index++)
            {
                baseList.Add(list[index]);
            }
            return baseList;
        }

        public static void CallingConverIList()
        {
            //构造并初始化List<String>(它实现了IList<String>)
            IList<String> ls = new List<String>();
            ls.Add("A String");
            //将IList<String>转换成一个IList<Object> String是Object的派生类
            IList<Object> lo = ConverIList<String, Object>(ls);
            //将IList<String>转换成IList<IComparable>   String继承了IComparable
            IList<IComparable> lc = ConverIList<String, IComparable>(ls);
            //将IList<String>转换成一个IList<IComparable<String>>String继承了IComparable
            IList<IComparable<String>> lcs = ConverIList<String, IComparable<String>>(ls);
            //将IList<String>转换成一个IList<<String>返回同一个类型
            IList<String> ls2 = ConverIList<String, String>(ls);
            //将IList<String>转换成一个IList<<Exception>String 和Exception没任何关系
            //IList<String> le = ConverIList<String, Exception>(ls);错误

        }
        #endregion

    }
    #region 主要约束
    /// <summary>
    /// T要么是Stream或是Stram的派生类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal sealed class PrimaryConstraintOfStram<T> where T : Stream
    {
        public void M(T stream)
        {
            stream.Close();
        }
    }
    internal sealed class PrimaryConstraintOfClass<T>where T : class
    {
        T temp = null;
    }
    internal sealed class PrimaryConstraintOfStruct<T>where T : struct
    {
        public static T Factory()
        {
            return new T();
        }
    }
    #endregion
    #region  构造器约束

    #endregion
    
}
