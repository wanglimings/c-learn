using System;
using System.Collections.Generic;
using System.Text;

namespace 继承
{
    public class animal
    {
        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("AgeIntPropery", value, "年龄必须在0到10之间！");
                }

                _age = value;
            }
        }

        public virtual void Voice()
        {
            Console.WriteLine("动物开始发出声音");
        }



    }
    //马（子类）应重写基类的方法，以实现自己特有的行为
    public class Horse : animal
    {
        //通过override关键字重写父类方法
        public override void Voice()
        {
            base.Voice();
            Console.WriteLine("马发出嘶嘶嘶的声音！");
        }

    }

    public class Sheep : animal
    {
        public override void Voice()
        {
            Console.WriteLine("羊发出咩咩咩的声音！");
            base.Voice();
        }

    }
    public static class program
    {
        public static void Main(string[] args)
        {
            //初始化子类
            animal horse=new Horse();
            horse.Voice();
            animal sheep=new Sheep();
            sheep.Voice();
 
        }
    }
}
 
