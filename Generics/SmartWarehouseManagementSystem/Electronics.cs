using System;

namespace CSharp_Advance_Collections.Generics.SmartWarehouseManagementSystem
{
    class Electronics : WareHouse
    {
        private int warantyMonths;
        public Electronics(int id,string itemName,decimal price,int warantyMonths) : base(id, itemName, price)
        {
            this.warantyMonths = warantyMonths;
        }

        public override void DisplayDetails()
        {
            System.Console.WriteLine($"electronic id is: {id}\nitem name is: {itemName}\nitem price is: {price}\nwaranty on electornic item in months is: {warantyMonths}\n");
        }
    }
    
}
