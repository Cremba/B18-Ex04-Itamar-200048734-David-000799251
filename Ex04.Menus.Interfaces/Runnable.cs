using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    class Runnable : IMenu
    {
        private IAction toRun;

        public Runnable(string i_Lable, IAction action)
        {
            toRun = action;
            Lable = i_Lable;
        }
        public string Lable { get; set; }

        public void ToShow()
        {
            toRun.Run();
        }
    }
}
