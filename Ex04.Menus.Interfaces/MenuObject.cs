using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuObject
    {
        private string m_Title;
        private MainMenu m_Parent;

        public MenuObject(string i_Title, MainMenu i_Parent)
        {
            Title = i_Title;
            Parent = i_Parent;

        }

        public string Title { get => m_Title; set => m_Title = value; }
        public MainMenu Parent { get => m_Parent; set => m_Parent = value; }
    }
}
