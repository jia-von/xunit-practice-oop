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
    }
}
