using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    class SpiderMan : Human, IClimb
    {
        public int Webleft { get; private set;}
        public SpiderMan(string name, int age, int webleft) : base(name, age)
        {
            Name = name;
            Webleft = webleft;
        }

        public override string Name { get; set; }

        public void ActiveSuperPowers()
        {
            Climb();
        }

        public void Climb()
        {
            Console.WriteLine($"SpiderMan { Name} is climing");
        }
    }
}
