using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocRPG
{
    public partial class FightingScene : Form
    {
        private GameManager gameManager = new GameManager();
        public static FightingScene date;
        internal GameManager GameManager { get => gameManager; set => gameManager = value; }

        public FightingScene()
        {
            InitializeComponent();
            date = this;
        }
        private void InitializeGame()
        {
            GB_Game.Visible = true;
            GB_StartGame.Visible = false;
        }
        private void BTN_Start_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TB_Name.Text) != true)
            {
                string Name = TB_Name.Text;
                string Class = "Knight";

                if (RB_Knight.Checked == true)
                    Class = "Knight";
                if (RB_Barbarian.Checked == true)
                    Class = "Barbarian";
                if (RB_Archer.Checked == true)
                    Class = "Archer";
                gameManager.CreatePlayer(Name,Class);
                InitializeGame();
                gameManager.CreateEnemy();
                
                gameManager.changeImg(this);

                gameManager.UpdateHealthP(this);
                gameManager.UpdateHealthE(this);
                gameManager.UpdateLevelE(this);
                gameManager.UpdateLevelP(this);
                LB_Action.Items.Add("Turn " + gameManager.Turn);
                LB_Action.Items.Add($"{gameManager.Player.Name} Turn");
                this.Height = 379;
            }
            else
                MessageBox.Show("Please name your character");
            
        }
       
        // BTN MouseHover and Leave
        private void BTN_Attack_MouseHover(object sender, EventArgs e)
        {
            TB_Detalii.Visible = true;
            TB_Detalii.Text = "Attack dmg: " + Convert.ToString(gameManager.Player.Attack);
        }
        private void BTN_Dodge_MouseHover(object sender, EventArgs e)
        {
            TB_Detalii.Visible = true;
            TB_Detalii.Text = "Chance of dodging is equal to your speed. It is currently " + Convert.ToString(GameManager.Player.Speed) + "% ";
        }
        private void BTN_Block_MouseHover(object sender, EventArgs e)
        {
            TB_Detalii.Visible = true;
            if(GameManager.Player.Strength <50)
            TB_Detalii.Text = "Block a percentage based on strength of the incoming dmg. Curently " + Convert.ToString(GameManager.Player.Strength) + "%";
            else
                TB_Detalii.Text = "Block a percentage based on strength of the incoming dmg. Curently 50% (MAX)";
        }
        private void BTN_Heal_MouseHover(object sender, EventArgs e)
        {
            TB_Detalii.Visible = true;
            TB_Detalii.Text = $"Number of potions:{GameManager.Player.Potions} (+{GameManager.Player.HpPotion} HP)";
        }
        private void BTN_Counter_MouseMove(object sender, EventArgs e)
        {
            TB_Detalii.Visible = true;
            TB_Detalii.Text = "Chance of counter is equal to your dexterity. It is currently "+Convert.ToString(GameManager.Player.Dexterity) + "% ";
        }
        private void BTN_Attack_MouseLeave(object sender, EventArgs e)
        {
            TB_Detalii.Visible = false;

        }
        private void BTN_Dodge_MouseLeave(object sender, EventArgs e)
        {
            TB_Detalii.Visible = false;

        }
        private void BTN_Block_MouseLeave(object sender, EventArgs e)
        {
            TB_Detalii.Visible = false;
        }
        private void BTN_Heal_MouseLeave(object sender, EventArgs e)
        {
            TB_Detalii.Visible = false;
        }
        private void BTN_Counter_MouseLeave(object sender, EventArgs e)
        {
            TB_Detalii.Visible = false;
        }
        //BTN Clicks
        private void BTN_EnemyTurn_Click(object sender, EventArgs e)
        {
            gameManager.EnemyTurn(this,"Attack");

            BTN_EnemyTurn.Enabled = false;
            BTN_Attack.Enabled = true;
            BTN_Block.Enabled = true;
            BTN_Counter.Enabled = true;
            BTN_Heal.Enabled = true;
            BTN_Dodge.Enabled = true;
            gameManager.Turn++;

            LB_Action.Items.Add("----------------------------------------------------");
            LB_Action.Items.Add("Turn " + gameManager.Turn);
            LB_Action.Items.Add(gameManager.Player.Name + " Turn");
        }
        private void BTN_Attack_Click(object sender, EventArgs e)
            {
            int attack = gameManager.Player.Attack ; // attack dmg formula
            gameManager.Enemy.Health -= attack; // dmg given

            LB_Action.Items.Add("You dealt " + Convert.ToString (attack) + " damage!");

            if (gameManager.Enemy.Health <= 0)// defeated enemy
            {
                gameManager.UpdateHealthE(this);
                if (GameManager.Player.Level<90)//max lvl 90
                {
                    MessageBox.Show("Enemy Defeted! " + "Gained " + Convert.ToString(gameManager.Enemy.Level * 4) + " XP!");
                    gameManager.Player.XPPoints += gameManager.Enemy.Level * 4;
                    while (gameManager.Player.XPPoints >= gameManager.Player.Level * 10)//level up
                    {
                        gameManager.Player.XPPoints -= gameManager.Player.Level * 10;
                        gameManager.Player.Level += 1;
                        MessageBox.Show("Leveled up! Gained " + (2 * GameManager.Player.Level + 1) + " stat points. Your LVL is now " + gameManager.Player.Level);
                        gameManager.Player.StatPoints += 2 * GameManager.Player.Level + 1;
                    }

                    if (gameManager.Player.StatPoints != 0)//available stats shower
                        label1.Show();

                    LB_Action.Items.Clear();
                    gameManager.Turn = 1;
                    LB_Action.Items.Add("Turn " + gameManager.Turn);

                    gameManager.UpdateLevelP(this);
                }else
                {
                    MessageBox.Show("Enemy Defeted! You are are max Level! You dont gain any xp.");
                }

                LB_Action.Items.Clear();

                //Gold added
                int goldFromEnemy = gameManager.Enemy.Level * 10;
                MessageBox.Show($"You have gained {goldFromEnemy} gold for slaying LVL {gameManager.Enemy.Level} {gameManager.Enemy.Name} ");
                gameManager.Player.Money += goldFromEnemy;
                
                //New turn start
                gameManager.Turn = 1;
                LB_Action.Items.Add("Turn " + gameManager.Turn);

                gameManager.CreateEnemy();
                gameManager.changeImg(this);
                gameManager.UpdateHealthE(this);
                gameManager.UpdateLevelE(this);

                LB_Action.Items.Add(gameManager.Player.Name + " Turn");
            }
            else
            {
                gameManager.UpdateHealthE(this);
                BTN_EnemyTurn.Enabled = true;
                BTN_Attack.Enabled = false;
                BTN_Block.Enabled = false;
                BTN_Counter.Enabled = false;
                BTN_Heal.Enabled = false;
                BTN_Dodge.Enabled = false;
            }

            gameManager.UpdateHealthP(this);
        }
        private void BTN_Heal_Click(object sender, EventArgs e)
        {
            int healAmmount = GameManager.Player.HpPotion;
            if (gameManager.Player.Health != gameManager.Player.MaxHealth)
            {
                gameManager.Player.Health += healAmmount;
                gameManager.Player.Potions -= 1;

                if (gameManager.Player.Health > gameManager.Player.MaxHealth)
                {
                    LB_Action.Items.Add($"You healed {Convert.ToString(healAmmount+ (gameManager.Player.MaxHealth-gameManager.Player.Health) )} HP");
                    gameManager.Player.Health = gameManager.Player.MaxHealth;
                }
                else
                    LB_Action.Items.Add($"You healed {healAmmount} HP");
                gameManager.UpdateHealthP(this);
                BTN_Heal.Enabled = false;
            }
            else
                MessageBox.Show("Your health is full.");
        }
        private void BTN_Stats_Click(object sender, EventArgs e)
        {
            Stats Stats = new Stats();
            Stats.Show();
        }

        private void BTN_Dodge_Click(object sender, EventArgs e)
        {
            LB_Action.Items.Add("You try to dodge.");
            gameManager.EnemyTurn(this, "Dodge");

            BTN_EnemyTurn.Enabled = false;
            BTN_Attack.Enabled = true;
            BTN_Block.Enabled = true;
            BTN_Counter.Enabled = true;
            BTN_Heal.Enabled = true;
            BTN_Dodge.Enabled = true;
            gameManager.Turn++;

            LB_Action.Items.Add("----------------------------------------------------");
            LB_Action.Items.Add("Turn " + gameManager.Turn);
            LB_Action.Items.Add(gameManager.Player.Name + " Turn");
        }

        private void BTN_Block_Click(object sender, EventArgs e)
        {
            gameManager.EnemyTurn(this, "Block");

            BTN_EnemyTurn.Enabled = false;
            BTN_Attack.Enabled = true;
            BTN_Block.Enabled = true;
            BTN_Counter.Enabled = true;
            BTN_Heal.Enabled = true;
            BTN_Dodge.Enabled = true;
            gameManager.Turn++;

            LB_Action.Items.Add("----------------------------------------------------");
            LB_Action.Items.Add("Turn " + gameManager.Turn);
            LB_Action.Items.Add(gameManager.Player.Name + " Turn");
        }

        private void BTN_Counter_Click(object sender, EventArgs e)
        {
            LB_Action.Items.Add("You try to counter the attack.");
            gameManager.EnemyTurn(this, "Counter");

            BTN_EnemyTurn.Enabled = false;
            BTN_Attack.Enabled = true;
            BTN_Block.Enabled = true;
            BTN_Counter.Enabled = true;
            BTN_Heal.Enabled = true;
            BTN_Dodge.Enabled = true;
            gameManager.Turn++;

            LB_Action.Items.Add("----------------------------------------------------");
            LB_Action.Items.Add("Turn " + gameManager.Turn);
            LB_Action.Items.Add(gameManager.Player.Name + " Turn");
        }

        private void BTN_Shop_Click(object sender, EventArgs e)
        {
            Shop Shop =new Shop();
            Shop.Show();
        }

        private void BTN_Inventory_Click(object sender, EventArgs e)
        {
            Inventory inventory =new Inventory();
            inventory.Show();
        }

        private void FightingScene_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter Out = new StreamWriter(@"..\..\Resources\Inventory.txt");
            Out.WriteLine(gameManager.Player.InventoryList.Count);
            foreach (var item in gameManager.Player.InventoryList)//id,name,type,quantity,price,availableClass,requirementStat,requirement,addedMXH,addedATK,addedSTR,addedDEX,addedSPD,addedDEF
                Out.WriteLine($"{item.Key};{item.Value.Name};{item.Value.ItemClass};{item.Value.ItemType};{item.Value.Quantity};{item.Value.Price};{item.Value.AvailableClass};{item.Value.RequiredLevel};{item.Value.AddedATK};{item.Value.AddedDEF}");
            Out.Close();
        }

        private void BTN_Saves_Click(object sender, EventArgs e)
        {
            //curent width = 857; height = 368;
            if (this.Height != 500)
                this.Height = 500;
            else
                this.Height = 368;
        }

        private void FightingScene_MaximumSizeChanged(object sender, EventArgs e)
        {
            this.Width = 896;
            this.Height = 379;
        }
    }
}
