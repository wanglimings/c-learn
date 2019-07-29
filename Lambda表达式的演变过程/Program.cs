using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lambda表达式的演变过程
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lambda表达式的演变过程
            //下面是C#1.0中穿件委托实例的代码
            Func<string,int> delegatetext1=new Func<string, int>(Callbackmethod);
            //
            //C#2.0中匿名方法来创建委托实例，此时就不需要去额外定义回调方法callbackmethod了
            Func<string, int> delegatetext2 = delegate(string text) { return text.Length; };
            //c#3.0中使用Lambda表达式来创建委托实例
            Func<string, int> delegatetext3 = (string text) => text.Length;
            //
            //可省略参数类型string
            Func<string, int> delegatetext4 = (text) => text.Length;
            //
            //此时也可以把圆括号省略
            Func<string, int> delegatetext5 = text => text.Length;
            Console.WriteLine("使用Lambda表达式返回字符串的长度："+delegatetext5("learning hard"));
            Console.Read();

        }

        private static int Callbackmethod(string text)
        {
            return text.Length;
        }
    }
}
