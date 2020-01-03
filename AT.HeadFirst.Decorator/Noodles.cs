using System;
using System.Collections.Generic;
using System.Text;

namespace AT.HeadFirst.Decorator
{
    public abstract class Noodles
    {
        public string description = "Raw Noodles";
        public abstract string getdescription();
        public abstract double Cost();
    }
}
