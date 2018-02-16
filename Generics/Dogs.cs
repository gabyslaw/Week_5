using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
     public class Dog : Animal
    {
        private string type;

        public string Breed
        {
            get { return type; }
            set { type = value; }
        }
         public Dog (int weight, string name, string type):
         base(weight,name)
            {
                this.type = type;
             }

        public Dog(int weight, string name) : base(weight, name)
        {
        }

        public override void Speak(  )
            {  Console.WriteLine ("Bark"); }

        public override void Move (  )
    { Console.WriteLine ("fly away");  }

     public override string  ToString(  )
        {
      return "My name is " + this.name + " I weigh " + this.weight +
      " and I am a " + this.type + "\n";
        }
        }

}
