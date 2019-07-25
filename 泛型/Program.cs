using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    class Program
    {
        static void Main(string[] args)
        {
            //用int作为实际参数来初始化泛型类型
            List<int> intList=new List<int>();
            //int列表添加元素1
            intList.Add(1);
            //用string作为实际参数初始化泛型类型
            List<string> stringList=new List<string>();
            //string列表添加元素learning
            stringList.Add("learning");
            Console.WriteLine(Compare<int>.CompareGeneric(3,4));
            Console.WriteLine(Compare<string>.CompareGeneric("name","aame"));
            Console.Read();
        }
   
    }
    //Compare<T>为泛型类，其中T为类型参数
    public class Compare<T> where T:IComparable
    {
        public static T CompareGeneric(T t1, T t2)
        {
            if (t1.CompareTo(t2) >= 0)
            {
                return t1;
            }
            else
            {
                return t2;
            }
        }
    }

}
