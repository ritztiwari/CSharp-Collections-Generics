using System;

namespace CSharp_Advance_Collections.Generics.SmartWarehouseManagementSystem
{
    class Furniture : WareHouse
    {
        private string Material { get; set; }
        public Furniture(int id,string itemName,decimal price,string material) : base(id, itemName, price)
        {
            this.Material = material;
        }

        public override void DisplayDetails()
        {
            System.Console.WriteLine($"furniture id is: {id}\furniture name is: {itemName}\furniture price is: {price}\nfurniture made by material: {Material}");
        }
    }
}