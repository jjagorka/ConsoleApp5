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
            IDictionary<string, string> argsDic = CmdArgsParser.Parse(args);
            IOUtils.SetExtValues(argsDic);

            Menu.ClearItems();
            Menu.AddItem(new Pick_0());
            Menu.AddItem(new Pick_1());
            Menu.AddItem(new Pick_2());
            Menu.AddItem(new Pick_3());
            Menu.AddItem(new Pick_4());

            if (argsDic != null)
            {
                try
                {
                    Menu.Execute();
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                }
            }
            else
            {
                while (true)
                {
                    Menu.ShowMenu();
                    Menu.Execute();
                }
            }
        }
    }
}
