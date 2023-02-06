using System;

namespace HW_6._2._2023_Task1
{
    abstract class Animal
    {
        public string Name { get; set; }
        public void Sleep()
        {
            Console.WriteLine("Animals want to sleep");
        }
        public abstract void Eat();  //giao việc định nghĩa cho lớp con kế thừa nó

        protected Animal(string name)
        {
            Name = name;
        }
    }
}
