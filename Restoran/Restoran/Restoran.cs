using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    internal class Restoran
    {
        public Drink[] Drinks = new Drink[0];
        public void AddDrink(Drink drink)
        {
            Array.Resize(ref Drinks, Drinks.Length + 1);
            Drinks[Drinks.Length - 1] = drink;

        }
        public Food[] Foods = new Food[0];
        public void AddFood(Food food)
        {
            Array.Resize(ref Foods, Foods.Length + 1);
            Foods[Foods.Length - 1] = food;
        }

        Restoran menu = new Restoran();
        
        
            
        
    }
}
