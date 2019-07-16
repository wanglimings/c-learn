using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承接口
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1=new Person();
            p1.Age = 18;
            Person p2=new Person();
            p2.Age = 19;
            if (p1.CompareTo(p2) > 0)
            {
                Console.WriteLine("p1比p2大");
            }

            if (p1.CompareTo(p2) < 0)
            {
                Console.WriteLine("p1比p2小");
            }
            if (p1.CompareTo(p2) == 0)
            {
                Console.WriteLine("p1和p2一样大");
            }

            Console.Read();
        }
       
    }

    public interface ICustomCompare
    {
        int CompareTo(object other);
    }


    public class Person : ICustomCompare
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int CompareTo(object value)
        {
            if (value == null)
            {
                return 1;
            }

            Person otherp = (Person) value;
            if (this.Age < otherp.Age)
            {
                return -1;
            }

            if (this.Age > otherp.Age)
            {
                return 1;
            }

            return 0;
        }
    }
}
