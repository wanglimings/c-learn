using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace 显式实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            Speaker person=new Speaker();
            IChineseGreeting iChineseGreeting = (IChineseGreeting)person;
            iChineseGreeting.Greeting();
            IAmericanGreeting iAmericanGreeting = (IAmericanGreeting) person;
            iAmericanGreeting.Greeting();
            Console.Read();

        }

        interface IChineseGreeting
        {
            void Greeting();
        }
        interface IAmericanGreeting
        {
            void Greeting();
        }
        public class Speaker:IChineseGreeting,IAmericanGreeting
        {
            //显式实现接口
            void IChineseGreeting.Greeting()
            {
                Console.WriteLine("你好！");
            }

            void IAmericanGreeting.Greeting()
            {
                Console.WriteLine("hello！");
            }
        }
    }

 
}
