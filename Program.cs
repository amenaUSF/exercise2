using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int height;
            //max heart rate is equal to 220 - age

            age = 29;
            height = 60;

            Console.WriteLine("I am " + age + " years old, my max heart rate is " + (220 - age) + " and I am " + height + " inches tall");
            
        }
    }
}
