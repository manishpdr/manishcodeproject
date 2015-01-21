using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abstractclassconstructor
{
    class Program
    {
        static void Main(string[] args)
        {

            savingcustomer sv = new savingcustomer();
            coporatecustomer cp = new coporatecustomer();
            Console.ReadLine();

        }
    }

    public abstract class customer
    {
    
        public customer()
        {
        
         printname();
        }



        public abstract string printname();
    
    }


    public  class  coporatecustomer:customer
    {


        public override string printname()
        {
            return "hii  i am manish";
        }
    
    }

   public  class savingcustomer:customer
    {

       public override string printname()
       {

           return "hiii  am ashvani";
           
       }
    }
}
