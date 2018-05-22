using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Test
{
    partial class Time
    {
        public void Show()
        {
            Console.WriteLine("The time is {0}", DateTime.Now.TimeOfDay);
        }
    }
}
