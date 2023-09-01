using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class SortedListimp
    {
        public void sortedList()
        {
            SortedList<string, string> sl = new SortedList<string, string>();
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");

            foreach (KeyValuePair<string, string> kvp in sl)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
        }
    }
}
