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
            int x = IOUtils.SafeReadInteger("X:");
            int y = IOUtils.SafeReadInteger("Y:");
            int z = IOUtils.SafeReadInteger("Z:", new AndSpecification<int>(new IsNotZero(), new IsMoreThanZero()));
            Calc(x,y,z);
        }

        static void Calc(int x,int y,int z)
        {
            double result = Math.Round((y - x) / (Math.Sqrt(z)), 3);
            Console.WriteLine(result);
        }
    }
}
