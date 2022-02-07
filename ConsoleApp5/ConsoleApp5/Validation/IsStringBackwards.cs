using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Validation
{
    public class IsStringBackwards : ISpecification<List<string>>
    {
        public void Validate(List<string> strings)
        {
            char[] arr = strings[0].ToCharArray();
            Array.Reverse(arr);
            string string1 = new string(arr);
            if (string1 != strings[1])
            {
                throw new ValidationException(string.Format("Первая строка не является перевертышем другой!"));
            }
        }
    }
}
