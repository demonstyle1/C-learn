using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ItemPotion
    {

        string potionName;
        string potionDescription;
        int potionRegen;
        uint potionAmount;

        public ItemPotion(string pPotionName, string pPotionDescription, int pPotionRegen, uint pPotionAmount)
        {

            potionName = pPotionName;
            potionDescription = pPotionDescription;
            potionRegen = pPotionRegen;
            potionAmount = pPotionAmount;

        }
        
    }
}
