using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Cat : Animal
    {

        public Cat(int weight, string name) :
        base(weight, name)
        { }

        public override void Speak()
        { Console.WriteLine("sing"); }

        public override void Move()
        { Console.WriteLine("Fly over the moon"); }

        public override string ToString()
        {
            return "My name is " + this.name + " I weigh " + this.weight +
            " and I know how to purr!\n";
        }

        public void Attr()
        {
            Console.WriteLine("......");
        }

    }
}
