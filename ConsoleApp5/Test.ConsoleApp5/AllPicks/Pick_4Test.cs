using ConsoleApp5;
using ConsoleApp5.Validation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.ConsoleApp5.AllPicks
{
    [TestFixture]

    public class Pick_4Test
    {

        [TestCase("лол","лол", ExpectedResult = "Строки совпадают посимвольно")]
        [TestCase("лол", "лал", ExpectedResult = "Строки не совпадают!")]


        public string Pick_4_Coincidence_1(string str1,string str2)
        {
            List<string> strings = new List<string>();
            strings.Add(str1);
            strings.Add(str2);
            return Pick_4.Coincidence_1(strings, new IsStringsTwins());
        }



        [TestCase("185.210.140.111", ExpectedResult = "Строка 185.210.140.111 является ip-адрессом")]
        [TestCase("лул", ExpectedResult = "Строка лул не является IP адрессом")]

        public string Pick_4_IsValidIP(string str)
        {
            return Pick_4.IsValidIP(str, new IsStringIP());
        }

        [TestCase("lol@lol.ru", ExpectedResult = "Строка lol@lol.ru является email-ом")]
        [TestCase("лул", ExpectedResult = "Строка лул не является email-ом!")]

        public string Pick_4_IsValidEmail(string str)
        {
            return Pick_4.IsValidEmail(str, new IsStringsEmail());
        }

        [TestCase("89130000000", ExpectedResult = "Строка 89130000000 является номером телефона")]
        [TestCase("кек", ExpectedResult = "Строка кек не является номером телефона!")]

        public string Pick_4_IsValidPhoneNumber(string str)
        {
            return Pick_4.IsValidPhoneNumber(str, new IsStringPhoneNumber());
        }
    }
}