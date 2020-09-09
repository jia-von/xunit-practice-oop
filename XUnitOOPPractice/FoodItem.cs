using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitOOPPractice
{
    public class FoodItem : MenuItem //Create inherited classes from MenuItem called “FoodItem” and “Combo”
    {
        public override double Price { get; set; } //FoodItem’s Price should be a normal double.
        public TypeFood FoodItems { get; set; }//List of FoodItems that is no specifically mentioned in the assignment
        public enum TypeFood //FoodItem should have a “Type” enum of: FrenchFries, ChickenStrips, Drink
        {
            FrenchFries,
            ChickenStrips,
            Drink
        }

        //Default constructor
        public FoodItem()
        {
            Price = 0;
            FoodItems = TypeFood.ChickenStrips;
        }

        public FoodItem(double price, TypeFood foodItems)
        {
            Price = price;
            FoodItems = foodItems;
        }
    }
}
