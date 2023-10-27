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

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Health
        { get { return health; }
          set {health = value; }
         }
        public int MaxHealth
        {
            get { return max_health; }
            set { max_health = value; }
        }
        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }
        public int Dexterity
        {
            get { return dexterity; }
            set { dexterity = value; }
        }
        public int Defence
        {
            get { return defence; }
            set { defence = value; }
        }
        public int Speed
        {
            get { return speed; }   
            set { speed = value; }
        }
        public int Level
        {
            get { return level; }   
            set { level = value; }
        }
        public int XPPoints
        {
            get { return xp_points; }
            set { xp_points = value; }
        }
        public int StatPoints
        {
            get { return statPoints; }
            set { statPoints = value; }
        }
        public int Potions
        {
            get { return potions; }
            set { potions = value; }
        }
        public int Money
        {
            get { return money; }
            set { money = value; }
        }

      
        public Entity(string name, int health, int max_health, int level, int attack) // Enemy
        {
            this.health = health;
            this.max_health = max_health;
            this.level = level;
            this.attack = attack;
            this.name = name;
        }

        public Entity(string name, int max_health, int health,  int attack, int strength, int dexterity, int defence,int speed,  int level,int xppoints, int statPoints, int potions, int money)//player
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
