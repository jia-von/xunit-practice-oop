using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XUnitOOPPractice
{
    public class Order //Create a public class called Order with the following properties / methods:
    {
        private List<FoodItem> Items { get; set; } //Items (private polymorphic list)

        public Order()
        {
            Items = new List<FoodItem>();
        }

        public int ItemCount() //ItemCount (int), a function of the count of the items.
        {
            return Items.Count;
        }
        /*
            If an item is added, and because of that addition there is an instance of each food item (Fries, Chicken Strips and Drink), then add all three to a new ComboItem. Remove the items from the Items list, and add the Combo to the Items list.
         */
        public void AddItem(FoodItem foodItem)//AddItem(): Accepts polymorphic argument and adds it to the list
        {
            ItemCount();
            if(ItemCount() == 3)
            {
                Combo temp = new Combo();
                

            }
            Items.Add(foodItem);
        }

        public void RemoveItem()//RemoveItem(): Removes the most recent addition to the Items list, if it’s a combo, remove the whole combo.
        {

        }
        public void Total()//Total (double), a function of the sum of all of the prices in Items.
        {

        }
    }
}
