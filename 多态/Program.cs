using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal horse1=new Horse();
            horse1.Voice();
            Animal sheep=new Sheep();
            //相同类型的对象调用相同的方法表现出不同的行为
            sheep.Voice();
            Horse horse2 = new Horse();
            horse2.Eat();
            //调用基类中的eat方法
            ((Animal)horse2).Eat();
            Console.Read();

        }
    }

    public abstract class Animal
    {
        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 0)
                {
                    throw (new ArgumentOutOfRangeException("AgeIntPropery", value, "年龄必须在0-10之间"));
                }

                _age = value;
            }
        }

        public virtual void Voice()
        {
            Console.WriteLine("动物开始发出声音");
        }

        public void Eat()
        {
            Console.WriteLine("动物吃方法！");
        }

    }

    public class Horse : Animal
    {
        public sealed override void Voice()
        {
            //通过base语句调用父类的方法
            base.Voice();
            Console.WriteLine("马发出嘶嘶嘶的声音");
        }

        public new void Eat()
        {
            //使用new关键字进行修饰，从而隐藏了基类中同名成员
            Console.WriteLine("马吃的方法");
        }
    }
    public class Sheep : Animal
    {
        public override void Voice()
        {
            //通过base语句调用父类的方法
            base.Voice();
            Console.WriteLine("羊发出咩咩咩的声音");
        }
    }

    //public class Text : Horse
    //{
    // 编译时出错，因为此时voice在horse中被sealed修饰，定义为密封的。
    //    public override void Voice()
    //    {

    //    }
    //}
}
