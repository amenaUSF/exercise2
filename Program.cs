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
            int heart_rate = 220 - age;

            Console.WriteLine("I am " + age + " years old, my max heart rate is " + heart_rate + " and I am " + height + " inches tall");
            
        }
    }
}
