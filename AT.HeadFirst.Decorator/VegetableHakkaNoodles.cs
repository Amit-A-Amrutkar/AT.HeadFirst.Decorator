using System;
using System.Collections.Generic;
using System.Text;

namespace AT.HeadFirst.Decorator
{
    public class VegetableHakkaNoodles : Noodles
    {
        public VegetableHakkaNoodles()
        {
            description = "Vegetable Hakka Noodles";

        }
        public override double Cost()
        {
            return 200;
        }

        public override string getdescription()
        {
            return description;
        }
    }
}
