using ConsoleApp5;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.ConsoleApp5
{
    [TestFixture]
    public class MenuTests
    {

        [Test]
        public void Menu_ManageItems()
        {
            Menu.ClearItems();

            Menu.AddItem(new Pick_0());
            Assert.AreEqual(1, Menu.ItemsCount);

            Menu.ClearItems();
            Assert.AreEqual(0, Menu.ItemsCount);
        }
    }
}