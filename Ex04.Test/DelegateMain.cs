using System;
using Ex04.Menus.Delegates;

namespace Ex04.Test
{
    internal class DelegateMain
    {
        internal static void build()
        {
            MainMenu mainMenu = new MainMenu("Delegate Main menu", 0);
            MainMenu menuOfTimeAndDay = mainMenu.newLevelMenu("Show Date/Time", 1);
            menuOfTimeAndDay.NewItem("Show Time").ToShow += new Time().Show;
            menuOfTimeAndDay.NewItem("Show Date").ToShow += new Date().Show;
            MainMenu menuVersionAndCapitals = mainMenu.newLevelMenu("Version and Capitals", 1);
            menuVersionAndCapitals.NewItem("Count Capitals").ToShow += new CountCapital().Show;
            menuVersionAndCapitals.NewItem("Display Version").ToShow += new DisplayVersion().Show;
            mainMenu.Show();
            Console.WriteLine("Bye Bye");
            Console.ReadLine();
        }
    }
}