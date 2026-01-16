using System;

namespace CSharp_Advance_Collections.Generics.SmartWarehouseManagementSystem
{
    class Storage<T> where T : WareHouse
    {
        private readonly List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        // Demonstrates covariance using IEnumerable<WarehouseItem>
        public IEnumerable<WareHouse> GetAllItems()
        {
            return items;
        }

        public void DisplayAllItems()
        {
            Console.WriteLine("\n--- Stored Items ---");

            foreach (T item in items)
            {
                item.DisplayDetails();
            }
        }
    }
}