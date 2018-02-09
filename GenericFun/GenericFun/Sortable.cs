using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFun
{
    public class Sortable<T> where T : IComparable
    {
        List<T> items;

        public Sortable()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public override string ToString()
        {
            items.Sort();

            string result = "";

            foreach( var item in items )
            {
                result += item.ToString() + Environment.NewLine;
            }

            return result;
        }
    }

    
}
