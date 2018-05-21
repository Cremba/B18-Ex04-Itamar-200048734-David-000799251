using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class Item : IDelegates
    {
        private string m_ItemLabel;

        public Item(string i_ItemLabel)
        {
            m_ItemLabel = i_ItemLabel;
        }

        public delegate void MenuDelegate();

        public event MenuDelegate Show;
        
        
        
        //add delegate handler


        
    }
}
