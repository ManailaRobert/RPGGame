using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JocRPG
{
    internal class Entity
    {
        private string name;
        private string type; //just enemy
        private string playerClass;
        private int health;
        private int max_health;
        private int attack;
        private int strength;
        private int dexterity;
        private int defence;
        private int speed;
        private int level;
        private int xp_points;
        private int statPoints;//just player
        private int potions;
        private int hpPotion;
        private int money;

        private Dictionary<int, Item> inventoryList = new Dictionary<int, Item>();
        private Dictionary<string,int> equipment = new Dictionary<string,int>();

        private int addedDEF;

       

        public int AddedDEF { get => addedDEF; set => addedDEF = value; }
        public string Name { get => name; set => name = value; }
        public int Health { get => health; set => health = value; }
        public int MaxHealth { get => max_health; set => max_health = value; }
        public int Attack { get => attack; set => attack = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Dexterity { get => dexterity; set => dexterity = value; }
        public int Defence { get => defence; set => defence = value; }
        public int Speed { get => speed; set => speed = value; }
        public int Level { get => level; set => level = value; }
        public int XPPoints { get => xp_points; set => xp_points = value; }
        public int StatPoints { get => statPoints; set => statPoints = value; }
        public int Potions { get => potions; set => potions = value; }
        public int Money { get => money; set => money = value; }
        public string Type { get => type; set => type = value; }
        public string PlayerClass { get => playerClass; set=> playerClass=value; }

        public Dictionary<int, Item> InventoryList { get => inventoryList; set => inventoryList = value; }
        public Dictionary<string, int> Equipment { get => equipment; set => equipment = value; }
        public int HpPotion { get => hpPotion; set => hpPotion = value; }

        //Creates equipment elements
        private void initializeEquipment()
        {
            //type:HeadGear,ChestPiece,Leggings,Boots
            //item class:Armor,Weapon(1H),Weapon(2H),OffHand
            equipment.Add("HeadGear", 0);
            equipment.Add("ChestPiece", 0);
            equipment.Add("Leggings", 0);
            equipment.Add("Boots", 0);
            equipment.Add("Main", 0);
            equipment.Add("OffHand", 0);
        }
        //Enemy
        public Entity(string name,string type, int health, int max_health, int level, int attack) 
        {
            this.health = health;
            this.type = type;
            this.max_health = max_health;
            this.level = level;
            this.attack = attack;
            this.name = name;
        }
        //Player
        public Entity(string name,string playerClass, int max_health, int health,  int attack, int strength, int dexterity, int defence,int speed,  int level,int xppoints, int statPoints, int potions,int hpPotion, int money)
        {
            this.name = name;
            this.playerClass = playerClass;
            this.health = health;
            this.max_health = max_health;
            this.attack = attack;
            this.strength = strength;
            this.dexterity = dexterity;
            this.speed = speed;
            this.defence = defence;
            this.level = level;
            this.xp_points= xppoints;
            this.statPoints = statPoints;
            this.potions = potions;
            this.hpPotion = hpPotion;
            this.money= money;
            initializeEquipment();
        }
    }
}
