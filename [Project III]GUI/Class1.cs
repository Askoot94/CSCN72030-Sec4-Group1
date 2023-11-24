using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json;
using System.Runtime.CompilerServices;
using System.Net.Security;
using System.Collections.ObjectModel;
using System.Web;

namespace _Project_III_GUI
{
    internal class FoodItem
    {
        private int item_id { get; set; }
        private string name { get; set; }
        private float price { get; set; }
        private int quantity { get; set; }

        public FoodItem(int ID, string Food, float price, int amount)
        {
            //This is the constructor for a normal food item where all parameters are passed
            this.item_id = ID;
            this.name = Food;
            this.price = price;
            this.quantity = amount;
        }
        public FoodItem(int itemIdentifier, int amount)
        {
            //THis is the constructor for fooditems by retrieving thedata from a separate file.

        }
        public int GetID()
        {
            return item_id;
        }
        public void SetQuantity(int newVal)
        {
            this.quantity += newVal;
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
        private string TableName;
        private int Dishes =0;
        private List<FoodItem> Food;

        public Order(string Table)
        {
            TableName = Table;
            //Open the File to be read
            string FileName = TableName + ".json";
            using (StreamReader r = new StreamReader(FileName))
            {
                //Read the File from start to end of file
                string json = r.ReadToEnd();
                //Turn as all the information into objeects of FoodItemClass
                Food = JsonSerializer.Deserialize<List<FoodItem>>(json);
            }

            //Check that the json data serialized properly
            if (this.Food == null && Food.Count == 0)
            {
                //If the jsonfile is empty or didnt' exist, treat this order objects as a fresh object.
                this.Dishes = 0;
                return;
            }
            
            //Update the number of unique dishes in the order
            this.Dishes = Food.Count;
            return;

        }
        public int GetNumberofDishes()
        {
            return Dishes;
        }

        public void AddItem(int Item, int Quantity)
        {
            FoodItem Creation = new FoodItem(Item, Quantity);
            this.Food[Dishes] = Creation;
            Dishes++;
        }
        public void SaveToFile()
        {
            return;
        }
        public void RemoveItem(int amount, int Item)
        {
            for(int i =0; i <= Dishes; i++)
            {
                if (this.Food[i].GetID() == Item)
                {
                    this.Food[i].SetQuantity(amount);
                }
            }
            return;
        }
        public void GetDishInfo(int dishNumber, out string retrive)
        {
            this.Food[dishNumber].GetInfo(out retrive);
        }
        public void GetDishInfo(int dishNumber, out int retrive)
        {
            this.Food[dishNumber].GetInfo(out retrive);
        }
        public void GetDishInfo(int dishNumber, out float retrive)
        {
            this.Food[dishNumber].GetInfo(out retrive);
        }
    }
}
