using ConsoleApp5;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.ConsoleApp5.AllPicks
{
    [TestFixture]

    public class Pick_3Test
    {
        [TestCase(23, ExpectedResult = "23 - Yes")]
        [TestCase(6, ExpectedResult = "6 - No")]
        [TestCase(0, ExpectedResult = "0 не является натуральным числом и, соответственно, не является ни простым, ни составным.")]

        public string Pick_3_Formula(int n)
        {
            return Pick_3.Formula(n);
        }
    }
}
