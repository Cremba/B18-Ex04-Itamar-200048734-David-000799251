using System.Collections.Generic;
using System;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : IMenu
    {
        private static int s_GlobalIndex = 1;
        private int m_Level = 1;
        private string Title;
        private int m_Index = 0;
        private bool isLevelOne = false;
        private bool inputIsRight = true;
        private List<IMenu> m_ListOfMenuItems = new List<IMenu>();
        private MainMenu parent;

        public int Index { get => m_Index; set => m_Index = value; }

        public MainMenu(string i_Title, int i_Level, MainMenu i_Parent)
        {
            Title = i_Title;
            m_Level = i_Level;
            parent = i_Parent;
        }

        public MainMenu addNewMenu(string i_Title, int i_Level, MainMenu i_Parent)
        {
            MainMenu mainMenu = new MainMenu(i_Title, i_Level, i_Parent);
            mainMenu.Index = s_GlobalIndex;
            s_GlobalIndex++;
            m_ListOfMenuItems.Add(mainMenu);

            return mainMenu;
        }

        public void addNewItemToMenu(string i_Title, MainMenu i_Parent, IAction i_Action)
        {
            Runnable menuItem = new Runnable(i_Title, i_Parent, i_Action);
            m_ListOfMenuItems.Add(menuItem);
        }

        public void ToShow()
        {
            while (inputIsRight)
            {
                printMenu();
                int choice = validateInputFromUser();
                if (choice == 0)
                {
                    if (isLevelOne)
                    {
                        Console.WriteLine("Bye bye");
                        Console.ReadLine();
                        inputIsRight = false;
                        return;
                    }
                    else
                    {
                        inputIsRight = false;
                        s_GlobalIndex = 1;
                        parent.ToShow();
                    }
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
                else if (choiceFromUserAsNumber < 0 || choiceFromUserAsNumber > m_ListOfMenuItems.Count)
                {
                    Console.WriteLine("Value needs to be between 0 and {0}", m_ListOfMenuItems.Count);
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
            Console.Clear();

            if (m_Level == 0)
            {
                Console.WriteLine("{0} :", Title);
            }
            else
            {
                Console.WriteLine("{0}. {1}", Index, Title);
            }

            Console.WriteLine("==============");

            int index = 1;

            foreach (IMenu item in m_ListOfMenuItems)
            {
                if (item is MainMenu)
                {
                    Console.WriteLine("{0}. {1}", index, (item as MainMenu).Title);
                }
                else if (item is Runnable)
                {
                    Console.WriteLine("{0}. {1}", index, (item as Runnable).Lable);
                }

                index++;

                if (this.Index == 0)
                {
                    Index = index;
                } 
            }

            if (m_Level == 0)
            {
                Console.WriteLine("0. Exit");
                isLevelOne = true;
            }
            else
            {
                Console.WriteLine("0. Back");
            }
        }
    }
}