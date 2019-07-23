using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值类型参数按值传递 
{
    class Program
    {
        static void Main(string[] args)
        {
            //值类型按值传递情况
            int addSum = 2;
            Add(addSum);
            Console.WriteLine("调用方法后，实参AddSum的值"+addSum);
            Console.Read();

        }
        //值类型按值传递情况
        private static void Add(int addsum)
        {
            addsum = addsum + 1;
            Console.WriteLine("方法中addsum的值："+addsum);
        }
    }
    
}
