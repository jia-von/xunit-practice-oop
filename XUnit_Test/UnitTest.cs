using System;
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
    }
}
