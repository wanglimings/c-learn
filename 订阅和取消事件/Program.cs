using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace 订阅和取消事件
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //实例化新郎官对象
        //    Brideroom brideroom=new Brideroom();
        //    //实例化朋友对象
        //    Friend friend1=new Friend("张三");
        //    Friend friend2 = new Friend("李四");
        //    Friend friend3 = new Friend("王五");
        //    //使“+=”来订阅事件
        //    brideroom.MarryEvent+=new Brideroom.MarryHarder(friend1.SendMessage);
        //    brideroom.MarryEvent+= new Brideroom.MarryHarder(friend2.SendMessage);
        //    //发出通知，只有订阅了事件的对象才能收到通知
        //    brideroom.OnMarriageComing("朋友们，我结婚了，到时候准时参加婚礼！");

        //    Console.WriteLine("______________________________________");
        //    //使用“-=”来取消订阅事件，此时李四将收不到通知
        //    brideroom.MarryEvent-= new Brideroom.MarryHarder(friend2.SendMessage);
        //    //使用“+=”来订阅事件，此时王五将能收到通知
        //    brideroom.MarryEvent+= new Brideroom.MarryHarder(friend3.SendMessage);
        //    //发出通知
        //    brideroom.OnMarriageComing("朋友们，我要结婚了，到时候准时参加婚礼！");
        //    Console.Read();


        //}
    }

    public class Brideroom
    {
        //自定义委托
        public delegate void MarryHarder(string name);
        //使用自定义委托类型定义事件，事件名称为MarryEvent
        public event MarryHarder MarryEvent;
        //发出事件
        public void OnMarriageComing(string msg)
        {
            if (MarryEvent != null)
            {
                MarryEvent(msg);
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
        //事件处理函数，该函数需要符合MarryHandler委托的定义
        public void SendMessage(string message)
        {
            //输出通知消息
            Console.WriteLine(message);
            //对事件做出处理
            Console.WriteLine(this.Name + "收到了，到时候准时参加！");
        }
        
    }

}
