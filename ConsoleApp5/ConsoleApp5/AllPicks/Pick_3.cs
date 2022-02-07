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

        public static List<DateTime> TimeInterval(string arg, string message,ISpecification<int> specification= null)
        {
            List<DateTime> TimeInterval = new List<DateTime>();

            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while (true)
            {
                DateTime data1 = IOUtils.SafeReadDate("d"+arg+"st", "Введите начальную дату "+arg + " отрезка");
                DateTime data2 = IOUtils.SafeReadDate("d"+arg+"end", "Введите конечную дату" + arg + " отрезка");

                if (data1 == data2)
                {
                    TimeInterval.Add(data1);
                    TimeInterval.Add(data2);
                    return TimeInterval;
                }
                TimeSpan span = data2 - data1;
                string s = span.ToString();
                string[] ss = s.Split('.');
                int n = Int32.Parse(ss[0]);
                try
                {
                    if (specification != null)
                    {
                        specification.Validate(n);
                    }
                    TimeInterval.Add(data1);
                    TimeInterval.Add(data2);
                    return TimeInterval;
                }
                catch (ValidationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            
        }

        static int N_count(ISpecification<int> specification = null)
        {
            while (true)
            {

            
                List<DateTime> interval1 = TimeInterval("1",null, new IsMoreThanZeroForData());
                List<DateTime> interval2 = TimeInterval("2",null, new IsMoreThanZeroForData());

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

                return n + 1;

                
            }

        }

        public static string Formula(int n, int div = 0)
        {
            if (n>=51000)
            {
                return "Cлишком большое значение, введите значения дат, где N не превышает 51000";
            }    
            
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
