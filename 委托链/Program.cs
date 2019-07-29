using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托链
{
    class Program
    {
         DelegateText dtstatic = new DelegateText(Program.Method1);
        static void Main(string[] args)
        {
            //用静态方法实例化委托
           
            //
            DelegateText dtinstance=new DelegateText(new Program().Method2);
            //定义一个委托对象，初始化为空，即不代表任何方法
            DelegateText dtchain = null;
            //使用“+”符号链接委托，链接多个委托后就成了委托链
            dtchain += dtstatic;
            dtchain += dtinstance;
            //调用委托链
            dtchain();
            Console.Read(); 

        }

        public delegate void DelegateText();

        private static void Method1()
        {
            Console.WriteLine("这是静态方法！");
        }

        private void Method2()
        {
            Console.WriteLine("这是实例方法！");
        }

    }
}
