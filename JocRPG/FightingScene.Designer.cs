namespace JocRPG
{
    partial class FightingScene
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_Action = new System.Windows.Forms.ListBox();
            this.PB_Enemy = new System.Windows.Forms.PictureBox();
            this.PB_Player = new System.Windows.Forms.PictureBox();
            this.BTN_Attack = new System.Windows.Forms.Button();
            this.BTN_Inventory = new System.Windows.Forms.Button();
            this.BTN_Block = new System.Windows.Forms.Button();
            this.BTN_Dodge = new System.Windows.Forms.Button();
            this.BTN_EnemyTurn = new System.Windows.Forms.Button();
            this.BTN_Heal = new System.Windows.Forms.Button();
            this.TB_Detalii = new System.Windows.Forms.TextBox();
            this.BTN_Stats = new System.Windows.Forms.Button();
            this.BTN_StartGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_HPP = new System.Windows.Forms.Label();
            this.LB_HPE = new System.Windows.Forms.Label();
            this.BTN_Counter = new System.Windows.Forms.Button();
            this.LB_NameP = new System.Windows.Forms.Label();
            this.LB_NumeE = new System.Windows.Forms.Label();
            this.BTN_Shop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Action
            // 
            this.LB_Action.FormattingEnabled = true;
            this.LB_Action.ItemHeight = 20;
            this.LB_Action.Location = new System.Drawing.Point(296, 34);
            this.LB_Action.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LB_Action.Name = "LB_Action";
            this.LB_Action.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LB_Action.Size = new System.Drawing.Size(674, 284);
            this.LB_Action.TabIndex = 0;
            this.LB_Action.UseTabStops = false;
            this.LB_Action.Visible = false;
            // 
            // PB_Enemy
            // 
            this.PB_Enemy.InitialImage = null;
            this.PB_Enemy.Location = new System.Drawing.Point(980, 66);
            this.PB_Enemy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PB_Enemy.Name = "PB_Enemy";
            this.PB_Enemy.Size = new System.Drawing.Size(274, 223);
            this.PB_Enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Enemy.TabIndex = 1;
            this.PB_Enemy.TabStop = false;
            // 
            // PB_Player
            // 
            this.PB_Player.Location = new System.Drawing.Point(15, 60);
            this.PB_Player.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PB_Player.Name = "PB_Player";
            this.PB_Player.Size = new System.Drawing.Size(272, 229);
            this.PB_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Player.TabIndex = 2;
            this.PB_Player.TabStop = false;
            this.PB_Player.Visible = false;
            // 
            // BTN_Attack
            // 
            this.BTN_Attack.Location = new System.Drawing.Point(296, 329);
            this.BTN_Attack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Attack.Name = "BTN_Attack";
            this.BTN_Attack.Size = new System.Drawing.Size(128, 58);
            this.BTN_Attack.TabIndex = 4;
            this.BTN_Attack.Text = "Attack";
            this.BTN_Attack.UseVisualStyleBackColor = true;
            this.BTN_Attack.Visible = false;
            this.BTN_Attack.Click += new System.EventHandler(this.BTN_Attack_Click);
            this.BTN_Attack.MouseLeave += new System.EventHandler(this.BTN_Attack_MouseLeave);
            this.BTN_Attack.MouseHover += new System.EventHandler(this.BTN_Attack_MouseHover);
            // 
            // BTN_Inventory
            // 
            this.BTN_Inventory.Location = new System.Drawing.Point(15, 329);
            this.BTN_Inventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Inventory.Name = "BTN_Inventory";
            this.BTN_Inventory.Size = new System.Drawing.Size(272, 58);
            this.BTN_Inventory.TabIndex = 6;
            this.BTN_Inventory.Text = "Inventory";
            this.BTN_Inventory.UseVisualStyleBackColor = true;
            this.BTN_Inventory.Visible = false;
            // 
            // BTN_Block
            // 
            this.BTN_Block.Location = new System.Drawing.Point(572, 329);
            this.BTN_Block.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Block.Name = "BTN_Block";
            this.BTN_Block.Size = new System.Drawing.Size(128, 58);
            this.BTN_Block.TabIndex = 7;
            this.BTN_Block.Text = "Block";
            this.BTN_Block.UseVisualStyleBackColor = true;
            this.BTN_Block.Visible = false;
            this.BTN_Block.Click += new System.EventHandler(this.BTN_Block_Click);
            this.BTN_Block.MouseLeave += new System.EventHandler(this.BTN_Block_MouseLeave);
            this.BTN_Block.MouseHover += new System.EventHandler(this.BTN_Block_MouseHover);
            // 
            // BTN_Dodge
            // 
            this.BTN_Dodge.Location = new System.Drawing.Point(708, 329);
            this.BTN_Dodge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Dodge.Name = "BTN_Dodge";
            this.BTN_Dodge.Size = new System.Drawing.Size(128, 58);
            this.BTN_Dodge.TabIndex = 8;
            this.BTN_Dodge.Text = "Dodge";
            this.BTN_Dodge.UseVisualStyleBackColor = true;
            this.BTN_Dodge.Visible = false;
            this.BTN_Dodge.Click += new System.EventHandler(this.BTN_Dodge_Click);
            this.BTN_Dodge.MouseLeave += new System.EventHandler(this.BTN_Dodge_MouseLeave);
            this.BTN_Dodge.MouseHover += new System.EventHandler(this.BTN_Dodge_MouseHover);
            // 
            // BTN_EnemyTurn
            // 
            this.BTN_EnemyTurn.Enabled = false;
            this.BTN_EnemyTurn.Location = new System.Drawing.Point(981, 328);
            this.BTN_EnemyTurn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_EnemyTurn.Name = "BTN_EnemyTurn";
            this.BTN_EnemyTurn.Size = new System.Drawing.Size(272, 58);
            this.BTN_EnemyTurn.TabIndex = 9;
            this.BTN_EnemyTurn.Text = "Enemy Turn";
            this.BTN_EnemyTurn.UseVisualStyleBackColor = true;
            this.BTN_EnemyTurn.Visible = false;
            this.BTN_EnemyTurn.Click += new System.EventHandler(this.BTN_EnemyTurn_Click);
            // 
            // BTN_Heal
            // 
            this.BTN_Heal.Location = new System.Drawing.Point(844, 328);
            this.BTN_Heal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Heal.Name = "BTN_Heal";
            this.BTN_Heal.Size = new System.Drawing.Size(128, 58);
            this.BTN_Heal.TabIndex = 10;
            this.BTN_Heal.Text = "Heal";
            this.BTN_Heal.UseVisualStyleBackColor = true;
            this.BTN_Heal.Visible = false;
            this.BTN_Heal.Click += new System.EventHandler(this.BTN_Heal_Click);
            this.BTN_Heal.MouseLeave += new System.EventHandler(this.BTN_Heal_MouseLeave);
            this.BTN_Heal.MouseHover += new System.EventHandler(this.BTN_Heal_MouseHover);
            // 
            // TB_Detalii
            // 
            this.TB_Detalii.Location = new System.Drawing.Point(296, 397);
            this.TB_Detalii.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Detalii.Multiline = true;
            this.TB_Detalii.Name = "TB_Detalii";
            this.TB_Detalii.Size = new System.Drawing.Size(674, 56);
            this.TB_Detalii.TabIndex = 11;
            this.TB_Detalii.Visible = false;
            // 
            // BTN_Stats
            // 
            this.BTN_Stats.Location = new System.Drawing.Point(15, 397);
            this.BTN_Stats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Stats.Name = "BTN_Stats";
            this.BTN_Stats.Size = new System.Drawing.Size(272, 58);
            this.BTN_Stats.TabIndex = 12;
            this.BTN_Stats.Text = "Stats";
            this.BTN_Stats.UseVisualStyleBackColor = true;
            this.BTN_Stats.Visible = false;
            this.BTN_Stats.Click += new System.EventHandler(this.BTN_Stats_Click);
            // 
            // BTN_StartGame
            // 
            this.BTN_StartGame.Location = new System.Drawing.Point(536, 465);
            this.BTN_StartGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_StartGame.Name = "BTN_StartGame";
            this.BTN_StartGame.Size = new System.Drawing.Size(182, 42);
            this.BTN_StartGame.TabIndex = 13;
            this.BTN_StartGame.Text = "Start";
            this.BTN_StartGame.UseVisualStyleBackColor = true;
            this.BTN_StartGame.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Stat points Available!";
            this.label1.Visible = false;
            // 
            // LB_HPP
            // 
            this.LB_HPP.AutoSize = true;
            this.LB_HPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LB_HPP.Location = new System.Drawing.Point(16, 300);
            this.LB_HPP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_HPP.Name = "LB_HPP";
            this.LB_HPP.Size = new System.Drawing.Size(45, 25);
            this.LB_HPP.TabIndex = 16;
            this.LB_HPP.Text = "HP:";
            this.LB_HPP.Visible = false;
            // 
            // LB_HPE
            // 
            this.LB_HPE.AutoSize = true;
            this.LB_HPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LB_HPE.Location = new System.Drawing.Point(981, 300);
            this.LB_HPE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_HPE.Name = "LB_HPE";
            this.LB_HPE.Size = new System.Drawing.Size(45, 25);
            this.LB_HPE.TabIndex = 18;
            this.LB_HPE.Text = "HP:";
            this.LB_HPE.Visible = false;
            // 
            // BTN_Counter
            // 
            this.BTN_Counter.Location = new System.Drawing.Point(435, 329);
            this.BTN_Counter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Counter.Name = "BTN_Counter";
            this.BTN_Counter.Size = new System.Drawing.Size(128, 58);
            this.BTN_Counter.TabIndex = 19;
            this.BTN_Counter.Text = "Counter";
            this.BTN_Counter.UseVisualStyleBackColor = true;
            this.BTN_Counter.Visible = false;
            this.BTN_Counter.Click += new System.EventHandler(this.BTN_Counter_Click);
            this.BTN_Counter.MouseLeave += new System.EventHandler(this.BTN_Counter_MouseLeave);
            this.BTN_Counter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BTN_Counter_MouseMove);
            // 
            // LB_NameP
            // 
            this.LB_NameP.AutoSize = true;
            this.LB_NameP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LB_NameP.Location = new System.Drawing.Point(9, 31);
            this.LB_NameP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NameP.Name = "LB_NameP";
            this.LB_NameP.Size = new System.Drawing.Size(77, 25);
            this.LB_NameP.TabIndex = 22;
            this.LB_NameP.Text = "NumeP";
            this.LB_NameP.Visible = false;
            // 
            // LB_NumeE
            // 
            this.LB_NumeE.AutoSize = true;
            this.LB_NumeE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LB_NumeE.Location = new System.Drawing.Point(981, 29);
            this.LB_NumeE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NumeE.Name = "LB_NumeE";
            this.LB_NumeE.Size = new System.Drawing.Size(77, 25);
            this.LB_NumeE.TabIndex = 23;
            this.LB_NumeE.Text = "NumeE";
            this.LB_NumeE.Visible = false;
            // 
            // BTN_Shop
            // 
            this.BTN_Shop.Location = new System.Drawing.Point(981, 397);
            this.BTN_Shop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Shop.Name = "BTN_Shop";
            this.BTN_Shop.Size = new System.Drawing.Size(272, 58);
            this.BTN_Shop.TabIndex = 24;
            this.BTN_Shop.Text = "Shop";
            this.BTN_Shop.UseVisualStyleBackColor = true;
            this.BTN_Shop.Visible = false;
            this.BTN_Shop.Click += new System.EventHandler(this.BTN_Shop_Click);
            // 
            // FightingScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 520);
            this.Controls.Add(this.PB_Enemy);
            this.Controls.Add(this.BTN_Shop);
            this.Controls.Add(this.LB_NumeE);
            this.Controls.Add(this.LB_NameP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Counter);
            this.Controls.Add(this.BTN_StartGame);
            this.Controls.Add(this.LB_Action);
            this.Controls.Add(this.LB_HPP);
            this.Controls.Add(this.BTN_Block);
            this.Controls.Add(this.LB_HPE);
            this.Controls.Add(this.BTN_Heal);
            this.Controls.Add(this.BTN_Attack);
            this.Controls.Add(this.BTN_Dodge);
            this.Controls.Add(this.PB_Player);
            this.Controls.Add(this.BTN_Inventory);
            this.Controls.Add(this.TB_Detalii);
            this.Controls.Add(this.BTN_EnemyTurn);
            this.Controls.Add(this.BTN_Stats);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FightingScene";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox LB_Action;
        public System.Windows.Forms.PictureBox PB_Player;
        public System.Windows.Forms.Button BTN_Attack;
        public System.Windows.Forms.Button BTN_Inventory;
        public System.Windows.Forms.Button BTN_Block;
        public System.Windows.Forms.Button BTN_Dodge;
        public System.Windows.Forms.Button BTN_EnemyTurn;
        public System.Windows.Forms.Button BTN_Heal;
        public System.Windows.Forms.TextBox TB_Detalii;
        public System.Windows.Forms.Button BTN_Stats;
        public System.Windows.Forms.Button BTN_StartGame;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label LB_HPP;
        public System.Windows.Forms.Label LB_HPE;
        public System.Windows.Forms.Button BTN_Counter;
        public System.Windows.Forms.Label LB_NameP;
        public System.Windows.Forms.Label LB_NumeE;
        public System.Windows.Forms.Button BTN_Shop;
        public System.Windows.Forms.PictureBox PB_Enemy;
    }
}

