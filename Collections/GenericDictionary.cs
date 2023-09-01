using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class GenericDictionary
    {
        public void dictionary()
        {
            Dictionary<int, string> dct = new Dictionary<int, string>();
            dct.Add(1, "cs.net");
            dct.Add(2, "vb.net");
            dct.Add(3, "vb.net");
            dct.Add(4, "vb.net");
            foreach (KeyValuePair<int, string> kvp in dct)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
        }
    }
}