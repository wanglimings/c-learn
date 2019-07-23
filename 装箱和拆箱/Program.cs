using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装箱和拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //
            int i = 3;
            //装箱操作
            object o = i;
            //拆箱操作
            int j = (int) o;
            
        }
    }
}
