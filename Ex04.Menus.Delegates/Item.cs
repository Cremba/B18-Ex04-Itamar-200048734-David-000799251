using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class Item : Delegates 
    {
         public Item(string i_ItemLabel)
        {
            Label = i_ItemLabel;
            
        }

        public delegate void MenuDelegate();

        public event MenuDelegate ToShow;

        public override void Show()
        {
            ToShow?.Invoke();
        }
    }
}
