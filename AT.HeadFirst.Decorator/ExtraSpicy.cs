﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AT.HeadFirst.Decorator
{
    public class ExtraSpicy : Toppings
    {
        Noodles _noodles;

        public ExtraSpicy(Noodles noodles)
        {
            this.toppingcharge = 19.99;
            this._noodles = noodles;
            this._noodles.description = noodles.description;
        }

        public override double Cost()
        {
            return _noodles.Cost() + toppingcharge;
        }

        public override string getdescription()
        {
            return _noodles.getdescription() + " , Extra Spicy";
        }

       
    }
}
