using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Validation
{
    public class IsNotZero : ISpecification<int>
    {
        public void Validate(int value)
        {
            if (value == 0)
            {
                throw new ValidationException(string.Format("На 0 делить нельзя!Введите число ещё раз"));
            }
        }

        internal object And(IsMoreThanZero isMoreThanZero)
        {
            throw new NotImplementedException();
        }
    }
}
