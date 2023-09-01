using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class GenericQueueimp
    {
        public void queue()
        {
            Queue<string> q = new Queue<string>();

            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sqlserver");

            foreach (string s in q)
            { Console.WriteLine(s); }
        }
    }
}
