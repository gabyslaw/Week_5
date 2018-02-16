using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    abstract public class Animal
    {
        private int weight;
        private string name;
        public Animal(int weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }
        abstract public void Speak();
        abstract public void Move();
        public override string ToString()
        {
            return("Error 999!!!");
        }
    }

}
