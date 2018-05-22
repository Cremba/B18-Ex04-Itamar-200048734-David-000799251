using System;
using Ex04.Menus.Delegates;

namespace Ex04.Test
{
    internal class DelegateMain
    {
        internal static void build()
        {
            MainMenu mainMenu = new MainMenu("Delegate Main menu", 1);
            MainMenu menuOfTimeAndDay = mainMenu.newLevelMenu("Show Date/Time");
            menuOfTimeAndDay.NewItem("Show Time").ToShow += new Time().Show;
            menuOfTimeAndDay.NewItem("Show Date").ToShow += new Date().Show;
            MainMenu menuVersionAndCapitals = mainMenu.newLevelMenu("Version and Capitals");
            menuVersionAndCapitals.NewItem("Count Capitals").ToShow += new CountCapital().Show;
            menuVersionAndCapitals.NewItem("Display Version").ToShow += new DisplayVersion().Show;
            mainMenu.Show();
            Console.WriteLine("Bye Bye");
            Console.ReadLine();

        }
    }
    class DisplayVersion
    {
        public void Show()
        {
            Console.WriteLine("App Version: 18.2.4.0");
        }
    }
    class Time 
    {
        public void Show()
        {
            Console.WriteLine("The time is {0}", DateTime.Now.TimeOfDay);
        }
    }

    class Date 
    {
        public void Show()
        {
            Console.WriteLine("The date of today is {0}", DateTime.Now.Date);
        }
    }
    class CountCapital
    {
        public void Show()
        {
            int count = 0;
            Console.WriteLine("Please insert a text");
            string inputFromUser = Console.ReadLine();
            foreach (char letter in inputFromUser)
            {
                if (char.IsUpper(letter))
                {
                    count++;
                }
            }

            Console.WriteLine("There is a total of {0} capital letters", count);
        }
    }
}