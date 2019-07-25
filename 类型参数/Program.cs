using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类型参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<,>是一个开放类型，它有两个参数
            Type t = typeof(Dictionary<,>);
            Console.WriteLine("是否为开放类型：" + t.ContainsGenericParameters);
            //DictionaryKey<>是一个开放类型，它只有一个参数
            t = typeof(DictionaryKey<>);
            Console.WriteLine("是否为开放类型：" + t.ContainsGenericParameters);
            //Dictionary<int，int>是一个封闭类型
            t = typeof(Dictionary<int, int>);
            Console.WriteLine("是否为开放类型：" + t.ContainsGenericParameters);
            t = typeof(DictionaryKey<int>);
            Console.WriteLine("是否为开放类型：" + t.ContainsGenericParameters);
        }
    }
    //声明开放泛型类型
    public class DictionaryKey<T> : Dictionary<string, T>
    {

    }
}
