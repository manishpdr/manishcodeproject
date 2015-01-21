using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jaggedarray
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] printingarray = new string[3];
            printingarray[0] = "manish record";
            printingarray[1] = "ashvani record";
            printingarray[2] = "rajnis";


            string[][] jaggedarray = new string[3][];
            jaggedarray[0] = new string[2];
            jaggedarray[1] = new string[3];
            jaggedarray[2] = new string[1];

            jaggedarray[0][0] = "becholrs";
            jaggedarray[0][1] = "masters";
           
            jaggedarray[1][0] = "manish";
            jaggedarray[1][1] = "delhi";
            jaggedarray[1][2] = "bombay";
         

            jaggedarray[2][0] = "becholrs";
            
            for (int i = 0; i < jaggedarray.Length; i++)
            {
                Console.WriteLine(printingarray[i]);

                string[] inneraray = jaggedarray[i];

                for (int j = 0; j < inneraray.Length; j++)
                {

                    Console.WriteLine(inneraray[j]);
                
                
                }

               
            
            }
            Console.ReadLine();
            


     





        }
    }
}
