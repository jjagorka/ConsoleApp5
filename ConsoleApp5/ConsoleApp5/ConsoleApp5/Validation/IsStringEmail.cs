using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Validation
{
    public class IsStringsEmail : ISpecification<string>
    {
        public void Validate(string str)
        {
            if (Regex.IsMatch(str, @"[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))==false)
            {
                throw new ValidationException(string.Format("Строка" + " " + str + " " + "не является email-ом!"));
            }
        }
    }
}
