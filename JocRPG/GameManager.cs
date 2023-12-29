using JocRPG.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocRPG
{
    internal class GameManager
    {
        public Entity Player = new Entity("Default","Default", 0, 0, 0, 0, 0, 0, 0, 0, 0,0, 0, 0,0);//Name,Max_Hp,HP,ATK,STR,DEX,DEF,SPD,LVL,XPPoints,StatPts,Potions
        public Entity Enemy = new Entity("Nume","Type", 20, 20, 1, 1); //string name, int health, int max_health, int level, int attack

        Dictionary<int, Item> inventoryItemList = new Dictionary<int, Item>();
        public int killCounter = 0;
        public int Turn = 1;

        internal Dictionary<int, Item> InventoryItemList { get => inventoryItemList; set => inventoryItemList = value; }

        //Player creater
        public void CreatePlayer(string Name,string Class)
        {
            Player.Name = Name;

            Player.PlayerClass = Class;
            switch(Class)
            {
                case "Knight":
                    Player.MaxHealth = 25;
                    Player.Health = Player.MaxHealth;
                    Player.Attack = 3;
                    Player.Strength = 3; // max 70
                    Player.Dexterity = 2;// max 50:
                    Player.Speed = 1; // max 50:
                    Player.Defence = 4;// max 210: 3 points = 1%
                    Player.Level = 1; // max 90
                    Player.StatPoints = 0;
                    Player.Potions = 4;
                    Player.HpPotion = 5;
                    Player.Money = 500;

                    Player.AddedDEF = 0;
                    break;
                case "Barbarian":
                    Player.MaxHealth = 15;
                    Player.Health = Player.MaxHealth;
                    Player.Attack = 5;
                    Player.Strength = 3; // max 70
                    Player.Dexterity = 2;// max 50:
                    Player.Speed = 1; // max 50:
                    Player.Defence = 4;// max 210: 3 points = 1%
                    Player.Level = 1; // max 90
                    Player.StatPoints = 0;
                    Player.Potions = 2;
                    Player.HpPotion = 5;
                    Player.Money = 0;

                    Player.AddedDEF = 0;
                    break;
                case "Archer":
                    Player.MaxHealth = 17;
                    Player.Health = Player.MaxHealth;
                    Player.Attack = 3;
                    Player.Strength = 2; // max 70
                    Player.Dexterity = 3;// max 50:
                    Player.Speed = 1; // max 50:
                    Player.Defence = 2;// max 210: 3 points = 1%
                    Player.Level = 1; // max 90
                    Player.StatPoints = 0;
                    Player.Potions = 5;
                    Player.HpPotion = 6;
                    Player.Money = 0;

                    Player.AddedDEF = 0;
                    break;
            }
        }
        // Enemy creater
        public void CreateEnemy()
        {
            var random = new Random();
            int Enemy_Number = random.Next(1, 1);
            switch (Enemy_Number)
            {
                case 1:
                    Enemy.Name = "Goblin";
                    Enemy.Type = "Goblin";
                    Enemy.MaxHealth = 14 + (Player.Level * 2);
                    Enemy.Health = Enemy.MaxHealth;
                    Enemy.Level = Player.Level;
                    Enemy.Attack = 4 + (Player.Level * 2);
                    break;

                case 2: //assets not made
                    Enemy.Name = "Orc";
                    Enemy.Type = "Orc";
                    Enemy.MaxHealth = 16 + (Player.Level * 2);
                    Enemy.Health = Enemy.MaxHealth;
                    Enemy.Level = Player.Level;
                    Enemy.Attack = 2 + (Player.Level * 2);
                    break;

                case 3: // assets not made
                    Enemy.Name = "Orc King";
                    Enemy.Type = "Boss";
                    Enemy.MaxHealth = 20;
                    Enemy.Health = 20;
                    Enemy.Level = Player.Level;
                    Enemy.Attack = 1;
                    break;
            }
        }

        //Health updates
        public void UpdateHealthP(FightingScene form1)
        {
            form1.LB_HPP.Text = "HP: " + Player.Health.ToString() + "/" + Player.MaxHealth;
        }
        public void UpdateHealthE(FightingScene form1)
        {
            if (Enemy.Health < 0)
            {
                form1.LB_HPE.Text = "HP: 0/" + Enemy.MaxHealth;
            }
            else
                form1.LB_HPE.Text = "HP: " + Enemy.Health.ToString() + "/" + Enemy.MaxHealth;
        }
        //LVL updates
        public void UpdateLevelP(FightingScene form1)
        {
            form1.LB_NameP.Text = $"LVL {Player.Level.ToString()} {Player.Name.ToString()} (XP: {Player.XPPoints}/{Player.Level *10})";
        }
        public void UpdateLevelE(FightingScene form1)
        {
            form1.LB_NumeE.Text = "LVL " + Enemy.Level.ToString() + " " + Enemy.Name.ToString();
        }

        //Enemy Turn
        public void EnemyTurn(FightingScene form1, string move)
        {
            int attack1 = Convert.ToInt32(Enemy.Attack * (Convert.ToDouble((Player.Defence+Player.AddedDEF) / 3) / 100));//dmg taken formula: Enemy Attack * ( (PlayerDef/3)/100 ) -> percentage
            int attack2 = Convert.ToInt32(Enemy.Attack*2 * (Convert.ToDouble((Player.Defence + Player.AddedDEF) / 3) / 100)); //amplified dmg 2X
            int attack3 = Convert.ToInt32(Enemy.Attack/2 * (Convert.ToDouble((Player.Defence + Player.AddedDEF) / 3) / 100)); //half dmg given 
           if(attack1 <1) attack1 = 1;
           if(attack2 <1) attack2 = 1;
           if(attack3 <1) attack3 = 1;
            
            switch (move)
            {
                case "Attack":

            form1.LB_Action.Items.Add(Enemy.Name + " Turn");
            form1.LB_Action.Items.Add(Enemy.Name + " attacked with " + Convert.ToString(attack1)+ " DMG ");
            Player.Health -= attack1;
            if (Player.Health <= 0)
            {
                MessageBox.Show("You Lost");
                form1.Close();
            }
            form1.LB_HPP.Text = "HP: " + Player.Health.ToString() + "/" + Player.MaxHealth;
                    break;

                case "Dodge":
                    var random = new Random();
                    int stat1;

                    //for exceding the max stat
                    if (Player.Speed >= 50)
                        stat1 = 50;
                    else stat1= Player.Speed;


                    int chance = random.Next(1, 100);
                    if (chance< stat1)
                    {
                        form1.LB_Action.Items.Add(Enemy.Name + " Turn");
                        form1.LB_Action.Items.Add("You dodged the attack! ");
                    }
                    else
                    {
                        form1.LB_Action.Items.Add(Enemy.Name + " Turn");
                        form1.LB_Action.Items.Add("You failed to dodge!");
                        form1.LB_Action.Items.Add("Damage is amplified! ");
                        form1.LB_Action.Items.Add(Enemy.Name + " attacked with " + Convert.ToString(attack2) + " DMG ");
                        Player.Health -= attack2;
                        if (Player.Health <= 0)
                        {
                            MessageBox.Show("You Lost");
                            form1.Close();
                        }
                        form1.LB_HPP.Text = "HP: " + Player.Health.ToString() + "/" + Player.MaxHealth;
                    }
                  //  form1.GameManager.Player.Speed 
                    break;

                case "Block":
                    form1.LB_Action.Items.Add("You block the attack");
                    form1.LB_Action.Items.Add(Enemy.Name + " Turn");

                    var random3 = new Random();
                    int chance3= random3.Next(1, 100);
                    //exceding max stat
                    int stat2;
                    if (Player.Strength > 70)
                        stat2= 70;
                    else stat2=Player.Strength;
                         
                    if (chance3 < stat2)
                        {
                        form1.LB_Action.Items.Add(Enemy.Name + " Turn");
                        form1.LB_Action.Items.Add("You blocked the attack! ");
                    }
                        else
                        {
                            form1.LB_Action.Items.Add(Enemy.Name + " attacked with " + Convert.ToString(attack1) + " DMG ");
                            Player.Health -= attack1;
                            if (Player.Health <= 0)
                            {
                                MessageBox.Show("You Lost");
                                form1.Close();
                            }
                            form1.LB_HPP.Text = "HP: " + Player.Health.ToString() + "/" + Player.MaxHealth;
                        }
                    
                    
                    break;

                case "Counter":
                    var random2 = new Random();

                    //exceding max stat
                    int stat3;
                    if (form1.GameManager.Player.Dexterity >= 50)
                        stat3 = 50;
                    else stat3 = form1.GameManager.Player.Dexterity;
                    
                    int chance2 = random2.Next(1, 100);
                    if (chance2 < stat3)
                    {
                        form1.LB_Action.Items.Add(Enemy.Name + " Turn");
                        form1.LB_Action.Items.Add("You succesfully countered the attack! ");
                        form1.LB_Action.Items.Add("You dealt"+ attack3 + "damage !");
                        Enemy.Health -= attack3;
                        form1.LB_HPE.Text = "HP: " + Enemy.Health.ToString() + "/" + Enemy.MaxHealth;
                    }
                    else
                    {
                        form1.LB_Action.Items.Add(Enemy.Name + " Turn");
                        form1.LB_Action.Items.Add("You failed to counter!");
                        form1.LB_Action.Items.Add("Damage is amplified! ");

                        form1.LB_Action.Items.Add(Enemy.Name + " attacked with " + Convert.ToString(attack2) + " DMG ");
                        Player.Health -= attack2;
                        if (Player.Health <= 0)
                        {
                            MessageBox.Show("You Lost");
                            form1.Close();
                        }
                        form1.LB_HPP.Text = "HP: " + Player.Health.ToString() + "/" + Player.MaxHealth;
                    }
                    break;
            }
        }

        //Img selector and changer
        public string checkPath(string Type,int lvl)
        {
            var random = new Random();
            switch (Type)
            {
                case "Goblin":
                    int Pv=0,Hv=0,Sv;
                    if (lvl == 1) { Pv = 0; Hv = 0; }
                    if (lvl == 2) { Pv = random.Next(1, 3); Hv = 0; }
                    if (lvl == 3) { Pv = random.Next(1, 3); Hv = random.Next(1, 3); }
                    Sv=random.Next(0, 2);
                    Type = $"..\\..\\Resources\\Goblin\\{lvl}.Goblin_{random.Next(1,3)}-Av{random.Next(1,4)}-Pv{Pv}-Hv{Hv}-Sv{Sv}.png";
                    
                    break;


            }
            return Type; 
        }
        public void changeImg(FightingScene form1)
        {
            int lvl;
            if (FightingScene.date.GameManager.Player.Level == 90)
                lvl = 3;
            else
                lvl=FightingScene.date.GameManager.Player.Level/30+1;//every 30 lvls the img goes to next lvl of enemy 
            
            form1.PB_Enemy.ImageLocation = @checkPath(form1.GameManager.Enemy.Type,lvl);

        }
    }


}
