using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_HomeWork_9
{
    internal class GenericSupport<T>
    {
        static List<T> Items;

        public void AddItem(T item)
        { 
            Items.Add(item);
        }
        public List<T> ShowItem()
        {            
            List<T> items = new List<T>(Items);
            return items;
        }
    }
}