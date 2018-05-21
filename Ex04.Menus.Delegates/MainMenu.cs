using System.Collections.Generic;
using System;

namespace Ex04.Menus.Delegates
{
    public class MainMenu : IDelegates
    {
        private int m_Level;
        public string Title { get; set; }
        private List<IDelegates> m_ListOfMainMenu = new List<IDelegates>();

        public MainMenu(string i_Title, int i_Level)
        {
            Title = i_Title;
            m_Level = i_Level;
        }
        public MainMenu newLevelMenu(string i_Title)
        {
            MainMenu mainMenu = new MainMenu(i_Title, m_Level++);
            m_ListOfMainMenu.Add(mainMenu);
            return mainMenu;
        }
        public Item NewItem(string i_ItemLabel)
        {
            Item item = new Item(i_ItemLabel);
            m_ListOfMainMenu.Add(item);
            return item;
        }
        private int getNumberFromUser()
        {
            int choiceFromUserAsNumber = 0;
            bool inputIsValid = false;
            while (!inputIsValid)
            {
                string inputFromUserAsString = Console.ReadLine();
                if(!int.TryParse(inputFromUserAsString, out choiceFromUserAsNumber))
                {
                    Console.WriteLine("Input needs to be a number ");
                }
                else if( choiceFromUserAsNumber <= 1 || choiceFromUserAsNumber >= m_ListOfMainMenu.Count)
                {
                    Console.WriteLine("Value needs to be between 1 and {0}", m_ListOfMainMenu.Count + 1);
                }
                else
                {
                    inputIsValid = true;
                }
            }
            return choiceFromUserAsNumber;
        }
    }
}