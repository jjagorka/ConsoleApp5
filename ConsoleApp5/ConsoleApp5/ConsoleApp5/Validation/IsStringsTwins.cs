using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Validation
{
    public class IsStringsTwins : ISpecification<List<string>>
    {
        public void Validate(List<string>strings)
        {
            if (strings[0]!=strings[1])
            {
                throw new ValidationException(string.Format("Строки не совпадают!"));
            }
        }
    }
}
