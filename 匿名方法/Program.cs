using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 匿名方法
{
    class Program
    {
        delegate void MyDelegate(string name);
        static void Main(string[] args)
        {
            MyDelegate myDelegate=new MyDelegate(new Friend().vote);
            //隐式实例化委托，它把方法直接赋值给了委托实例
            //MyDelegate myDelegate=new Friend().vote();
            myDelegate("未用匿名方法");
            //使用匿名方法实例化委托对象
            MyDelegate myDelegate1= delegate(string nickname)
            {
                Console.WriteLine("昵称为：{0}来帮learning hard来投票了，", nickname);
            };
            myDelegate1("someboday");
            Console.Read();
        }
        //委托的方式
        public class Friend
        {
            public void vote(string nickname)
            {
                Console.WriteLine("昵称为：{0}来帮learning hard来投票了，",nickname);
            }
            
        }
    }
}
