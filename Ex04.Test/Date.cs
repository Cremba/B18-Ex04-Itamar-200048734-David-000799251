using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Test
{
    public class Date : IAction
    {
        public void Run()
        {
            Show();
        }

        public void Show()
        {
            Console.WriteLine("The date of today is {0}", DateTime.Now.Date);
            Console.ReadLine();
        }

        IAction IAction.Run()
        {
            Show();
            return null;
        }
    }
}
