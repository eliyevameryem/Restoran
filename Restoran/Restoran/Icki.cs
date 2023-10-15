using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    internal class Drink
    {
        public string DrinkName { get; set; }
        public int DrinkPrice { get; set; }
        public int Percentage { get; set; }

        public Drink(string drinkname, int drinkprice, int percentage)
        {
            DrinkName = drinkname;
            DrinkPrice = drinkprice;
            Percentage = percentage;
        }


        public Drink[] Drinks = new Drink[0];
        public void AddDrink(Drink drink)
        {
            Array.Resize(ref Drinks, Drinks.Length + 1);
            Drinks[Drinks.Length - 1] = drink;

        }

        public void GetAllDrinks()
        {
            if (Drinks.Length > 0)
            {
                foreach (var item in Drinks)
                {
                    Console.WriteLine($"Drinkname:{DrinkName},Drinkprice:{DrinkPrice},Percentage:{Percentage}");

                }
            }
        }

        public void GetMenuByPriceDrink(int minprice, int maxprice)
        {
            foreach(var item in Drinks)
            {
                if(drink.drinkprice >= minprice && drink.drinkprice <= maxprice)
                {
                    Console.WriteLine($"Drinkname:{DrinkName},Drinkprice:{DrinkPrice}" );

                }
            }
        }


        public void GetMenuByPriceDrink(int mindrinkprice, int maxdrinkprice)
        {
            foreach (var item in Drinks)
            {
                if (drink.drinkprice >= mindrinkprice && drink.drinkprice <= maxdrinkprice)
                {
                    Console.WriteLine($"Percentage:{Percentage}");

                }
            }
        }

    }
}
