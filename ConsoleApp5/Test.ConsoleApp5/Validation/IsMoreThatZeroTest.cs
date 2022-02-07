using ConsoleApp5.Validation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.ConsoleApp5.Validation
{
    [TestFixture]

    public class IsMoreThatZeroTest
    {

        [Test]

        public void IsMoreZero_Validate_WtihMoreThatZero_Ok()
        {
            new IsMoreThanZero().Validate(56);
        }


        [Test]

        public void IsNotZero_Validate_WtihZero_ThrowValidationEx()
        {
            Assert.Throws<ValidationException>(() =>
            {
                new IsMoreThanZero().Validate(-5);
            });
        }
    }
}
