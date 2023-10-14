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
        public Entity Player = new Entity("S", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);//Name,Max_Hp,HP,ATK,STR,DEX,DEF,SPD,LVL,XPPoints,StatPts,Potions
        public Entity Enemy = new Entity("Nume", 20, 20, 1, 1); //string name, int health, int max_health, int level, int attack
        public int Turn = 1;

        //Player creater
        public void CreatePlayer()
        { Player.Name = "Robert";
            Player.MaxHealth = 20;
            Player.Health = 20;
            Player.Attack = 4;
            Player.Strength = 49;
            Player.Dexterity = 50;
            Player.Defence = 1;
            Player.Speed = 50;
            Player.Level = 1;
            Player.StatPoints = 50000;
            Player.Potions = 30;
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
                    Enemy.Attack = 1 + (Player.Level * 2);
                    break;

                case 2:
                    Enemy.Name = "Orc";
                    Enemy.MaxHealth = 16 + (Player.Level * 2);
                    Enemy.Health = Enemy.MaxHealth;
                    Enemy.Level = Player.Level;
                    Enemy.Attack = 1 + (Player.Level * 2);
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
            form1.LB_Action.Items.Add(Enemy.Name + " Turn");
            form1.LB_Action.Items.Add(Enemy.Name + " attacked with " + Convert.ToString(Enemy.Attack) + " DMG ");
            Player.Health -= Enemy.Attack;
            if (Player.Health < 0)
            {
                MessageBox.Show("You Lost");
                form1.Close();
            }
            form1.LB_HPP.Text = "HP: " + Player.Health.ToString() + "/" + Player.MaxHealth;
                    break;

                case "Dodge":
                    var random = new Random();
                    int chance = random.Next(1, 100);
                    if (chance< form1.GameManager.Player.Speed)
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
                    if (Player.Strength < 50)
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
                    int chance2 = random2.Next(1, 100);
                    if (chance2 < form1.GameManager.Player.Dexterity)
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
                   Name = "D:\\1\\JocRPG\\Img_JocRPG\\Goblin.png";
                    break;
                
            }
            return Name; 
        }
        public void changeImg(FightingScene form1)
        {
           form1.PB_Enemy.ImageLocation = checkPath(form1.GameManager.Enemy.Name);
        }
    }


}
