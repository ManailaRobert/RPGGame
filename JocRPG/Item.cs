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
        private string itemClass;
        private string itemType;//weapon/armor/junk
        private int price;
        private int quantity;
        private string availableClass;
        private int requiredLevel;


        private int addedATK;
        private int addedDEF;

        //private List<int> addedStats = new List<int> { addedMXH, addedATK, addedSTR, addedDEX, addedSPD, addedDEF };

        public Item(string name, string itemClass,string itemType, int quantity, int price, string availableClass, int requiredLevel, int addedATK, int addedDEF )
        {
            this.name = name;
            this.itemType = itemType;
            this.itemClass = itemClass;
            this.quantity = quantity;
            this.price = price;
            this.availableClass = availableClass;
            this.requiredLevel = requiredLevel;
            this.AddedATK = addedATK;
            this.addedDEF = addedDEF;
        }

        public string Name { get => name; set => name = value; }
        public string ItemClass { get => itemClass; set => itemClass = value; }
        public string ItemType { get => itemType; set => itemType = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string AvailableClass { get => availableClass; set => availableClass = value; }
        public int RequiredLevel { get => requiredLevel; set => requiredLevel = value; }
        public  int AddedDEF { get => addedDEF; set => addedDEF = value; }
        public int AddedATK { get => addedATK; set => addedATK = value; }
    }
}
