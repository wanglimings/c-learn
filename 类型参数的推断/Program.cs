using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类型参数的推断
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1;
            int n2 = 2;
            //不使用类型推断的代码
            GenericMathod<int>(ref n1,ref n2);
            //使用类型推断的代码
            GenericMathod(ref n1,ref n2);

            string str1 = "123";
            object obj = "456";
            //使用类型推断时可能出现的
           // GenericMathod(ref str1, ref obj);
            Console.Read();
        }

        public static void GenericMathod<T>(ref T t1, ref T t2)
        {
            T temp = t1;
            t1 = t2;
            t2 = temp;
        }
    }

}
