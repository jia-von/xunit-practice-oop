using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace XUnitOOPPractice
{
    public class Combo : MenuItem //Create inherited classes from MenuItem called “FoodItem” and “Combo”
    {
        public List<FoodItem> ComboItems { get; set; }

        public override double Price
        {
            get
            {
                // LINQ: Select all of the prices, add them up, then multiple by 0.8 (80%, or 20% off).
                return ComboItems.Select(x => x.Price).Sum() * 0.8;
            }
            // The value is derived from ComboItems, so setting the price shouldn't work, but we have to declare it as a consequence of the derived property.
            set { }
        }

        public Combo()
        {
            ComboItems = new List<FoodItem>();
        }

    }
}
