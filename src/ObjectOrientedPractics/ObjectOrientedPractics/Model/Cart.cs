using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    public class Cart
    {
        private List<Item> _items;
        
        public List<Item> Items { get { return _items; } set { _items = value; } }

        public double Amount 
        {
            get 
            {
                if (_items != null)
                {
                    double sum = 0;
                    for (int i = 0; i < _items.Count; i++)
                    {
                        sum += _items[i].Cost;
                    }
                    return sum;
                }
                return 0.0; 
            }
        }

        public Cart()
        {
            Items = new List<Item>();
        }
    }
}
