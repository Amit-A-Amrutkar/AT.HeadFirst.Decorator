using System;
using System.Collections.Generic;
using System.Text;

namespace AT.HeadFirst.Decorator
{
    public class Vegitables : Toppings
    {
        Noodles _noodles;

        public Vegitables(Noodles noodles)
        {
            this.toppingcharge = 50.55;
            this._noodles = noodles;
            this._noodles.description = noodles.description;
        }

        public override double Cost()
        {
            return _noodles.Cost() + toppingcharge;
        }

        public override string getdescription()
        {
            return _noodles.getdescription() + " , Vegitables";
        }
    }
}
