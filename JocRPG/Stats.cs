﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocRPG
{
    public partial class Stats : Form
    {
        GameManager gameManager = new GameManager();
        public Stats()
        {
            InitializeComponent();
        }
        //Points added per stat
        private int MXH_p;
        private int STR_p;
        private int DEX_p;
        private int SPD_p;
        
        //Functions
        private void Form1_Load(object sender, EventArgs e)
        {
            gameManager.CreatePlayer();

            LB_Name.Text = Convert.ToString(FightingScene.date.GameManager.Player.Name);
            LB_Level.Text = "Level " + Convert.ToString(FightingScene.date.GameManager.Player.Level);
            LB_MaxHealth.Text = Convert.ToString(FightingScene.date.GameManager.Player.MaxHealth);
            LB_STR.Text = Convert.ToString(FightingScene.date.GameManager.Player.Strength);
            LB_DEX.Text = Convert.ToString(FightingScene.date.GameManager.Player.Dexterity);
            LB_SPD.Text = Convert.ToString(FightingScene.date.GameManager.Player.Speed);
            LB_STP.Text = Convert.ToString(FightingScene.date.GameManager.Player.StatPoints);

            MXH_p = 0;
            STR_p = 0;
            DEX_p = 0;
            SPD_p = 0;

            UpdateCosts();

            if (FightingScene.date.GameManager.Player.StatPoints != 0)
            {
                BTN_MXH_M.Visible = true;
                BTN_MXH_P.Visible = true;

                BTN_STR_M.Visible = true;
                BTN_STR_P.Visible = true;

                BTN_DEX_M.Visible = true;
                BTN_DEX_P.Visible = true;

                BTN_SPD_M.Visible = true;
                BTN_SPD_P.Visible = true;
            }

            VerifyPoints();
            VerifyPointsAdded();
            VerifyMaxStats();
        }
        private void VerifyMaxStats()
        {
            if(Convert.ToInt32(LB_DEX.Text)>=50)
            {
                BTN_DEX_P.Enabled= false;
            }

            if (Convert.ToInt32(LB_SPD.Text) >= 50)
            {
                BTN_SPD_P.Enabled = false;
            }

        }
       //Verify if points can be added
        private void VerifyPoints()
        {
            if (Convert.ToInt32(LB_STP.Text) >= Convert.ToInt32(LB_Cost_MXH.Text))
            {
                BTN_MXH_P.Enabled = true;
            } else
            {
                BTN_MXH_P.Enabled = false;
            }

            if (Convert.ToInt32(LB_STP.Text) >= Convert.ToInt32(LB_Cost_STR.Text))
            {
                BTN_STR_P.Enabled = true;
            }
            else
            {
                BTN_STR_P.Enabled = false;
            }

            if (Convert.ToInt32(LB_STP.Text) >= Convert.ToInt32(LB_Cost_DEX.Text))
            {
                BTN_DEX_P.Enabled = true;
            }
            else
            {
                BTN_DEX_P.Enabled = false;
            }

            if (Convert.ToInt32(LB_STP.Text) >= Convert.ToInt32(LB_Cost_SPD.Text))
            {
                BTN_SPD_P.Enabled = true;
            }
            else
            {
                BTN_SPD_P.Enabled = false;
            }
        }
       //Verifing if points have been added
        private void VerifyPointsAdded()
        {
            if (MXH_p != 0)
            {
                BTN_MXH_M.Enabled = true;
            }
            else
            {
                BTN_MXH_M.Enabled = false;
            }

            if (STR_p != 0)
            {
                BTN_STR_M.Enabled = true;
            }
            else
            {
                BTN_STR_M.Enabled = false;
            }


            if (DEX_p != 0)
            {
                BTN_DEX_M.Enabled = true;
            }
            else
            {
                BTN_DEX_M.Enabled = false;
            }

            if (SPD_p != 0)
            {
                BTN_SPD_M.Enabled = true;
            }
            else
            {
                BTN_SPD_M.Enabled = false;
            }
        }
       
        private void SaveStats()
        {
            FightingScene.date.GameManager.Player.MaxHealth = Convert.ToInt32(LB_MaxHealth.Text);
            FightingScene.date.GameManager.Player.Strength = Convert.ToInt32(LB_STR.Text);
            FightingScene.date.GameManager.Player.Dexterity = Convert.ToInt32(LB_DEX.Text);
            FightingScene.date.GameManager.Player.Speed = Convert.ToInt32(LB_SPD.Text);
            FightingScene.date.GameManager.Player.StatPoints = Convert.ToInt32(LB_STP.Text);

        }

        private void UpdateCosts()
        {
            if (Convert.ToInt32(LB_MaxHealth.Text) / 20 == 0)
                LB_Cost_MXH.Text = Convert.ToString(1);
            else
                LB_Cost_MXH.Text = Convert.ToString(Convert.ToInt32(LB_MaxHealth.Text) / 20);

            if (Convert.ToInt32(LB_STR.Text) / 6 == 0)
                LB_Cost_STR.Text = Convert.ToString(1);
            else LB_Cost_STR.Text = Convert.ToString((Convert.ToInt32(LB_STR.Text)- gameManager.Player.Strength )/ 5+1);

            if (Convert.ToInt32(LB_DEX.Text) / 25 == 0)
                LB_Cost_DEX.Text = Convert.ToString(1);
            else LB_Cost_DEX.Text = Convert.ToString(2);

            if(Convert.ToInt32(LB_SPD.Text) / 25 == 0)
                LB_Cost_SPD.Text = Convert.ToString(1) ;
            else LB_Cost_SPD.Text = Convert.ToString(2);

        }
        private void BTN_Save_Click(object sender, EventArgs e)
        {

            MXH_p = 0;
            STR_p = 0;
            DEX_p = 0;
            SPD_p = 0;

            SaveStats();
            VerifyPointsAdded();
            BTN_Save.Enabled = false;

        }

        private void Stats_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (BTN_MXH_M.Enabled == true || BTN_STR_M.Enabled == true || BTN_DEX_M.Enabled == true || BTN_SPD_M.Enabled == true)
            {
                DialogResult result;
                result = MessageBox.Show("You have not saved the stats. Do you want to save?", "Save", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SaveStats();
                }
            }
        }

        //Events
        private void BTN_MXH_P_Click(object sender, EventArgs e)
        {
            MXH_p ++;
            
            LB_STP.Text = Convert.ToString(Convert.ToInt32(LB_STP.Text) - Convert.ToInt32(LB_Cost_MXH.Text));
            LB_MaxHealth.Text = Convert.ToString(Convert.ToInt32(LB_MaxHealth.Text) + 5);

            VerifyPoints();
            VerifyPointsAdded();
            UpdateCosts();
            VerifyMaxStats();
            BTN_Save.Enabled = true;

        }

        private void BTN_MXH_M_Click(object sender, EventArgs e)
        {
            if(MXH_p >0)
            {
                MXH_p--;

                LB_MaxHealth.Text = Convert.ToString(Convert.ToInt32(LB_MaxHealth.Text) - 5);
                UpdateCosts();
                LB_STP.Text =Convert.ToString(Convert.ToInt32(LB_STP.Text)+ Convert.ToInt32(LB_Cost_MXH.Text)) ;

                VerifyPointsAdded();
                VerifyPoints();
                VerifyMaxStats();
                BTN_Save.Enabled = true;
            }
        }

        private void BTN_STR_P_Click(object sender, EventArgs e)
        {
            STR_p++;

            LB_STP.Text = Convert.ToString(Convert.ToInt32(LB_STP.Text) - Convert.ToInt32(LB_Cost_STR.Text));
            LB_STR.Text = Convert.ToString(Convert.ToInt32(LB_STR.Text) + 2);

            VerifyPoints();
            VerifyPointsAdded();
            UpdateCosts();
            VerifyMaxStats();
            BTN_Save.Enabled = true;

        }

        private void BTN_STR_M_Click(object sender, EventArgs e)
        {
            if (STR_p > 0)
            {
                STR_p--;

                LB_STR.Text = Convert.ToString(Convert.ToInt32(LB_STR.Text) - 2);
                UpdateCosts();
                LB_STP.Text = Convert.ToString(Convert.ToInt32(LB_STP.Text) + Convert.ToInt32(LB_Cost_STR.Text));

                VerifyPointsAdded();
                VerifyPoints();
                VerifyMaxStats();

                BTN_Save.Enabled = true;
            }
        }

        private void BTN_DEX_P_Click(object sender, EventArgs e)
        {
            DEX_p++;

            LB_STP.Text = Convert.ToString(Convert.ToInt32(LB_STP.Text) - Convert.ToInt32(LB_Cost_DEX.Text));
            LB_DEX.Text = Convert.ToString(Convert.ToInt32(LB_DEX.Text) + 1);

            VerifyPoints();
            VerifyPointsAdded();
            UpdateCosts();
            VerifyMaxStats();
            BTN_Save.Enabled = true;

        }

        private void BTN_DEX_M_Click(object sender, EventArgs e)
        {
            if (DEX_p > 0)
            {
                DEX_p--;

                LB_DEX.Text = Convert.ToString(Convert.ToInt32(LB_DEX.Text) - 1);
                UpdateCosts();
                LB_STP.Text = Convert.ToString(Convert.ToInt32(LB_STP.Text) + Convert.ToInt32(LB_Cost_DEX.Text));

                VerifyPointsAdded();
                VerifyPoints();
                VerifyMaxStats();

                BTN_Save.Enabled = true;
            }
        }

        private void BTN_SPD_P_Click(object sender, EventArgs e)
        {
            SPD_p++;

            LB_STP.Text = Convert.ToString(Convert.ToInt32(LB_STP.Text) - Convert.ToInt32(LB_Cost_SPD.Text));
            LB_SPD.Text = Convert.ToString(Convert.ToInt32(LB_SPD.Text) + 1);

            VerifyPoints();
            VerifyPointsAdded();
            UpdateCosts();
            VerifyMaxStats();
            BTN_Save.Enabled = true;
        }

        private void BTN_SPD_M_Click(object sender, EventArgs e)
        {
            if (SPD_p > 0)
            {
                SPD_p--;

                LB_SPD.Text = Convert.ToString(Convert.ToInt32(LB_SPD.Text) - 1);
                UpdateCosts();
                LB_STP.Text = Convert.ToString(Convert.ToInt32(LB_STP.Text) + Convert.ToInt32(LB_Cost_SPD.Text));

                VerifyPointsAdded();
                VerifyPoints();
                VerifyMaxStats();

                BTN_Save.Enabled = true;
            }
        }
    }
}