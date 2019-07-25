using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型类型参数约束
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    //引用类型约束   T:class
    public class Samplereference<T> where T : Stream
    {
        public void Test(T stream)
        {
            stream.Close();
        }
    }
    //值类型约束  T:struct
    public class SampleValueType<T> where T : struct
    {
        public static T Test()
        {
            return new T();
        }
    }

}
