using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    /// <summary>
    /// 设计要公开事件的类型
    /// 1:定义类型来容纳所有需要发送给事件通知接收者的附加信息
    /// 类继承EventArgs
    /// 2.定义事件成员
    /// 3.定义负责引发事件的方法来通知事件的登记对象
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    internal class NewMailEventArgs : EventArgs
    {
        private readonly String m_from, m_to, m_subject;

        public string From { get; set; }

        public string To { get; set; }

        public string Subject { get; set; }

        public NewMailEventArgs(String from ,String to,String subject)
        {
            m_from = from;
            m_to = to;
            m_subject = subject;
        }
    }
    internal class MailManager
    {
        public event EventHandler<NewMailEventArgs> NewMail;
    }
    internal sealed class Fax
    {
        //将MailManager对象传给构造器
        public Fax(MailManager mm)
        {
            //构造EventHandler<NewMailEventArgs>委托的一个实例
            //使用它引用我们的FaxMsg回调方法
            //向MailManager的NewMail事件登记我们的回调方法
            mm.NewMail += FaxMsg;
        }
        private void FaxMsg(Object o,NewMailEventArgs e)
        {
            //'sender'表示MailManager,便于将信息传回给它
            //'e'表示表示MailManager对象想传给我们的附加事件信息
        }
    }
}
