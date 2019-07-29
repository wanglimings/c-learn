using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lambda表达式的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //新建一个Button实例
            Button button = new Button(){Text = "点击我"};

            //
            button.Click += (sender,e)=>ReportEvent("Click事件", sender, e);
            button.KeyPress += (sender, e) => ReportEvent("keypress事件，即键盘按下事件", sender, e);
            Form form=new Form{Name = "在控制台中创建的窗体",AutoSize = true,Controls = { button}};
            Application.Run(form);
        }
        //记录事件回调的方法
        private static void ReportEvent(string title, object sender, EventArgs e)
        {
            Console.WriteLine("发生的事件为：{0}", title);
            Console.WriteLine("发生事件的对象为{0}", sender);
            Console.WriteLine("发生事件的参数为：{0}", e.GetType());
        }
    }
}
