using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变量捕捉过程
{
    class Program
    {
        delegate void ClosureDelegate();

        static void Main(string[] args)
        {
            Mathod();
            Console.Read();
        }

        private static void Mathod()
        {
            string outVariable = "外部变量";
            string capturedVarible = "被捕获的外部变量";
            ClosureDelegate cosure = delegate
            {
                string localvariable = "匿名方法局部变量";
                Console.WriteLine(capturedVarible + "   " + localvariable);
            };
            cosure();
        }

    }
}
