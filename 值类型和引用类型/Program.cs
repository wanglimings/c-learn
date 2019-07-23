using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值类型和引用类型
{
    class Program
    {
        //valuetype作为引用类型的一部分被分配到托管堆上
        private int valuetype = 3;

        public void method()
        {
            //c被分配到线程堆上
            char c = 'c';
        }

        //static void Main(string[] args)
        //{
        //   Program reftype=new Program();
        //}
    }
}
