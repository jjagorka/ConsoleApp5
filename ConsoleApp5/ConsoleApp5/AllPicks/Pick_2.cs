using ConsoleApp5.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Pick_2 : Task
    {
        public override string Title { get { return "Calc:(Y-X)/√Z"; } }

        public override void Execute()
        {
            int x = IOUtils.SafeReadInteger("x", "X:");
            int y = IOUtils.SafeReadInteger("y", "Y:");
            int z = IOUtils.SafeReadInteger("z", "Z:", new AndSpecification<int>(new IsNotZero(), new IsMoreThanZero()));
            Console.WriteLine(Calc(x,y,z));
        }

        public static double Calc(int x,int y,int z)
        {
            double result = Math.Round((y - x) / (Math.Sqrt(z)), 3);
            return result;
        }
    }
}
