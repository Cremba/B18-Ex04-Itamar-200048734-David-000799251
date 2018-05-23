using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Test
{
    public class DisplayVersion : IAction
    {
        public void Run()
        {
            Show();
        }

        public void Show()
        {
            Console.WriteLine("App Version: 18.2.4.0");
            Console.ReadLine();
        }

        IAction IAction.Run()
        {
            Show();
            return null;
        }
    }
}
