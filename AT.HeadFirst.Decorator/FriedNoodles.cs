using System;
using System.Collections.Generic;
using System.Text;

namespace AT.HeadFirst.Decorator
{
    public class FriedNoodles : Noodles
    {
        public FriedNoodles()
        {
            description = "Fried Noodles"; 
        }
        public override double Cost()
        {
            return 150;
        }

        public override string getdescription()
        {
            return description;
        }
    }
}
