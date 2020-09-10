using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XUnitOOPPractice
{
    public class Order //Create a public class called Order with the following properties / methods:
    {
        public List<MenuItem> Items { get; set; }

        public int ItemCount => Items.Count;

        public double Total => Items.Select(x => x.Price).Sum();

        public void AddItem(MenuItem toAdd)
        {
            // Refactoring idea courtesy of Damir.
            Items.Add(toAdd);

            // If we have 3 distinct types of food...
            if (Items.Where(x => x.GetType() == typeof(FoodItem)).Select(x => ((FoodItem)x).Type).Distinct().Count() == 3)
            {
                // Select the first of each type of food.
                FoodItem chicken = (FoodItem)Items.Where(x => x.GetType() == typeof(FoodItem) && ((FoodItem)x).Type == FoodItem.TypeValue.ChickenStrips).First();
                FoodItem drink = (FoodItem)Items.Where(x => x.GetType() == typeof(FoodItem) && ((FoodItem)x).Type == FoodItem.TypeValue.Drink).First();
                FoodItem fries = (FoodItem)Items.Where(x => x.GetType() == typeof(FoodItem) && ((FoodItem)x).Type == FoodItem.TypeValue.FrenchFries).First();

                /*
                --- Cast the result of everything following this to a FoodItem (otherwise it returns a MenuItem). ---
                (FoodItem)
                --- Operating on the Items list ---
                Items
                --- Using Where to filter things out ---
                .Where(
                    --- Filtering out non-FoodItems (Combos), this needs to first because otherwise we will be trying to potentially cast Combos as FoodItems and it will not be happy ---
                    x => x.GetType() == typeof(FoodItem) &&
                    --- AND Filtering out non-FrenchFries FoodItems ---
                    ((FoodItem)x).Type == FoodItem.TypeValue.FrenchFries
                    )
                --- Get the first item that is returned from the Where ---
                .First()
                */


                // Build the combo.
                Combo newCombo = new Combo()
                {
                    ComboItems = new List<FoodItem>() { chicken, fries, drink }
                };

                // Remove the combo items from the Items list.
                Items = Items.Except(newCombo.ComboItems).ToList();

                // Add the combo to the list.
                Items.Add(newCombo);
            }
        }

        public void RemoveItem()
        {
            // Removes the last items in the list (most recent addition, assuming you don't sort the list).
            Items.RemoveAt(Items.Count - 1);
        }

        public Order()
        {
            Items = new List<MenuItem>();
        }
    }
}
