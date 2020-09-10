using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using XUnitOOPPractice;

namespace XUnit_Test
{
    public class UnitTest
    {
        [Fact]
        public void Add_Single_Item_Chicken() //Adding a single item of each type to the order (3 facts).
        {
            Order newOrder = new Order();
            newOrder.AddItem(new FoodItem() { Type = FoodItem.TypeValue.ChickenStrips, Price = 3.00 });
            FoodItem foodItem = (FoodItem)newOrder.Items[0];
            Assert.Equal(FoodItem.TypeValue.ChickenStrips, foodItem.Type);
        }

        [Fact]
        public void Add_Single_Item_FrenchFries() //Adding a single item of each type to the order (3 facts).
        {
            Order newOrder = new Order();
            newOrder.AddItem(new FoodItem() { Type = FoodItem.TypeValue.FrenchFries, Price = 2.00 });
            FoodItem food = (FoodItem)newOrder.Items[0];
            Assert.Equal(FoodItem.TypeValue.FrenchFries, food.Type);
        }

        [Fact]
        public void Add_Single_Item_Drink() //Adding a single item of each type to the order (3 facts).
        {
            Order newOrder = new Order();
            newOrder.AddItem(new FoodItem() { Type = FoodItem.TypeValue.Drink, Price = 1.00 });
            FoodItem food = (FoodItem)newOrder.Items[0];
            Assert.Equal(FoodItem.TypeValue.Drink, food.Type);
        }

        [Fact]
        public void Add_Combo_Test()// Add a Combo to the order (fact). //add combo based on object combo
        {
            Order newOrder = new Order();
            newOrder.AddItem(new Combo());
            Assert.Equal(typeof(Combo),newOrder.Items[0].GetType());
        }

        [Fact]
        public void Add_ComboItems_Test()// Add a Combo to the order (fact). based on items
        {
            Order newOrder = new Order();
            newOrder.AddItem(new FoodItem() { Type = FoodItem.TypeValue.ChickenStrips, Price = 3.00 });
            newOrder.AddItem(new FoodItem() { Type = FoodItem.TypeValue.FrenchFries, Price = 2.00 });
            newOrder.AddItem(new FoodItem() { Type = FoodItem.TypeValue.Drink, Price = 1.00 });
            Assert.Equal(typeof(Combo), newOrder.Items[0].GetType());
        }

        [Fact]
        public void Remove_Single_Item()//Remove a single item from the order (fact).
        {
            Order newOrder = new Order();
            newOrder.AddItem(new FoodItem() { Type = FoodItem.TypeValue.ChickenStrips, Price = 3.00 });
            newOrder.AddItem(new FoodItem() { Type = FoodItem.TypeValue.FrenchFries, Price = 2.00 });
            newOrder.RemoveItem();
            Assert.Equal(3, newOrder.Total);  //check using the price of the item
        }

        [Fact]
        public void Remove_Combo()//Remove a combo from the order (fact).
        {
            Order newOrder = new Order();
            newOrder.AddItem(new FoodItem() { Type = FoodItem.TypeValue.ChickenStrips, Price = 3.00 });
            newOrder.AddItem(new FoodItem() { Type = FoodItem.TypeValue.FrenchFries, Price = 2.00 });

            Combo newCombo = new Combo()
            {
                ComboItems = new List<FoodItem>() { { new FoodItem() { Type = FoodItem.TypeValue.ChickenStrips, Price = 3.00 } }, new FoodItem() { Type = FoodItem.TypeValue.FrenchFries, Price = 2.00 }, new FoodItem() { Type = FoodItem.TypeValue.Drink, Price = 1.00 } }
            };

            // Remove the combo items from the Items list.
            newOrder.Items = newOrder.Items.Except(newCombo.ComboItems).ToList();

            Assert.Equal(2, newOrder.ItemCount);  //It should be empty 
        }

        [Theory,
            InlineData(1, 2, 3),
            InlineData(10, 10, 10)]
        public void Add_ComboPrice_Test(double one, double two, double three)// The Combo’s Price reflects the sum of the items minus 20% (theory).
        {
            Order newOrder = new Order();
            newOrder.AddItem(new FoodItem() { Type = FoodItem.TypeValue.ChickenStrips, Price = one });
            newOrder.AddItem(new FoodItem() { Type = FoodItem.TypeValue.FrenchFries, Price = two });
            newOrder.AddItem(new FoodItem() { Type = FoodItem.TypeValue.Drink, Price = three });
            double testSum = (one + two + three)*0.8;
            Assert.Equal(testSum, newOrder.Total);
        }
    }
}
