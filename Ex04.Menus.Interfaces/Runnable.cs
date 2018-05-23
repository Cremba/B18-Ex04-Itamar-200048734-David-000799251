using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    internal class Runnable : MenuItem, IMenu
    {
        private IAction toRun;

        public Runnable(string i_Title, MainMenu i_Parent, IAction action) : base(i_Title, i_Parent, action)
        {
            toRun = action;
            Parent = i_Parent;
            Lable = i_Title;
        }

        public string Lable { get; set; }

        public new void ToShow()
        {
            toRun.Run();
        }
    }
}
