using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 分部方法
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    #region 缺点：1.这样写类时非密封类，不能用于值类型，不能用在静态方法  2.效率问题

    internal class Base
    {
        private String m_name;
        protected virtual void OnNameChaning(String value)
        {

        }
        public String Name
        {
            get
            {
                return m_name;
            }
            set
            {
                OnNameChaning(value.ToUpper());
                m_name = value;
            }
        }
    }
    internal class Derived : Base
    {
        protected override void OnNameChaning(string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("value");
            }
        }
    }


    /**
     * 注意:
     * 分部方法的返回类型始终都是void,任何参数都不能用out修饰符来标记,可以用ref,可以是泛型，可以是实例或者静态方法,而且可标记位unsafe
     * 分部方法的申明和实现必须具有完全一致的签名
     * 分部方法总是被视为private,但是C#禁止在分部方法前面添加private
     * ===================================================
     * 以下是分部方法的写法     
     * 类是密封类,类可以是静态类,也可以值类型
     * 工具和开发者所生成的代码真的是一个类型定义的两个部分
     * 工具类生成的代码包含部分方法的声明,要用partial关键字标记,无主体
     * 开发者生成的代码包含部分方法的声明,也要用partial关键字标记,有主体
    **/
    internal sealed partial class Base1
    {
        private String m_name;
        partial void OnNameChanging(String value);
        public String Name
        {
            get
            {
                return m_name;
            }
            set
            {
                OnNameChanging(value.ToUpper());
                m_name = value;
            }
        }
    }
    internal sealed partial class Base1
    {
        partial void OnNameChanging(string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(value);
            }
        }
    }
    #endregion
}
