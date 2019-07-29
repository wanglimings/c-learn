using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 可空类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //下面的代码也可以定义为int？ value=1;
            Nullable<int> value = 1;
            Console.WriteLine("可空类型的输出情况：");
            Display(value);
            Console.WriteLine();
            Console.WriteLine();
            value =new Nullable<int>();
            Console.WriteLine("可空类型没有值的情况下输出情况");
            Display(value);
            Console.Read();


        }
        //输出方法，演示可空类型中的方法和属性的使用
        private static void Display(int? nullable)
        {
            Console.WriteLine("可空类型是否有值：{0}", nullable.HasValue);
            if (nullable.HasValue)
            {
                Console.WriteLine("值为：{0}", nullable.Value);


            }
            Console.WriteLine("GetValueOrDefault()方法的使用：{0}", nullable.GetValueOrDefault());
            //GetValueOrDefault(T)方法代表如果HasValue属性为True，则为value属性值；
            //否则为DefaultValue的参数值，即为2
            Console.WriteLine("GetValueOrDefault()重载方法的使用：{0}", nullable.GetValueOrDefault(2));
            //GetHashCode()代表如果HasValue属性为True，则为Value属性返回对象的哈希代码；
            //如果HasValue属性为False则为0；
            Console.WriteLine("GetHashCode()方法的使用：{0}", nullable.GetHashCode());

        }
    }

}
