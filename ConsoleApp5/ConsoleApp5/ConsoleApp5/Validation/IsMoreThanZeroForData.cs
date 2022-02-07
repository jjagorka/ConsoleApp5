using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Validation
{
    public class IsMoreThanZeroForData : ISpecification<int>
    {
        public void Validate(int value)
        {
            if (value <= 0)
            {
                throw new ValidationException(string.Format("Дата окончания меньше чем дата начала, введиты даты ещё раз"));
            }
        }
    }
}
