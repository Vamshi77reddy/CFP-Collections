using System;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashTableColl hash = new HashTableColl();
            hash.Button2_Click();
            Console.WriteLine("....");

            Arraylist array = new Arraylist();
            array.arrayList();
            Console.WriteLine("....");

            StoredList storedList = new StoredList();
            storedList.storedList();
            Console.WriteLine("....");

            StackColl stackColl = new StackColl();
            stackColl.stack();
            Console.WriteLine("....");
            QUeueImp qUeueImp = new QUeueImp(); 
            qUeueImp.queue();
            Console.WriteLine("....");
            GenericList genericList = new GenericList();
            genericList.list();
            Console.WriteLine("....");

            GenericDictionary genericDictionary = new GenericDictionary();  
            genericDictionary.dictionary();
            Console.WriteLine("....");
            SortedListimp sortedListimp = new SortedListimp();
            sortedListimp.sortedList();
            Console.WriteLine("....");
            GenericStack genericStack = new GenericStack();
            genericStack.stack();

            Console.WriteLine("....");
            GenericQueueimp genericQueueimp = new GenericQueueimp();
            genericQueueimp.queue();

        }
    }
}
