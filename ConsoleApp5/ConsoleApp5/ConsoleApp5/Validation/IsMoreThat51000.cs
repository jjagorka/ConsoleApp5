using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Validation
{
    public class IsMoreThan51000 : ISpecification<int>
    {
        public void Validate(int value)
        {
            if (value >= 51000)
            {
                throw new ValidationException(string.Format("Cлишком большое значение, введите значения дат, где N не превышает 51000"));
            }
        }
    }
}
