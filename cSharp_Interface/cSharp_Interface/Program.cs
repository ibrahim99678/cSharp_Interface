using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Interface : Define a contract that all the classes inheriting from should follow :

            //              An interface declares "What a class should have"
            //              An inheruting class defines "how it should do it"
            //              Benefit = Security + multiple inheritance + "Plug and Play" 

           
            Rabbit rabbit = new Rabbit();
            Hwak hwak = new Hwak();
            Fish fish = new Fish();

            fish.hwak();
            fish.flee();

            //hwak.Hunt();

           // Console.WriteLine(rabbit.ToString());

            //rabbit.flee();


            Console.ReadKey();
             

        }
        interface IPrey
        {
            void flee();
        }
        interface IPredator
        {
            void Hunt();
        }
        class Rabbit
        {
            public void flee()
            {
                Console.WriteLine("Rabbit is Running");
            }

        }
        class Hwak : IPredator
        {
           public void Hunt()
            {
                Console.WriteLine("The Hwak is searching for food!!");
            }
        }
        class Fish: IPrey , IPredator
        {
            public void flee()
            {
                Console.WriteLine("The Fish is securityz less here");
            }

            public void Hunt()
            {
                throw new NotImplementedException();
            }

            public void hwak()
            {
                Console.WriteLine("Here we are using Two interfaces at onece method!!");
            }
        
            
        }
    }
}
