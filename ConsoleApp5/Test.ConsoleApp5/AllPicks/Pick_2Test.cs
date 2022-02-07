using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp5;
using NUnit.Framework;

namespace Test.ConsoleApp5.AllPicks
{
    [TestFixture]

    public class Pick_2Test
    {
        [TestCase(3,3,4, ExpectedResult = 0)]
        [TestCase(2,4,4, ExpectedResult = 1)]

        public double Pick_2_Calc(int x,int y,int z)
        {
            return Pick_2.Calc(x, y, z);
        }
    }
}
