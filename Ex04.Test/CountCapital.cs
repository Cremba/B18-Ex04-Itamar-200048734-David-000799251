using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Test
{
    partial class CountCapital : IAction
    {
        public void Run()
        {
            Show();
        }

        public void Show()
        {
            int count = 0;
            Console.WriteLine("Please insert a text");
            string inputFromUser = Console.ReadLine();
            foreach (char letter in inputFromUser)
            {
                if (char.IsUpper(letter))
                {
                    count++;
                }
            }

            Console.WriteLine("There is a total of {0} capital letters", count);
            Console.ReadLine();
        }

        IAction IAction.Run()
        {
            Show();
            return null;
        }
    }
}
