using ConsoleApp5.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Pick_4 : Task
    {
        public override string Title { get { return "Strings"; } }

        public override void Execute()
        {
            string string1 = IOUtils.SafeReadString("s1","Введите первую строку: ");
            string string2 = IOUtils.SafeReadString("s2","Введите вторую строку: ");
            List<string>strings = new List<string>();
            strings.Add(string1);
            strings.Add(string2);
            Console.WriteLine(Coincidence_1(strings, new IsStringsTwins()));
            Console.WriteLine(Coincidence_2(strings, new IsStringsTwins2()));
            Console.WriteLine(Coincidence_3(strings, new IsStringBackwards()));
            Coincidence_4(string1);
            Coincidence_4(string2);
        }

        
        public static string Coincidence_1(List<string>strings, ISpecification<List<string>> specification = null)
        {
            try
            {
                if (specification != null)
                {
                    specification.Validate(strings);
                }
                return "Строки совпадают посимвольно";
            }
            catch (ValidationException ex)
            {
                return(ex.Message);
                
            }
        }

        static string Coincidence_2(List<string> strings, ISpecification<List<string>> specification = null)
        {
            try
            {
                if (specification != null)
                {
                    specification.Validate(strings);
                }
                return "Строки совпадают посимвольно в одном регистре и без пробелов в начале и в конце";
            }
            catch (ValidationException ex)
            {
                return (ex.Message);

            }
        }

        static string Coincidence_3(List<string> strings, ISpecification<List<string>> specification = null)
        {
            try
            {
                if (specification != null)
                {
                    specification.Validate(strings);
                }
                return "Первая строка является перевертышем другой";
            }
            catch (ValidationException ex)
            {
                return (ex.Message);

            }

  
        }

        public static string IsValidEmail(string str, ISpecification<string> specification = null)
        {
            try
            {
                if (specification != null)
                {
                    specification.Validate(str);
                }
                return "Строка" + " " + str + " " + "является email-ом";
            }
            catch (ValidationException ex)
            {
                return (ex.Message);

            }
        }

        public static string IsValidPhoneNumber(string str, ISpecification<string> specification = null)
        {
            try
            {
                if (specification != null)
                {
                    specification.Validate(str);
                }
                return "Строка" + " " + str +" " + "является номером телефона";
            }
            catch (ValidationException ex)
            {
                return (ex.Message);

            }
        }

        public static string IsValidIP(string str, ISpecification<string> specification = null)
        {
            try
            {
                if (specification != null)
                {
                    specification.Validate(str);
                }
                return "Строка" + " " + str + " " + "является ip-адрессом";
            }
            catch (ValidationException ex)
            {
                return (ex.Message);

            }
        }

        static void Coincidence_4(string string1)
        {
            Console.WriteLine(IsValidEmail(string1,new IsStringsEmail()));
            Console.WriteLine(IsValidPhoneNumber(string1, new IsStringPhoneNumber()));
            Console.WriteLine(IsValidIP(string1, new IsStringIP()));

        }
    }
}
