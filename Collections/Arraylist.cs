using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class Arraylist
    {
        public void  arrayList() {
            ArrayList al = new ArrayList();
            string str = "kiran teja jallepalli";
            int x = 7;
            DateTime d = DateTime.Parse("8-oct-1985");
            al.Add(str);
            al.Add(x);
            al.Add(d);

            foreach (object o in al)
            {
                Console.WriteLine(o);
            }
        }


    }
}
