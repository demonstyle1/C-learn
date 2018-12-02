using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ItemFood
    {

        string foodName;
        string foodDescription;
        int foodRegen;
        uint foodAmount;

        public ItemFood(string pFoodName, string pDescription, int pRegen, uint pAmount)
        {

            foodName = pFoodName;
            foodDescription = pDescription;
            foodRegen = pRegen;
            foodAmount = pAmount;

        }

        public void Consume() //use the food
        {

            if (foodAmount > 0) //if the player has the item
            {

                Player.hp = Player.hp + foodAmount; //heal the player by the regen amount
                foodAmount--; //reduce amount by 1

            }
            else //if the player has not enough of that item
            {

                Console.WriteLine("You dont have enough of that Item"); //player does not have enough of that item

            }

        }

        ItemFood apple = new ItemFood("Apple", "Heals a tiny amount", 5, 1);

    }
}
