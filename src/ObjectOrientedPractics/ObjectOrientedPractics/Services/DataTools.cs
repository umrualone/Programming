using System;
using System.Collections.Generic;
using System.Linq;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Services
{
    public static class DataTools
    {
        public static List<Item> GetSortedListItems(List<Item> items, Func<string, bool> test)
        {
            List<Item> newItems = new List<Item>();

            foreach (Item item in items)
            {
                if (test(item.Name))
                {
                    newItems.Add(item);
                }
            }

            return newItems;
        }

        public static List<Item> GetSortedListItems(List<Item> items, Func<Item, IComparable> orderBy)
        {
            return items.OrderBy(orderBy).ToList();
        }
    }
}
