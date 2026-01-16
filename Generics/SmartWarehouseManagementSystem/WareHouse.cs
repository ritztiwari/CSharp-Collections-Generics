using System;
using System.Dynamic;

namespace CSharp_Advance_Collections.Generics.SmartWarehouseManagementSystem
{
    public abstract class WareHouse
    {
        protected int id{get; set;}
        protected string itemName{get; set;}
        protected decimal price{get; set;}

        public WareHouse(int id,string itemName,decimal price)
        {
            this.id = id;
            this.itemName = itemName;
            this.price = price;
        }

        public abstract void DisplayDetails();
    }
}