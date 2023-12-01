using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocRPG
{
    internal class Item
    {
        private string name;
        private string type;
        private string itemType;//weapon/armor/junk
        private int price;
        private int quantity;
        private string availableClass;
        private int requiredLevel;
        private int requirement;
        private string requirementStat;

        
        private int addedMXH;
        private int addedATK;
        private int addedSTR;
        private int addedDEX;
        private int addedSPD;
        private int addedDEF;

        //private List<int> addedStats = new List<int> { addedMXH, addedATK, addedSTR, addedDEX, addedSPD, addedDEF };

        public Item(string name, string itemType,string type, int quantity, int price, string availableClass, int requiredLevel, string requirementStat, int requirement,  int addedMXH, int addedATK, int addedSTR, int addedDEX, int addedSPD, int addedDEF )
        {
            this.name = name;
            this.itemType = itemType;
            this.type = type;
            this.quantity = quantity;
            this.price = price;
            this.availableClass = availableClass;
            this.requiredLevel = requiredLevel;
            this.requirementStat = requirementStat;
            this.requirement = requirement;
            this.addedMXH = addedMXH;
            this.addedSTR = addedSTR;
            this.addedDEX = addedDEX;
            this.addedSPD = addedSPD;
            this.addedDEF = addedDEF;
            this.addedATK = addedATK;
        }

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string ItemType { get => itemType; set => itemType = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string AvailableClass { get => availableClass; set => availableClass = value; }
        public int RequiredLevel { get => requiredLevel; set => requiredLevel = value; }
        public int Requirement { get => requirement; set => requirement = value; }
        public string RequiredStat { get => requirementStat; set => requirementStat = value; }
        public  int AddedMXH { get => addedMXH; set => addedMXH = value; }
        public  int AddedSTR { get => addedSTR; set => addedSTR = value; }
        public  int AddedDEX { get => addedDEX; set => addedDEX = value; }
        public  int AddedSPD { get => addedSPD; set => addedSPD = value; }
        public  int AddedDEF { get => addedDEF; set => addedDEF = value; }
        public  int AddedATK { get => addedATK; set => addedATK = value; }
    }
}
