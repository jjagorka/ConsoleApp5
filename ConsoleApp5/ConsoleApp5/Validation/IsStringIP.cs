using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp5.Validation
{
    public class IsStringIP : ISpecification<string>
    {
        public void Validate(string str)
        {
            if (Regex.IsMatch(str, @"(\b25[0-5]|\b2[0-4][0-9]|\b[01]?[0-9][0-9]?)(\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))==false)
            {
                throw new ValidationException(string.Format("Строка" + " " + str + " " + "не является IP адрессом"));
            }
        }
    }
}
