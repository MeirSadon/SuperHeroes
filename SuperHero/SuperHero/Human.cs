using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    abstract class Human
    {
        public abstract string Name { get; set; }
        private int age;

        public int Age
        {
            get
            {
                return this.age;
            }
        }
        public Human(string name, int age)
        {
            Name = name;
            this.age = age;
        }
        public override string ToString()
        {
            return $"Name is: {Name}. Age is: {Age}";
        }
    }
}
