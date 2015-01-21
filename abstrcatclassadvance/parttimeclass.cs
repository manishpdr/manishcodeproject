using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abstrcatclassadvance
{
  public    class parttimeclass:baseclass
    {

      
        public int hourlypay { get; set; }
        public int totalhours { get; set; }

       
        public override int monthlysalary()
        {
            return this.totalhours * this.hourlypay;
        }
    }
}
