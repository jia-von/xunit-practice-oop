using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitOOPPractice
{
    public class FoodItem : MenuItem //Create inherited classes from MenuItem called “FoodItem” and “Combo”
    {
        public override double Price { get; set; } //FoodItem’s Price should be a normal double.

        //FoodItem should have a “Type” enum of: FrenchFries, ChickenStrips, Drink
        public enum FoodType 
        {
            FrenchFries,
            ChickenStrips,
            Drink
        }
    }
}
