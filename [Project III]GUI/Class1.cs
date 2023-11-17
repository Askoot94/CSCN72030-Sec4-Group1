using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _Project_III_GUI
{
    internal class FoodItem
    {
        private string name;
        private float price;
        private int quantity;

        public FoodItem(string Food, float price, int amount)
        {
            //This is the constructor for 
            this.name = Food;
            this.price = price;
            this.quantity = amount;
        }
        public FoodItem(int itemIdentifier, int amount)
        {
            //THis is the constructor for fooditems by retrieving thedata from a separate file.
        }
        public void GetInfo(out string storeage)
        {
            storeage = this.name;
            return;
        }
        public void GetInfo(out float storeage)
        {
            storeage = this.price;
            return;
        }
        public void GetInfo(out int storeage)
        {
            storeage = this.quantity;
            return;
        }
    }

    internal class Order
    {
        private int Dishes;
        private FoodItem[] Food;

    }
}
