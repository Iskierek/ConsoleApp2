using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace ConsoleApp2
{
     public class Person
    {
        static int wzrost = 180;
        static string imie ="Michal Jan pierwszy najlepszy", nazwisko;
        static char litera ='c';



        static void WalkForward() { 
        
        // IDz do przodu
        }

        public static void WalkBAckword()
        { 
            int dlugoscnogi = 50;
            int numberofsteps = 20;

            Console.WriteLine(dlugoscnogi * numberofsteps);
     
        }

        public static void Talk()
        {
       
        }

        public static void SayYouName() {

            Console.WriteLine(imie);
        }

    }
}
