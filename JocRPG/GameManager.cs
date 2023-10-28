using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocRPG
{
    internal class GameManager
    {
        //int EnemyLevel=1;
        public Entity Player = new Entity("S", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0);//Name,Max_Hp,HP,ATK,STR,DEX,DEF,SPD,LVL,XPPoints,StatPts,Potions
        public Entity Enemy = new Entity("Nume", 20, 20, 1, 1); //string name, int health, int max_health, int level, int attack
        public Item Item = new Item(1,"Excalibur", "Sword", 300, 500,"Knight","STR",3,0,0,0,0,0,1);//id,name,type,quantity,price,availableClass,requirementStat,requirement,addedMXH,addedATK,addedSTR,addedDEX,addedSPD,addedDEF)

        public int Turn = 1;

        //Player creater
        public void CreatePlayer()
        {
            Player.Name = "Robert";
            Player.MaxHealth = 20;
            Player.Health = 20;
            Player.Attack = 1;
            Player.Strength = 1;
            Player.Dexterity = 30;
            Player.Speed = 30;
            Player.Defence = 149;// 3 points = 1%
            Player.Level = 1;
            Player.StatPoints = 50000;
            Player.Potions = 30;
            Player.Money = 999999;

            Player.AddedATK = 0;
            Player.AddedSTR = 0;
            Player.AddedSPD = 0;
            Player.AddedMXH = 0;
            Player.AddedDEF = 0;

        }
        // Enemy creater
        public void CreateEnemy()
        {
            var random = new Random();
            int Enemy_Number = random.Next(1, 3);
            //EnemyLevel = Convert.ToInt32(kills / 2);
            switch (Enemy_Number)
            {
                case 1:
                    Enemy.Name = "Goblin";
                    Enemy.MaxHealth = 14 + (Player.Level * 2);
                    Enemy.Health = Enemy.MaxHealth;
                    Enemy.Level = Player.Level;
                    Enemy.Attack = 2 + (Player.Level * 2);
                    break;

                case 2:
                    Enemy.Name = "Orc";
                    Enemy.MaxHealth = 16 + (Player.Level * 2);
                    Enemy.Health = Enemy.MaxHealth;
                    Enemy.Level = Player.Level;
                    Enemy.Attack = 2 + (Player.Level * 2);
                    break;

                case 3:
                    Enemy.Name = "Orc King";
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
            form1.LB_NameP.Text = "LVL " + Player.Level.ToString() + " " + Player.Name.ToString() + " ( XP: " + Player.XPPoints + "/" + Player.Level * 10 + " )";
        }
        public void UpdateLevelE(FightingScene form1)
        {
            form1.LB_NumeE.Text = "LVL " + Enemy.Level.ToString() + " " + Enemy.Name.ToString();
        }

        //Enemy Turn
        public void EnemyTurn(FightingScene form1, string move)
        {
            switch(move)
            {
                case "Attack":
                    int attack=Convert.ToInt32(Enemy.Attack*(Convert.ToDouble(Player.Defence/3)/100));//dmg taken formula: Enemy Attack * ( (PlayerDef/3)/100 ) -> percentage

            form1.LB_Action.Items.Add(Enemy.Name + " Turn");
            form1.LB_Action.Items.Add(Enemy.Name + " attacked with " + Convert.ToString(attack )+ " DMG ");
            Player.Health -= attack;
            if (Player.Health < 0)
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
                    if (form1.GameManager.Player.Speed >= 50)
                        stat1 = 50;
                    else stat1= form1.GameManager.Player.Speed;


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
                        form1.LB_Action.Items.Add(Enemy.Name + " attacked with " + Convert.ToString(Enemy.Attack *2) + " DMG ");
                        Player.Health -= Enemy.Attack *2;
                        if (Player.Health < 0)
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
                   
                    //exceding max stat
                    int stat2;
                    if (Player.Strength > 70)
                        stat2= 70;
                    else stat2=Player.Strength;
                         
                    if (stat2 < 70)
                        {
                            form1.LB_Action.Items.Add(Enemy.Name + " attacked with " + Convert.ToString(Enemy.Attack - Convert.ToInt32(Player.Strength / 100 * Enemy.Attack)) + " DMG ");
                            Player.Health -=Convert.ToInt32(Convert.ToDouble(Enemy.Attack) - (Player.Strength / 100 * Enemy.Attack));
                            if (Player.Health < 0)
                            {
                                MessageBox.Show("You Lost");
                                form1.Close();
                            }
                            form1.LB_HPP.Text = "HP: " + Player.Health.ToString() + "/" + Player.MaxHealth;
                        }
                        else
                        {
                            form1.LB_Action.Items.Add(Enemy.Name + " attacked with " + Convert.ToString(Convert.ToInt32(Enemy.Attack*0.5)) + " DMG ");
                            Player.Health -= Convert.ToInt32(Enemy.Attack * 0.5);
                            if (Player.Health < 0)
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
                        form1.LB_Action.Items.Add("You dealt"+ Enemy.Attack /0.5 + "damage !");
                        Enemy.Health -= Convert.ToInt32(Enemy.Attack / 0.5);
                        form1.LB_HPE.Text = "HP: " + Enemy.Health.ToString() + "/" + Enemy.MaxHealth;
                    }
                    else
                    {
                        form1.LB_Action.Items.Add(Enemy.Name + " Turn");
                        form1.LB_Action.Items.Add("You failed to counter!");
                        form1.LB_Action.Items.Add("Damage is amplified! ");

                        form1.LB_Action.Items.Add(Enemy.Name + " attacked with " + Convert.ToString(Enemy.Attack * 2) + " DMG ");
                        Player.Health -= Enemy.Attack * 2;
                        if (Player.Health < 0)
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
        public string checkPath(string Name)
        {
            switch(Name)
            {
                case "Goblin":
                   Name = "..\\..\\Resources\\Goblin.png";
                    break;  
            }
            return Name; 
        }
        public void changeImg(FightingScene form1)
        {
           form1.PB_Enemy.ImageLocation = @checkPath(form1.GameManager.Enemy.Name);
        }
    }


}
