using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace 值类型参数按引用传递
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1; 
            ChangeValue(ref num);
            Console.WriteLine(num);
            string str = "old string";
            ChangeByRef(ref str);
            Console.WriteLine(str);
            Console.Read();

        }

        //1.值类型参数按引用传递
        private static void ChangeValue(ref int numValue)
        {
            numValue = 10;
            Console.WriteLine(numValue);
        }
        //2.引用类型参数按引用传递
        private static void ChangeByRef(ref string numRef)
        {
            numRef = "new string";
            Console.WriteLine(numRef);
        }
    }
}
