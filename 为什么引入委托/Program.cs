using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 为什么引入委托
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p=new Program();
            p.Greeting("李志",p.ChineseGreeting);
            p.Greeting("Tommy Li",p.EnglishGreeting);
            Console.Read();
        }

        public delegate void GreetingDelegate(string name);//定义委托类型
        //有了委托之后可以像下面这样实现打招呼
        public void Greeting(string name, GreetingDelegate callback)
        {
            //调用委托
            callback(name);
        }

        public void EnglishGreeting(string name)
        {
            Console.WriteLine("Hello， "+name);
        }
        public void ChineseGreeting(string name)
        {
            Console.WriteLine("你好！ " + name);
        }
    }
}
