using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 空合并操作符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("??运算符的使用如下：");
            NullcoalescingOperator();
            Console.Read();
        }

        private static void NullcoalescingOperator()
        {
            int? nullable = null;
            int? nullhasvale = 1;
            //??和三目运算符的功能差不多
            //所以下面这行代码等价于“x=nullable.HasValue?b.value:12”
            int x = nullable ?? 12;
            int y = nullhasvale ?? 123;
            Console.WriteLine("可空类型没有值的情况：{0}",x);
            Console.WriteLine("可空类型有值的情况：{0}", y);




            //同时??运算符也可以用于引用类型，下面是引用类型的例子
            Console.WriteLine();
            string stringontnull = "123";
            string stringisnull = null;
            string result = stringontnull ?? "345";
            string result1 = stringisnull ?? "789";
            Console.WriteLine("引用类型不为null的情况：{0}",result);
            Console.WriteLine("引用类型为null的情况：{0}", result1);

        }
    }
}
