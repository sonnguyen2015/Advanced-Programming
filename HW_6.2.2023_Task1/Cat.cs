using System;

namespace HW_6._2._2023_Task1
{
    class Cat : Animal, ICanRun, ICanClimbJump
    {
        public Cat(string name) : base(name)
        {
        }

        public void Climb()
        {
            Console.WriteLine("Cats can climb");
        }

        public override void Eat()
        {
            Console.WriteLine("Cats eat rice, fish and meat");
        }

        public void Jump()
        {
            Console.WriteLine("Cats can jump");
        }

        public void Run()
        {
            Console.WriteLine("Cats can run fast");
        }
    }
}
