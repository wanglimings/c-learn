using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace 扩展EventArgs类
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化新郎官对象
            Bridegroom bridgroom=new Bridegroom();
            //初始化朋友对象
            Friend friend1 =new Friend("张三");
            Friend friend2 = new Friend("李四");
            Friend friend3=new Friend("王五");

            bridgroom.MarryEvent+=new Bridegroom.MarryHandler(friend1.SendMessage);
            bridgroom.MarryEvent+=new Bridegroom.MarryHandler(friend2.SendMessage);
            bridgroom.OnMarriageComing("朋友们，我要结婚了，到时候参加我的婚礼！");
            Console.Read();
        }
    }

    public class MarryEventArgs : EventArgs
    {
        public string message;

        public MarryEventArgs(string msg)
        {
            message = msg;
        }
    }
    //新郎官类，充当事件发布角色
    public class Bridegroom
    {
        //自定义委托类型，委托包含两个参数
        public delegate void MarryHandler(object sender, MarryEventArgs e);
        //定义事件
        public event MarryHandler MarryEvent;
        //发出事件
        public void OnMarriageComing(string msg)
        {
            if (MarryEvent != null)
            {
                MarryEvent(this,new MarryEventArgs(msg));
            }

        }

    }

    public class Friend
    {
        //字段
        public string Name;
        //构造函数
        public Friend(string name)
        {
            Name = name;
        }
        //事件处理函数，该函数符合MarryHandler委托的定义
        public void SendMessage(Object s, MarryEventArgs e)
        {
            Console.WriteLine(e.message);
            Console.WriteLine(this.Name+"收到了，到时候准时参加");
        }
    }
}

