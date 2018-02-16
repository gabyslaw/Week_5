using Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






public class Tester
{
   static void Main(  )
   {
      Animal[] myAnimals = new Animal[6];
      myAnimals[0] = new Dog( 5, "Okey");
      myAnimals[1] = new Cat( 10, "Ric");
      myAnimals[2] = new Cat( 15, "Ebi");
      myAnimals[3] = new Dog( 20, "Winnie");
      myAnimals[4] = new Dog( 25, "Chuks");
      myAnimals[5] = new Dog(30, "Muna");

      foreach ( Animal theAnimal in myAnimals )
      {
         theAnimal.Speak(  );
         theAnimal.Move(  );
         Console.WriteLine(theAnimal);

         Cat c = theAnimal as Cat;  
         if ( c != null )   
         {
            c.Attr(  );      
         }
      }
        Console.ReadLine();
   }

}