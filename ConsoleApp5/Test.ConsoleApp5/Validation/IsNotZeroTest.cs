using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp5.Validation;
using NUnit.Framework;

namespace Test.ConsoleApp5
{
    [TestFixture]

    public class IsNotZeroTest
    {

        [Test]

        public void IsNotZero_Validate_WtihNonZero_Ok()
        {
            new IsNotZero().Validate(56);
        }


        [Test]

        public void IsNotZero_Validate_WtihZero_ThrowValidationEx()
        {
            Assert.Throws<ValidationException>(() =>
            {
                new IsNotZero().Validate(0);
            });
        }
    }
}
