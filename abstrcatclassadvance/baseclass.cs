using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abstrcatclassadvance
{
    public abstract class baseclass
    {

        public int id { get; set; }
        public string firstname { get; set; }

        public string lastname { get; set; }
        public string getfullname()
        {
            return this.firstname + "" + this.lastname;
        }

        public abstract int monthlysalary(); 
        
      
    }
}
