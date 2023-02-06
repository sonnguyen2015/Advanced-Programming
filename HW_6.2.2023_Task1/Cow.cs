using System;

namespace HW_6._2._2023_Task1
{
    class Cow : Animal, ICanRun
    {
        public Cow(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Cows eat grasss");
        }

        public void Run()
        {
            Console.WriteLine("Cows can run slowly");
        }
    }
}
