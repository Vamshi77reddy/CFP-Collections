﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class GenericStack
    {
        public void stack()
        {
            Stack<string> stk = new Stack<string>();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sqlserver");

            foreach (string s in stk)
            {
                Console.WriteLine(s);
            }
        }
    }
}
