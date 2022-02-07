using ConsoleApp5.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Pick_3 : Task
    {
        public override string Title { get { return "Recursion date"; } }

        public override void Execute()
        {

            Console.WriteLine(Formula(N_count(new IsMoreThan51000())));




        }

        static DateTime Date_max(DateTime date1, DateTime date2)
        {
            DateTime date_max = date2;
            if (date1 >= date2)
            {
                date_max = date1;
            }
            return date_max;
        }

        static DateTime Date_min(DateTime date1, DateTime date2)
        {
            DateTime date_min = date2;
            if (date1 <= date2)
            {
                date_min = date1;
            }
            return date_min;


        }
        static int N_count(ISpecification<int> specification = null)
        {
            while (true)
            {

            
                List<DateTime> interval1 = IOUtils.TimeInterval("Введите первый отрезок дат: ", new IsMoreThanZeroForData());
                List<DateTime> interval2 = IOUtils.TimeInterval("Введите второй отрезок дат: ", new IsMoreThanZeroForData());

                DateTime date_min = Date_min(interval1[1], interval2[1]);
                DateTime date_max = Date_max(interval1[0], interval2[0]);

                if (date_min == date_max)
                {
                return 1;
                }

                TimeSpan span = date_min - date_max;
                string s = span.ToString();
                string[] ss = s.Split('.');
                int n = Int32.Parse(ss[0]);

                if (n < 0)
                {
                    return 0;
                }

                try
                {
                    if (specification != null)
                    {
                        specification.Validate(n);
                    }
                    return n+1;
                }
                catch (ValidationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        static string Formula(int n, int div = 0)
        {

            if (n == 0)
            {
                return "0 не является натуральным числом и, соответственно, не является ни простым, ни составным.";
            }
            if (div == 0)
            {
                div = n - 1;
            }
            while (div >= 2)
            {
                if (n % div == 0)
                {
                    return n + " - No";
                }
                else
                {
                    return Formula(n, div - 1);
                }

            }
            return n + " - Yes";
        }
    }
}
