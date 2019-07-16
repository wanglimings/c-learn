using System;
using System.Collections.Generic;
using System.Text;

namespace 继承
{
    //(1)初始化类的字段
    //(2)调用基类的构造函数，如果没有基类，则调用system.object的构造函数
    //(3)调用子类的构造函数
    public class Parent
    {
        //初始化父类的构造函数
        public Parent()
        {
            Console.WriteLine("基类的构造函数被调用。");
        }
    }

    public class ChildA : Parent
    {
        //创建一个ChildA对象时，
        //①初始化它的实例字段
        private int fieldA = 2;
        //初始化子类的构造函数
        public ChildA()
        {
            Console.WriteLine("我是子类childA构造函数");
        }

        public void print()
        {
            Console.WriteLine(fieldA);
        }
    }

    //public static class program
    //{
    //    public static void Main(string[] args)
    //    {
    //        //初始化子类
    //        ChildA child=new ChildA();
    //        child.print();
    //        Console.Read();

    //    }
    //}
}
