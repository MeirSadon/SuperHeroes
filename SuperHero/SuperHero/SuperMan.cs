using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    class SuperMan : Human, IFly
    {
        public int Speed {get; private set;}
        public override string Name { get; set; }
        public SuperMan(string name, int age, int speed) : base(name,age)
        {
            Name = name;
            Speed = speed;
        }

        public void ActiveSuperPowers()
        {
            Fly();
        }

        public void Fly()
        {
            Console.WriteLine($"SuperMan {Name} Is Flying!");
        }
    }
}
