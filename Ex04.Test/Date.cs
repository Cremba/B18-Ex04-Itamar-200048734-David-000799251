using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Test
{
    partial class Date
    {
        public void Show()
        {
            Console.WriteLine("The date of today is {0}", DateTime.Now.Date);
        }
    }
}
