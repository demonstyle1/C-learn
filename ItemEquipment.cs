using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ItemEquipment
    {

        string equipName;
        string equipType;
        string equipDescription;
        int equipLevel;
        int equipHp;
        int equipAtk;
        int equipDef;
        int equipSpd;

        public ItemEquipment(string pEquipName, string pEquipType, string pEquipDescription, int pEquipLevel, int pEquipHp, int pEquipAtk, int pEquipDef, int pEquipSpd)
        {

            equipName = pEquipName;
            equipType = pEquipType;
            equipDescription = pEquipDescription;
            equipLevel = pEquipLevel;
            equipHp = pEquipHp;
            equipAtk = pEquipAtk;
            equipDef = pEquipDef;
            equipSpd = pEquipSpd;

        }
        
    }
}
