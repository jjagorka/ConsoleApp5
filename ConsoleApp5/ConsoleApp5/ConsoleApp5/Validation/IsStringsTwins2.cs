using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Validation
{
    public class IsStringsTwins2 : ISpecification<List<string>>
    {
        public void Validate(List<string> strings)
        {
            char[] charsToTrim = { ' ' };
            string string1 = strings[0].ToUpper().Trim(charsToTrim);
            string string2 = strings[1].ToUpper().Trim(charsToTrim);
            if (string1 != string2)
            {
                throw new ValidationException(string.Format("Строки не совпадают посимвольно даже в одном регистре и без пробелов в начале и в конце!"));
            }
        }
    }
}
