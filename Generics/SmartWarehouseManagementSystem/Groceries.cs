using System;

namespace CSharp_Advance_Collections.Generics.SmartWarehouseManagementSystem
{
    class Groceries : WareHouse
    {
        private DateTime expiryDate{get; set;}
        public Groceries(int id,string itemName,decimal price,DateTime date) : base(id, itemName, price)
        {
            expiryDate = date;
        }

        public override void DisplayDetails()
        {
            System.Console.WriteLine($"Grocery id is: {id}\nGrocery name is: {itemName}\n{itemName} price is: {price}\nexpiration date is: {expiryDate}\n");
        }
    }
}