using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public abstract class Delegates
    {
        private string m_label;

        public string Label { get => m_label; set => m_label = value; }

        public abstract void Show();
    }
}
