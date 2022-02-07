using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.ClearItems();
            Menu.AddItem(new Pick_0());
            Menu.AddItem(new Pick_1());
            Menu.AddItem(new Pick_2());
            Menu.AddItem(new Pick_3());
            Menu.AddItem(new Pick_4());
            while (true)
            {
                Menu.Execute();
            }
        }
    }
}
