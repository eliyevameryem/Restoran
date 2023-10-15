using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    internal class Food
    {
        public string FoodName { get; set; }
        public int FoodPrice { get; set; }

        public Food(string foodname, int foodprice)
        {
            FoodName = foodname;
            FoodPrice = foodprice;
        }


        public Food[] Foods = new Food[0];
        public void AddFood(Food food)
        {
            Array.Resize(ref Foods, Foods.Length + 1);
            Foods[Foods.Length - 1] = food;
        }

        public void GetAllFoods()
        {
            if (Foods.Length > 0)
            {
                foreach (var item in Foods)
                {
                    Console.WriteLine($"Foodname:{FoodName},Foodprice:{FoodPrice}");

                }
            }
        }

        public void GetMenuByPriceFood(int minprice, int maxprice)
        {
            foreach (var item in Foods)
            {
                if (foods.FoodPrice >= minprice && foods.FoodPrice <= maxprice)
                {
                    Console.WriteLine($"Foodname:{FoodName},Foodprice:{FoodPrice}");

                }
            }
        }

















    }
}
