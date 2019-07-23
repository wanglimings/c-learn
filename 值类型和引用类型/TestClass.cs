using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值类型和引用类型
{
    public class TestClass
    {
        public int x;
        public int y;
    }

    public struct NestedReTypeInValue
    {
        //定义结构体中的字段，注意结构体中的字段不能被初始化
        public TestClass classInValueType;

        //j结构体中的构造函数，注意  结构体中不能定义无参数的构造函数
        public NestedReTypeInValue(TestClass t)
        {
            if (t == null)
            {
                throw new ArgumentException("t");
            }

            classInValueType = t;
            classInValueType.x = 3;
            classInValueType.y = 4;
        }
    }

    public class Program1
    {
        static void Main(string[] args)
        {
            //值类型的参数
            NestedReTypeInValue nestedReTypeInValue=new NestedReTypeInValue(new TestClass());
            Console.WriteLine(nestedReTypeInValue.classInValueType.x.ToString()+nestedReTypeInValue.classInValueType.y.ToString());
            Console.Read();
        }
    }
}
