﻿using AT.HeadFirst.Decorator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace Test.Decorator
{
    public class TestHakkaNoodles
    {
        Noodles noodles;
        public TestHakkaNoodles() => noodles = new VegetableHakkaNoodles();

        [Fact]
        public void HakkaNoodlesWithoutToppings()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                sw.WriteLine("{0} {1} {2}" ,noodles.getdescription() , noodles.Cost() , Environment.NewLine);
                string expected =
                    string.Format("Vegetable Hakka Noodles {0}", noodles.Cost());
                Assert.Equal( sw.ToString().Trim(), expected);
            }
        }

        [Fact]
        public void HakkaNoodlesWithVegitableToppings()
        {
            noodles = new Vegitables(noodles);
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                sw.WriteLine("{0} {1} {2}", noodles.getdescription(), noodles.Cost(), Environment.NewLine);
                string expected =
                    string.Format("Vegetable Hakka Noodles , Vegitables {0}", noodles.Cost());
                Assert.Equal(sw.ToString().Trim(), expected);
            }
        }
        [Fact]
        public void HakkaNoodlesWithExtraSpicyToppings()
        {
            noodles = new ExtraSpicy(noodles);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                sw.WriteLine("{0} {1} {2}", noodles.getdescription(), noodles.Cost(), Environment.NewLine);
                string expected =
                    string.Format("Vegetable Hakka Noodles , Extra Spicy {0}", noodles.Cost());
                Assert.Equal(sw.ToString().Trim(), expected);
            }
        }

        [Fact]
        public void HakkaNoodlesWithBothToppings()
        {
            noodles = new Vegitables(noodles);
            noodles = new ExtraSpicy(noodles);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                sw.WriteLine("{0} {1} {2}", noodles.getdescription(), noodles.Cost(), Environment.NewLine);
                string expected =
                    string.Format("Vegetable Hakka Noodles , Vegitables , Extra Spicy {0}", noodles.Cost());
                Assert.Equal(sw.ToString().Trim(), expected);
            }
        }
    }

   
}
