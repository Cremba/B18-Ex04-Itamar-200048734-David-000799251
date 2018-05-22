using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private int m_Level = 1;
        public string Title;
        private List<MenuItem> m_ListOfMenuItems = new List<MenuItem>();
        private List<MainMenu> m_ListOfMenuMenus = new List<MainMenu>();
        private MainMenu parent;

        public MainMenu(string i_Title, int i_Level, MainMenu i_Parent)
        {
            Title = i_Title;
            m_Level = i_Level;
            parent = i_Parent;
        }

        public void addNewMenu(MainMenu i_Menu)
        {
            m_ListOfMenuMenus.Add(i_Menu);
        }

        public void addNewItemToMenu(MenuItem i_MenuItem)
        {
            m_ListOfMenuItems.Add(i_MenuItem);
        }

    }
}