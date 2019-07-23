using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 引用类型参数按值传递
{
    //引用类型按值传递的情况
    public class RefClass
    {
        public int addNum;
    }

 
    class Program
    {
        static void Main(string[] args)
        {
            //引用类型按值传递的情况
            RefClass refclass=new RefClass();
            refclass.addNum = 1;
            //refclass是实参，此时参数为引用类型
            Add(refclass);

            Console.WriteLine("Add调用完成之后的refclass.addNum的值："+refclass.addNum);

            
            //引用类型按值传递的特殊情况
            string str = "Old string";
            ChangeStr(str);
            Console.WriteLine("调用ChangStr之后str的值："+str);
            Console.Read();

        }
        //引用类型按值传递的情况，refClass为形参
        public static void Add(RefClass refClass)
        {
            refClass.addNum +=1;
            Console.WriteLine("调用方法后，refClass.addNum的值：" + refClass.addNum);
        }
        //引用类型按值传递的特殊情况
        public static void ChangeStr(string oldstr)
        {
            oldstr = "New string";
            Console.WriteLine("方法中old string的值"+oldstr);
        }
    }

}
