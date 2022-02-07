using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Menu
    {
        private static List<Task> MenuItems = new List<Task>();

        public static void ClearItems()
        {
            Menu.MenuItems.Clear();
        }

        public static void AddItem(Task menuItem)
        {
            Menu.MenuItems.Add(menuItem);
        }

        public static int ItemsCount
        {
            get
            {
                return MenuItems.Count();
            }
        }

        public static void Execute()
        {
            int iMenu = IOUtils.SafeReadInteger("mi",null) - 1;
            if (iMenu >= 0 && iMenu < Menu.MenuItems.Count)
            {
                Menu.MenuItems.ToArray()[iMenu].Execute();
            }
            else
            {
                Console.WriteLine("Нет такого пункта в меню!");
            }
        }

        public static void ShowMenu()
        {
            Console.WriteLine("=== MENU ===");

            int iMenuItem = 1;
            foreach (Task menuItem in Menu.MenuItems)
            {
                Console.WriteLine("{0}: {1}", iMenuItem++, menuItem.Title);
            }
        }
    }
}
