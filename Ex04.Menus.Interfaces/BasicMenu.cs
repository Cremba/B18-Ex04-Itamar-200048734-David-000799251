using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    class BasicMenu : MenuItem
    {
        private List<MenuItem> m_ItemsMenu;
        public BasicMenu(string i_ItemLabel) : base(i_ItemLabel)
        {
            
            m_ItemsMenu = new List<MenuItem>();

        }

        public override void ToShow()
        {
            int index = 0;
            Console.Clear();
            Console.WriteLine("{0} :", ItemLabel);

            foreach (MenuItem item in m_ItemsMenu)
            {
                Console.WriteLine("{0}. {1}", index, item.ItemLabel);
                index++;
            }
        }
        public void AddMenuItem(MenuItem i_MenuItem)
        {
            this.m_ItemsMenu.Add(i_MenuItem);
        }

        public BasicMenu AddSubMenu(string i_ItemLabel)
        {
            BasicMenu newMenu = new BasicMenu(i_ItemLabel);
            AddMenuItem(newMenu);

            return newMenu;
        }
    }
}
