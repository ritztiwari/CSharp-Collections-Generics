// 1. Smart Warehouse Management System
// o Concepts: Generic Classes, Constraints, Variance
// o Problem Statement: Develop a warehouse system that manages
// different types of items (Electronics, Groceries, Furniture).
// o Hints:
// ▪ Create an abstract class WarehouseItem that all items
// extend (Electronics, Groceries, Furniture).
// ▪ Implement a generic class Storage<T> where T :
// WarehouseItem to store items safely.
// ▪ Implement a method to display all items using List<T>.

using System;
namespace CSharp_Advance_Collections.Generics.SmartWarehouseManagementSystem
{
    public class SmartWareHouseExecutable
    {
        public static void Execute()
        {
            //creating a list of storage of type warehouse
            Storage<WareHouse> warehouse = new Storage<WareHouse>();

            //adding data of different types of items in the warehouse.
            warehouse.AddItem(new Electronics(101, "Laptop", 15000,24));
            warehouse.AddItem(new Groceries(102, "Milk", 68,DateTime.Now.AddDays(7)));
            warehouse.AddItem(new Furniture(103, "Office Chair", 12000,"Steel"));

            //displaying the items that are in warehouse.
            warehouse.DisplayAllItems();
        }
    }
}