using System;

namespace AT.HeadFirst.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Noodles noodles = new VegetableHakkaNoodles();
            noodles = new Vegitables(noodles);
            noodles = new ExtraSpicy(noodles);

            Console.WriteLine( "{0} {1}",noodles.getdescription() , noodles.Cost());

            Noodles noodles1 = new FriedNoodles();
            noodles1 = new Vegitables(noodles1);
            noodles1 = new ExtraSpicy(noodles1);
            Console.WriteLine("{0} {1}", noodles1.getdescription() , noodles1.Cost());

            Console.ReadLine();
        }
    }
}
