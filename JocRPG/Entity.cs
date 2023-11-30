using System;
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
        private int money;
       

        private Dictionary<int, Item> inventoryList = new Dictionary<int, Item>();

        private int addedMXH;
        private int addedATK;
        private int addedSTR;
        private int addedDEX;
        private int addedSPD;
        private int addedDEF;

       

        public int AddedATK { get => addedATK; set => addedATK = value; }
        public int AddedSTR { get => addedSTR; set => addedSTR = value; }
        public int AddedDEX { get => addedDEX; set => addedDEX = value; }
        public int AddedSPD { get => addedSPD; set => addedSPD = value; }
        public int AddedDEF { get => addedDEF; set => addedDEF = value; }
        public int AddedMXH { get => addedMXH; set => addedMXH = value; }
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
        public Entity(string name, int max_health, int health,  int attack, int strength, int dexterity, int defence,int speed,  int level,int xppoints, int statPoints, int potions, int money)
        {
            this.name = name;
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
            this.money= money;
        }
    }
}
