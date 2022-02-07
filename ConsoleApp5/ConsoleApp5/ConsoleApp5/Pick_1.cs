using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Pick_1 : Task
    {
        public override string Title { get { return "Hello World"; } }

        public override void Execute()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
