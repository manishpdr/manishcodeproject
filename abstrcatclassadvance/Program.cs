using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abstrcatclassadvance
{
    class Program
    {
        static void Main(string[] args)
        {  

            fulltimeclass fte = new fulltimeclass() {
                  firstname="ashvani",
                  lastname= "pundir",
                  annualsalary=3200
                 
            };
            Console.WriteLine(fte.getfullname());
            Console.WriteLine(fte.monthlysalary());

            parttimeclass pte = new parttimeclass() 
            
            {
                firstname = "akshay",
                lastname = "kumar",
                hourlypay = 1000,
                totalhours=20
            
            
            };

            Console.WriteLine(pte.getfullname());
            Console.WriteLine(pte.monthlysalary());

            Console.ReadLine();
           








                
                
                
                
              

        }
    }
}
