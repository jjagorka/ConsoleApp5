using ConsoleApp5.Validation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.ConsoleApp5.Validation
{
    [TestFixture]

    public class IsMoreThan51000Test
    {

        [Test]

        public void IsMoreThan51000_Validate_WtihLessThan51000_Ok()
        {
            new IsMoreThan51000().Validate(56);
        }


        [Test]

        public void IsMoreThan51000_Validate_WtihMoreThan51000_ThrowValidationEx()
        {
            Assert.Throws<ValidationException>(() =>
            {
                new IsMoreThan51000().Validate(51001);
            });
        }
    }
}
