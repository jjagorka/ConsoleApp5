using ConsoleApp5.Validation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public static class IOUtils
    {
        private static IDictionary<string, string> ExternalValues = null;

        public static void SetExtValues(IDictionary<string, string> values)
        {
            ExternalValues = values;
        }

        private static string GetValue(string paramName, string message)
        {
            string sValue = null;
            if (ExternalValues == null)
            {
                sValue = Console.ReadLine();
            }
            else
            {
                if (!ExternalValues.TryGetValue(paramName, out sValue))
                {
                    throw new InvalidOperationException(string.Format("Parameter -{0} not specify.", paramName));
                }
            }
            return sValue;
        }

        public static int SafeReadInteger(string paramName, string message, ISpecification<int> specification=null)
        {
            if (ExternalValues == null && !string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while (true)
            {
                string input = GetValue(paramName,message);
                try
                {
                    int number = int.Parse(input);
                    if (specification != null)
                    {
                        specification.Validate(number);
                    }
                    return number;
                }
                catch (Exception ex)
                {
                    if ((ex is ValidationException) ||
                       (ex is FormatException) ||
                       (ex is OverflowException))
                    {
                        if (ExternalValues == null)
                        {
                            Console.WriteLine("Ошибка:  " + ex.Message);
                        }
                        if (ExternalValues != null)
                        {
                            throw new InvalidOperationException(ex.Message, ex);
                        }
                    }
                    else
                    {
                        throw ex;
                    }

                }
            }
        }

        public static DateTime SafeReadDate(string paramName, string message)
        {
            if (ExternalValues == null && !string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while (true)
            {
                string input = GetValue(paramName, message);
                try
                {
                    DateTime data = DateTime.ParseExact(input, "dd.MM.yyyy", null, DateTimeStyles.None);
                    return data;
                }
                catch (FormatException ex)
                {
                    if (ExternalValues == null)
                    {
                        Console.WriteLine("Ошибка:  " + ex.Message);
                    }
                    if (ExternalValues != null)
                    {
                        throw new InvalidOperationException(ex.Message, ex);
                    }
                }
            }
        }

        public static string SafeReadString(string paramName, string message, ISpecification<int> specification = null)
        {
            {
                if (ExternalValues == null && !string.IsNullOrEmpty(message))
                {
                    Console.Write(message);
                }
                while (true)
                {
                    string sValue = GetValue(paramName, message);
                    try
                    {
                        sValue = sValue.Trim();
                        if (sValue != "")
                        {
                            return sValue;
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("ERROR: " + ex.Message);
                        if (ExternalValues != null)
                        {
                            throw new InvalidOperationException(ex.Message, ex);
                        }
                    }
                    Console.Write("Entered string is empty! Please enter string again: ", Console.ForegroundColor = ConsoleColor.Red);
                    Console.ResetColor();
                }
            }
        }

    }
}
