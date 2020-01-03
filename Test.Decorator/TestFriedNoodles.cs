using AT.HeadFirst.Decorator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace Test.Decorator
{
   public  class TestFriedNoodles
    {
        Noodles noodles;
        public TestFriedNoodles() => noodles = new FriedNoodles();

        [Fact]
        public void FriedNoodlesWithoutToppings()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                sw.WriteLine("{0} {1} {2}", noodles.getdescription(), noodles.Cost(), Environment.NewLine);
                string expected =
                    string.Format("Fried Noodles {0}", noodles.Cost());
                Assert.Equal(sw.ToString().Trim(), expected);
            }
        }

        [Fact]
        public void FriedNoodlesWithVegitableToppings()
        {
            noodles = new Vegitables(noodles);
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                sw.WriteLine("{0} {1} {2}", noodles.getdescription(), noodles.Cost(), Environment.NewLine);
                string expected =
                    string.Format("Fried Noodles , Vegitables {0}", noodles.Cost());
                Assert.Equal(sw.ToString().Trim(), expected);
            }
        }
        [Fact]
        public void FriedNoodlesWithExtraSpicyToppings()
        {
            noodles = new ExtraSpicy(noodles);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                sw.WriteLine("{0} {1} {2}", noodles.getdescription(), noodles.Cost(), Environment.NewLine);
                string expected =
                    string.Format("Fried Noodles , Extra Spicy {0}", noodles.Cost());
                Assert.Equal(sw.ToString().Trim(), expected);
            }
        }

        [Fact]
        public void FriedNoodlesWithBothToppings()
        {
            noodles = new Vegitables(noodles);
            noodles = new ExtraSpicy(noodles);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                sw.WriteLine("{0} {1} {2}", noodles.getdescription(), noodles.Cost(), Environment.NewLine);
                string expected =
                    string.Format("Fried Noodles , Vegitables , Extra Spicy {0}", noodles.Cost());
                Assert.Equal(sw.ToString().Trim(), expected);
            }
        }
    }
}

