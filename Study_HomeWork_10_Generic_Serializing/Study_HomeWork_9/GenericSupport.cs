using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_HomeWork_10
{
    public class GenericSupport<T>
    {
        public static List<T> Items = new List<T>();

        public void AddItem(T item)
        { 
            Items.Add(item);
        }
        public void AddItems(List<T> item)
        {
            Items = item;
        }
        public List<T> GetItems()
        {            
            List<T> items = new List<T>(Items);
            return items;
        }
    }
}