﻿using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Test
{
    public class Time : IAction
    {
        public IAction Run()
        {
            Show();
            return null;
        }

        public void Show()
        {
            Console.WriteLine("The time is {0}", DateTime.Now.TimeOfDay);
            Console.ReadLine();
        }
    }
}
