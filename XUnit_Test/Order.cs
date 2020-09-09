using System;
using System.Collections.Generic;
using System.Text;
using XUnitOOPPractice;

namespace UnitOOPPractice_Tests
{
    public class Order //Create a public class called Order with the following properties / methods:
    {
        private List<MenuItem> Items { get; set; } //Items (private polymorphic list)

        public void ItemCount(int item) //ItemCount (int), a function of the count of the items.
        {

        }

        /*
            
            
            If an item is added, and because of that addition there is an instance of each food item (Fries, Chicken Strips and Drink), then add all three to a new ComboItem. Remove the items from the Items list, and add the Combo to the Items list.
         */
        public void AddItem(MenuItem menuItem)//AddItem(): Accepts polymorphic argument and adds it to the list
        {
            Items.Add(menuItem);
        }

        /*
                     RemoveItem()
                        Removes the most recent addition to the Items list, if it’s a combo, remove the whole combo.
                        
         */
        public void RemoveItem()
        {

        }
        public void Total()//Total (double), a function of the sum of all of the prices in Items.
        {

        }
    }
}
