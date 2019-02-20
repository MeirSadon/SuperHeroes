using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    class Flash : Human, IFlash
    {
        public int Voltagen { get; private set; }
        public override string Name { get; set; }
        public void FireNightNings()
        {
            Console.WriteLine("FireNightNings :)");
        }
        public void ActiveSuperPowers()
        {
            FireNightNings();
        }
        public Flash(string name, int age, int voltagen) : base(name, age)
        {
            Voltagen = voltagen;
        }
        public override string ToString()
        {
            return $"Flash:  ";

        }

    }
}
