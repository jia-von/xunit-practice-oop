using System;

namespace XUnitOOPPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Order newOrder = new Order();
            newOrder.AddItem(new FoodItem() { FoodItems = FoodItem.TypeFood.ChickenStrips });
        }
    }
}
