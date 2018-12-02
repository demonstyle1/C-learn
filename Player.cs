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

        /*ItemFood[] playerFoodbag = new ItemFood[5];  //Player Foodbag
        ItemPotion[] playerPotions = new ItemPotion[5]; //player potion bag
        ItemEquipment[] playerBckpack = new ItemEquipment[10]; //player weapon/armor pack */

        public string PlayerName
        {

            get { return this.playerName; }
            set { this.playerName = value; }
            
        }

        public int PlayerLevel
        {

            get { return this.playerLevel; }
            set { this.playerLevel = value; }

        }

        public int PlayerHP
        {

            get { return this.playerHP; }
            set { this.playerHP = value; }

        }

        public int PlayerAtk
        {

            get { return this.playerAtk; }
            set { this.playerAtk = value; }

        }

        public int PlayerDef
        {

            get { return this.playerDef; }
            set { this.playerDef = value; }

        }

        public int PlayerSpd
        {

            get { return this.playerSpd; }
            set { this.playerSpd = value; }

        }

        public Player(string playerName, int playerLevel, int playerHP, int playerAtk, int playerDef, int playerSpd)
        {

            this.playerName = playerName;
            this.playerLevel = playerLevel;
            this.playerHP = playerHP;
            this.playerAtk = playerAtk;
            this.playerDef = playerDef;
            this.playerSpd = playerSpd;

        }

        public void CreatePlayer() //player creation
        {

            Player defaultPlayer = new Player("Default", 1, 10, 5, 5, 5);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("       Creating new Character      ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("\nPlease enter your character Name:");
            defaultPlayer.PlayerName = Console.ReadLine();
            Console.WriteLine("You chose: " + defaultPlayer.PlayerName);
            Console.WriteLine("Character created!\n");

        }
                
    }
}
