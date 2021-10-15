using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public class loops
    {

        public static void forLoop() {


            for  (int i=0; i>=10; i++)
            {
                Console.WriteLine("Odpalilo sie: "+i);
            
            }


        }


        public static void advancedloops()
        {

            List<int> ListaCen = new List<int>() { 120, 6, 1, 778, -2, 34, 23464576, 43534, 5456, 456, 54, 3456, -10, 0, -50 }; // 15

            Console.Out.WriteLine("Ilosc cen w liscie wynosi: "+ListaCen.Count());
            var iloscbledow = 0;
            for (int i = 0; i < ListaCen.Count(); i++)
            {
                if (ListaCen[i] > 0)
                {

                    Console.WriteLine("OK: {0}", ListaCen[i]);
                }
                else
                {
                    Console.WriteLine("ZLE: {0}", ListaCen[i]);
                    iloscbledow++;
        
                }
            }

            Console.WriteLine("-------------");

         


            Console.WriteLine("ILOSC BLEDNYCH CEN WYNOSI: {0}", iloscbledow);
            //RECURRENCE




        }


        public static void whileloop() {
            List<int> ListaCen = new List<int>() { 120, 6, 1, 778, -2, 34, 23464576, 43534, 5456, 456, 54, 3456, -10, 0, -50 }; // 15
            int i = 0;
            var iloscbledow = 0;


            while (iloscbledow < 2)
            {

                if (ListaCen[i] > 0)
                {
                    Console.WriteLine("OK: {0}", ListaCen[i]);
                }
                else
                {
                    Console.WriteLine("ZLE: {0}", ListaCen[i]);
                    iloscbledow++;
                }


                i++;
            }
        }
    }
}
