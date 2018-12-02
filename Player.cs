using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Player
    {

        string playerName;  //Player Stats
        int playerLevel;
        int playerHP;
        int playerAtk;
        int playerDef;
        int playerSpd;

        ItemFood[] playerFoodbag = new ItemFood[5];  //Player Foodbag
        ItemPotion[] playerPotions = new ItemPotion[5]; //player potion bag
        ItemEquipment[] playerBckpack = new ItemEquipment[10]; //player weapon/armor pack

    }
}
