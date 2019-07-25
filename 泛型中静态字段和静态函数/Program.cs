using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型中静态字段和静态函数
{
    class Program
    {
        static void Main(string[] args)
        {
            //每个封闭泛型类型都会调用其构造函数
            //使用不同类型的实参来实例化泛型实例
            TypeWithStaticField<int>.field = "一";
            TypeWithStaticField<int>.field = "啦啦啦";
            TypeWithStaticField<string>.field = "二";
            TypeWithStaticField<Guid>.field = "三";

            //非泛型类型，其构造函数只会被调用一次
            //对于非泛型类型，此时的field的值只会有一个，每次赋值都会改变原来的值
            NoGenericTypeWithStaticFiles.field = "非泛型静态字段一";
            NoGenericTypeWithStaticFiles.field = "非泛型静态字段二";
            NoGenericTypeWithStaticFiles.field = "非泛型静态字段三";

          NoGenericTypeWithStaticFiles.OutField();
          TypeWithStaticField<int>.OutField();
          TypeWithStaticField<string>.OutField();
          TypeWithStaticField<Guid>.OutField();
          Console.Read();
        }
    }
    //泛型类型，具有一个类型参数
    public static class TypeWithStaticField<T>
    {
        //静态字段
        public static string field;
        //静态构造函数
        static TypeWithStaticField()
        {
            Console.WriteLine("泛型的静态构造函数被调用了，实际类型为："+typeof(T));
        }
        //静态函数
        public static void OutField()
        {
            Console.WriteLine(field+":"+typeof(T).Name);
        }
    }

    public static class NoGenericTypeWithStaticFiles
    {
        //静态字段
        public static string field;
        //静态构造函数
        static NoGenericTypeWithStaticFiles()
        {
            Console.WriteLine("非泛型的构造函数被调用了");
        }
        //静态函数
        public static void OutField()
        {
            Console.WriteLine(field+":"+field.GetTypeCode());
        }
    }
}
