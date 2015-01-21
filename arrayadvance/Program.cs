using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arrayadvance
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] array = new object[3];
            b obj = new b();
            obj.id = 1;
            obj.name = "ashvani@";
            array[0] = 1;
            array[1] = "manish pundir rana";
            array[2] = obj;


            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j]);

            }
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = i + 10;
            //}


            //for (int j = 0; j < 100; j++)
            //{
            //    Console.WriteLine(j + " => " + array[j]);

            //}
            Console.ReadLine();
        }
    }

    public class b
    {
        public int id { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return this.name;
        }


    
    }
}
