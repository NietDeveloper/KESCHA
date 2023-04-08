using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KESCHA.Classes
{
    public class Bird : Animal
    {
        public Bird(string name, int age)
        : base(name, age)
        {
        }
        public override void Greet(string userName)
        {
            System.Console.WriteLine($"hello {userName}");
        }
    }
}