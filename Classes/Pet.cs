using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KESCHA.Classes
{
    public class Pet : Animal
    {
        public Pet(string name, int age )
        : base(name, age)
        {
        }
        public override void Greet(string userName)
        {
            System.Console.WriteLine($"Meow {userName}");
        }
    }
}