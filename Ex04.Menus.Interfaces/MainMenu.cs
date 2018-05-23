using System.Collections.Generic;
using System;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : IMenu
    {
        private int m_Level = 0;
        public string Title;
        private List<IMenu> m_ListOfMenuItems = new List<IMenu>();
        private MainMenu parent;

        public MainMenu(string i_Title, int i_Level, MainMenu i_Parent)
        {
            Title = i_Title;
            m_Level = i_Level;
            parent = i_Parent;
        }

        public MainMenu addNewMenu(string i_Title, int i_Level, MainMenu i_Parent)
        {
            MainMenu mainMenu = new MainMenu(i_Title, i_Level, i_Parent);

            m_ListOfMenuItems.Add(mainMenu);

            return mainMenu;
        }

        public void addNewItemToMenu(string i_Title, MainMenu i_Parent, IAction i_Action)
        {
            Runnable menuItem = new Runnable(i_Title, i_Action);
            m_ListOfMenuItems.Add(menuItem);
            this.parent = i_Parent;
        }

        public void ToShow()
        {
            bool inputIsRight = true;

            while (inputIsRight)
            {
                printMenu();
                int choice = validateInputFromUser();
                if (choice == 0)
                {
                    inputIsRight = false;

                }
                else
                {
                    m_ListOfMenuItems[choice - 1].ToShow();
                }
            }
        }

        private int validateInputFromUser()
        {
            int choiceFromUserAsNumber = 0;
            bool inputIsValid = false;
            while (!inputIsValid)
            {
                string inputFromUserAsString = Console.ReadLine();
                if (!int.TryParse(inputFromUserAsString, out choiceFromUserAsNumber))
                {
                    Console.WriteLine("Input needs to be a number ");
                }
                else if (choiceFromUserAsNumber == 0)
                {
                    if (m_Level == 0)
                    {
                        Console.WriteLine("Bye bye");
                        break;
                    }
                    else
                    {
                        parent.ToShow();
                    }
                }
                else if (choiceFromUserAsNumber < 1 || choiceFromUserAsNumber > m_ListOfMenuItems.Count)
                {
                    Console.WriteLine("Value needs to be between 1 and {0}", m_ListOfMenuItems.Count + 1);
                }
                else
                {
                    inputIsValid = true;
                }
            }

            return choiceFromUserAsNumber;
        }

        private void printMenu()
        {
            int index = 1;
            Console.Clear();
            Console.WriteLine("{0} :", Title);

            foreach (IMenu item in m_ListOfMenuItems)
            {
                if (item is MainMenu)
                {
                    Console.WriteLine("{0}. {1}", index, (item as MainMenu).Title);
                }
                else if (item is MenuItem)
                {
                    Console.WriteLine("{0}. {1}", index, (item as MenuItem).Title);
                }
                else if (item is Runnable)
                {
                    Console.WriteLine("{0}. {1}", index, (item as Runnable).Lable);
                }

                index++;
            }

            if (m_Level == 0)
            {
                Console.WriteLine("0. Exit");
            }
            else
            {
                Console.WriteLine("0. Back");
            }
        }
    }
}