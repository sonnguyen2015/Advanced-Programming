using System;

namespace HW_6._2._2023_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("kitty");
            cat1.Run();
            cat1.Eat();
            cat1.Climb();
            Console.Read();
        }
    }
}
