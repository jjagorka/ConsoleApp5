using ConsoleApp5.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public static class IOUtils
    {
        public static int SafeReadInteger(string message, ISpecification<int> specification=null)
        {
            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while (true)
            {
                string sValue = Console.ReadLine();
                int iValue = 0;
                if (Int32.TryParse(sValue,out iValue))
                {
                    try
                    {
                        if (specification != null)
                        {
                            specification.Validate(iValue);
                        }
                        return iValue;
                    }
                    catch (ValidationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    
                }
                else
                {
                    Console.WriteLine("Неправильный формат числа");
                }
            }
        }

        public static DateTime SafeReadDate(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while (true)
            {
                string sValue = Console.ReadLine();
                DateTime date;
                if (DateTime.TryParseExact(sValue, "dd.MM.yyyy",System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date))
                {
                    return date;
                }
                Console.WriteLine("Неправильный формат даты");
            }
        }

        public static List<DateTime> TimeInterval(string message,ISpecification<int> specification= null)
        {
            List<DateTime> TimeInterval = new List<DateTime>();
            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while (true)
            {
                DateTime data1 = IOUtils.SafeReadDate(null);
                DateTime data2 = IOUtils.SafeReadDate(null);

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

        public static string SafeReadString(string message, ISpecification<int> specification = null)
        {
            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            string str1 = Console.ReadLine();
            return str1;
        }

    }
}
