using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private string m_ItemLabel;

        public MenuItem(string i_ItemLabel)
        {
            ItemLabel = i_ItemLabel;
        }

        public string ItemLabel { get => m_ItemLabel; set => m_ItemLabel = value; }

        public abstract void ToShow();
    }
}
