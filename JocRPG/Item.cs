using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JocRPG
{
    internal class Item
    {
        private String name;
        private string type;
        private int price;
        private int quantity;
        private String availableClass;
        private int requirement;
        private String requirementStat;

        public Item(string name, string type, int quantity, int price,  string availableClass, string requirementStat ,int requirement)
        {
            this.name = name;
            this.type = type;
            this.price = price;
            this.quantity = quantity;
            this.availableClass = availableClass;
            this.requirement = requirement;
            this.requirementStat = requirementStat;
        }

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string AvailableClass { get => availableClass; set => availableClass = value; }
        public int Requirement { get => requirement; set => requirement = value; }
        public string RequirementStat { get => requirementStat; set => requirementStat = value; }


    }
}
