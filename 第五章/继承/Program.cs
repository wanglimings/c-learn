using System;
using System.Dynamic;

namespace 封装
{
    class Program
    {

        //static void Main(string[] args)
        //{
        //    Horse horse = new Horse();
        //    horse.Age = 2;
        //    Console.WriteLine("马的年龄为：{0}", horse.Age);
        //    Sheep sheep = new Sheep();
        //    sheep.Age = 1;
        //    Console.WriteLine("羊的年龄为：{0}", sheep.Age);

        //    Console.WriteLine("Hello World!");
        //}
    }

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



    }

    public class Horse : animal
    {

    }

    public class Sheep : animal
    {

    }
}