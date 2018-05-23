using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public abstract class Delegates
    {
        private string m_label;
        private int m_index = 1;

        public string Label { get => m_label; set => m_label = value; }
        public int Index { get => m_index; set => m_index = value; }

        public abstract void Show();
    }
}
