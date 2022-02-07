using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Validation
{
    public class IsMoreThanZero : ISpecification<int>
    {
        public void Validate(int value)
        {
            if (value <= 0)
            {
                throw new ValidationException(string.Format("Квадратный корень из отрицательных чисел не является вещественным! Введите число ещё раз"));
            }
        }
    }
}
