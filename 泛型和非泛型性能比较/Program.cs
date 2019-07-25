using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型和非泛型性能比较
{
    class Program
    {
        static void Main(string[] args)
        {
            Generic();
            NoGeneric();
            Console.Read();
        }

        public static void Generic()
        {
            //用Stopwatch对象来测试运行时间
            Stopwatch stopwatch =new Stopwatch();
            //泛型数组
            List<int> genericList=new List<int>();
            //开始计时
            stopwatch.Start();
            for (int i = 0; i < 100000000; i++)
            {
                genericList.Add(i);
            }
            //结束计时
            stopwatch.Stop();
            //输出所用时间
            TimeSpan ts = stopwatch.Elapsed;
            //使时间以00:00:00输出
            string time=String.Format("{0:00}:{1:00}:{2:00}:{3:00}",ts.Hours,ts.Minutes,ts.Seconds,ts.Milliseconds/10);
            Console.WriteLine("泛型类型运行时间："+time);


        }
        public static void NoGeneric()
        {
            //用Stopwatch对象来测试运行时间
            Stopwatch stopwatch = new Stopwatch();
            //数组
             ArrayList arryList=new ArrayList();

            //开始计时
            stopwatch.Start();
            for (int i = 0; i < 100000000; i++)
            {
                arryList.Add(i);
            }
            //结束计时
            stopwatch.Stop();
            //输出所用时间
            TimeSpan ts = stopwatch.Elapsed;
            //使时间以00:00:00输出
            string time = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds/10);
            Console.WriteLine("非泛型类型运行时间："+time);


        }
    }
}
