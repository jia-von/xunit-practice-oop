using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace XUnitOOPPractice
{
    public class Combo : MenuItem //Create inherited classes from MenuItem called “FoodItem” and “Combo”
    {
        //ComboItem should have a polymorphic list property of FoodItems called “ComboItems”.
        public List<FoodItem> ComboItems { get; set; }

        //ComboItem’s Price should be a sum of all of the combo Items prices, minus 20%.
        private double _price;
        public override double Price
        { 
            get
            {
                return _price;
            }
            set
            {
                _price = ComboItems.Sum(x => x.Price)*0.8;
            }
         }

    }
}
