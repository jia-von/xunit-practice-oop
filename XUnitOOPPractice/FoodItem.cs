using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitOOPPractice
{
    public class FoodItem : MenuItem //Create inherited classes from MenuItem called “FoodItem” and “Combo”
    {
        public enum TypeValue
        {
            FrenchFries,
            Drink,
            ChickenStrips
        }
        public TypeValue Type { get; set; }
        override public double Price { get; set; }
    }
}
