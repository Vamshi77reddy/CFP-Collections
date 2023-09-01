using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class GenericList
    {
        public void list ()
        {
            List<int> lst = new List<int>();
            lst.Add(100);
            lst.Add(200);
            lst.Add(300);
            lst.Add(400);
            foreach (int i in lst)
            {
                Console.WriteLine(i);
            }

            }
    }
}
