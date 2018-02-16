using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Dog
    {
        public string dogName { get; set; }
        public override string Equals(string data)
        {
            if (data == null)
            {
                return false;
            }
            Dog bingo = new Dog();

            return (this.dogName == Muna.dogname);
        }
        
    }
}
