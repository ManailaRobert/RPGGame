﻿using System;
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
        private int id;
        private int price;
        private int quantity;
        private String availableClass;
        private int requirement;
        private String requirementStat;

        private int bonus;
        private String bonusStat;

        public Item(int id,string name, string type, int quantity, int price,  string availableClass, string requirementStat ,int requirement)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.quantity = quantity;
            this.price = price;
            this.availableClass = availableClass;
            this.requirementStat = requirementStat;
            this.requirement = requirement;
        }

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string AvailableClass { get => availableClass; set => availableClass = value; }
        public int Requirement { get => requirement; set => requirement = value; }
        public string RequirementStat { get => requirementStat; set => requirementStat = value; }
        public int Id { get => id; set => id = value; }
        public int Bonus { get => bonus; set => bonus = value; }
        public string BonusStat { get => bonusStat; set => bonusStat = value; }
    }
}
