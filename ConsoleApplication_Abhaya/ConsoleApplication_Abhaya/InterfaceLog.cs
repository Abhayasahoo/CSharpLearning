using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Abhaya
{
       public class Mammal
        {
           /// protected string Characteristis;
           /// Auto-implemented property
            public string characteristics { get; set; }
            
           }
   interface IIntelligence
            {
                /// Interface method declaration
                bool intelligent_behavior();
            }
 
   class Human : Mammal, IIntelligence
            {
                public Human()
                {
                    characteristics = "Human are mammals";
                }

                /// Interface method definition in the class that implements it
                public bool intelligent_behavior()
      {
         Console.WriteLine("{0} and have intelligence",characteristics);
            return true;
      }
        }
   class Whale : Mammal
        {
            public Whale()
            {
                characteristics = "Whales are mammals";
                Console.WriteLine("{0}", characteristics);
            }
        }
    class InterfaceApp
    {
        public static void Main_Bkp(string[] args)
        {
            Whale whale = new Whale();
            Console.WriteLine("And Now Some More Mammals");

            IIntelligence humanIQ = new Human();
            /// The below could be done as well. First instantiate Human object and then cast it to Interface type
            ///          Human human = new Human();
            /// The human object is casted to the interface type
            ///IIntelligence humanIQ = (IIntelligence)human;
            humanIQ.intelligent_behavior();

            Console.Read();
        }
    }
}
