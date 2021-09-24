
using ConsoleApp2.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace ConsoleApp2
{
    public class Program
    {

        int number = 5;

        static void Main(string[] args)
        {

            List<int> ListaCen = new List<int>() { 120, 6, 1, 778, -2, 34, 23464576, 43534, 5456, 456, 54, 3456, -10, 0, -50 }; // 15

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

            int z = 0;

            while (iloscbledow < 100) 
            {

                if (ListaCen[z] > 0)
                {
                    Console.WriteLine("OK: {0}", ListaCen[z]);
                }
                else
                {
                    Console.WriteLine("ZLE: {0}", ListaCen[z]);
                    iloscbledow++;
                }


           
            }


            Console.WriteLine("ILOSC BLEDNYCH CEN WYNOSI: {0}", iloscbledow);
            //RECURRENCE




        }


    }
}