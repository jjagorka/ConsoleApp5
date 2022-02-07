using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp5.Validation
{
    public class IsStringPhoneNumber : ISpecification<string>
    {
        public void Validate(string str)
        {
            if (Regex.IsMatch(str, @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))==false)
            {
                throw new ValidationException(string.Format("Строка" + " " + str + " " + "не является номером телефона!"));
            }
        }
    }
}
