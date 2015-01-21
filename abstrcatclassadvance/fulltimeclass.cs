using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abstrcatclassadvance
{
   public class fulltimeclass:baseclass
    {
      
       public int annualsalary { get; set; }

      
       public override int monthlysalary()
       {
       return this.annualsalary / 12;
       }

    }
}
