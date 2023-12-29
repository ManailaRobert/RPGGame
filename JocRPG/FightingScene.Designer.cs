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
            this.PB_Enemy = new System.Windows.Forms.PictureBox();
            this.RB_Knight = new System.Windows.Forms.RadioButton();
            this.RB_Barbarian = new System.Windows.Forms.RadioButton();
            this.RB_Archer = new System.Windows.Forms.RadioButton();
            this.LB_Classes = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.GB_Actions = new System.Windows.Forms.GroupBox();
            this.GB_StartGame = new System.Windows.Forms.GroupBox();
            this.GB_Game = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Enemy)).BeginInit();
            this.GB_Actions.SuspendLayout();
            this.GB_StartGame.SuspendLayout();
            this.GB_Game.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Action
            // 
            this.LB_Action.BackColor = System.Drawing.SystemColors.MenuBar;
            this.LB_Action.FormattingEnabled = true;
            this.LB_Action.Location = new System.Drawing.Point(205, 30);
            this.LB_Action.Name = "LB_Action";
            this.LB_Action.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LB_Action.Size = new System.Drawing.Size(451, 173);
            this.LB_Action.TabIndex = 0;
            this.LB_Action.UseTabStops = false;
            // 
            // PB_Player
            // 
            this.PB_Player.Location = new System.Drawing.Point(18, 30);
            this.PB_Player.Name = "PB_Player";
            this.PB_Player.Size = new System.Drawing.Size(181, 149);
            this.PB_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Player.TabIndex = 2;
            this.PB_Player.TabStop = false;
            // 
            // BTN_Attack
            // 
            this.BTN_Attack.BackColor = System.Drawing.Color.White;
            this.BTN_Attack.Location = new System.Drawing.Point(195, 19);
            this.BTN_Attack.Name = "BTN_Attack";
            this.BTN_Attack.Size = new System.Drawing.Size(85, 38);
            this.BTN_Attack.TabIndex = 4;
            this.BTN_Attack.Text = "Attack";
            this.BTN_Attack.UseVisualStyleBackColor = false;
            this.BTN_Attack.Click += new System.EventHandler(this.BTN_Attack_Click);
            this.BTN_Attack.MouseLeave += new System.EventHandler(this.BTN_Attack_MouseLeave);
            this.BTN_Attack.MouseHover += new System.EventHandler(this.BTN_Attack_MouseHover);
            // 
            // BTN_Inventory
            // 
            this.BTN_Inventory.BackColor = System.Drawing.Color.White;
            this.BTN_Inventory.Location = new System.Drawing.Point(8, 19);
            this.BTN_Inventory.Name = "BTN_Inventory";
            this.BTN_Inventory.Size = new System.Drawing.Size(181, 38);
            this.BTN_Inventory.TabIndex = 6;
            this.BTN_Inventory.Text = "Inventory";
            this.BTN_Inventory.UseVisualStyleBackColor = false;
            this.BTN_Inventory.Click += new System.EventHandler(this.BTN_Inventory_Click);
            // 
            // BTN_Block
            // 
            this.BTN_Block.BackColor = System.Drawing.Color.White;
            this.BTN_Block.Location = new System.Drawing.Point(379, 19);
            this.BTN_Block.Name = "BTN_Block";
            this.BTN_Block.Size = new System.Drawing.Size(85, 38);
            this.BTN_Block.TabIndex = 7;
            this.BTN_Block.Text = "Block";
            this.BTN_Block.UseVisualStyleBackColor = false;
            this.BTN_Block.Click += new System.EventHandler(this.BTN_Block_Click);
            this.BTN_Block.MouseLeave += new System.EventHandler(this.BTN_Block_MouseLeave);
            this.BTN_Block.MouseHover += new System.EventHandler(this.BTN_Block_MouseHover);
            // 
            // BTN_Dodge
            // 
            this.BTN_Dodge.BackColor = System.Drawing.Color.White;
            this.BTN_Dodge.Location = new System.Drawing.Point(470, 19);
            this.BTN_Dodge.Name = "BTN_Dodge";
            this.BTN_Dodge.Size = new System.Drawing.Size(85, 38);
            this.BTN_Dodge.TabIndex = 8;
            this.BTN_Dodge.Text = "Dodge";
            this.BTN_Dodge.UseVisualStyleBackColor = false;
            this.BTN_Dodge.Click += new System.EventHandler(this.BTN_Dodge_Click);
            this.BTN_Dodge.MouseLeave += new System.EventHandler(this.BTN_Dodge_MouseLeave);
            this.BTN_Dodge.MouseHover += new System.EventHandler(this.BTN_Dodge_MouseHover);
            // 
            // BTN_EnemyTurn
            // 
            this.BTN_EnemyTurn.BackColor = System.Drawing.Color.White;
            this.BTN_EnemyTurn.Enabled = false;
            this.BTN_EnemyTurn.Location = new System.Drawing.Point(652, 18);
            this.BTN_EnemyTurn.Name = "BTN_EnemyTurn";
            this.BTN_EnemyTurn.Size = new System.Drawing.Size(163, 38);
            this.BTN_EnemyTurn.TabIndex = 9;
            this.BTN_EnemyTurn.Text = "Enemy Turn";
            this.BTN_EnemyTurn.UseVisualStyleBackColor = false;
            this.BTN_EnemyTurn.Click += new System.EventHandler(this.BTN_EnemyTurn_Click);
            // 
            // BTN_Heal
            // 
            this.BTN_Heal.BackColor = System.Drawing.Color.White;
            this.BTN_Heal.Location = new System.Drawing.Point(561, 19);
            this.BTN_Heal.Name = "BTN_Heal";
            this.BTN_Heal.Size = new System.Drawing.Size(85, 38);
            this.BTN_Heal.TabIndex = 10;
            this.BTN_Heal.Text = "Heal";
            this.BTN_Heal.UseVisualStyleBackColor = false;
            this.BTN_Heal.Click += new System.EventHandler(this.BTN_Heal_Click);
            this.BTN_Heal.MouseLeave += new System.EventHandler(this.BTN_Heal_MouseLeave);
            this.BTN_Heal.MouseHover += new System.EventHandler(this.BTN_Heal_MouseHover);
            // 
            // TB_Detalii
            // 
            this.TB_Detalii.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TB_Detalii.Location = new System.Drawing.Point(195, 63);
            this.TB_Detalii.Multiline = true;
            this.TB_Detalii.Name = "TB_Detalii";
            this.TB_Detalii.Size = new System.Drawing.Size(451, 38);
            this.TB_Detalii.TabIndex = 11;
            this.TB_Detalii.Visible = false;
            // 
            // BTN_Stats
            // 
            this.BTN_Stats.BackColor = System.Drawing.Color.White;
            this.BTN_Stats.Location = new System.Drawing.Point(8, 63);
            this.BTN_Stats.Name = "BTN_Stats";
            this.BTN_Stats.Size = new System.Drawing.Size(181, 38);
            this.BTN_Stats.TabIndex = 12;
            this.BTN_Stats.Text = "Stats";
            this.BTN_Stats.UseVisualStyleBackColor = false;
            this.BTN_Stats.Click += new System.EventHandler(this.BTN_Stats_Click);
            // 
            // BTN_StartGame
            // 
            this.BTN_StartGame.BackColor = System.Drawing.Color.White;
            this.BTN_StartGame.Location = new System.Drawing.Point(3, 14);
            this.BTN_StartGame.Name = "BTN_StartGame";
            this.BTN_StartGame.Size = new System.Drawing.Size(143, 27);
            this.BTN_StartGame.TabIndex = 13;
            this.BTN_StartGame.Text = "Start";
            this.BTN_StartGame.UseVisualStyleBackColor = false;
            this.BTN_StartGame.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Stat points Available!";
            // 
            // LB_HPP
            // 
            this.LB_HPP.AutoSize = true;
            this.LB_HPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LB_HPP.Location = new System.Drawing.Point(15, 194);
            this.LB_HPP.Name = "LB_HPP";
            this.LB_HPP.Size = new System.Drawing.Size(31, 17);
            this.LB_HPP.TabIndex = 16;
            this.LB_HPP.Text = "HP:";
            // 
            // LB_HPE
            // 
            this.LB_HPE.AutoSize = true;
            this.LB_HPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LB_HPE.Location = new System.Drawing.Point(662, 186);
            this.LB_HPE.Name = "LB_HPE";
            this.LB_HPE.Size = new System.Drawing.Size(31, 17);
            this.LB_HPE.TabIndex = 18;
            this.LB_HPE.Text = "HP:";
            // 
            // BTN_Counter
            // 
            this.BTN_Counter.BackColor = System.Drawing.Color.White;
            this.BTN_Counter.Location = new System.Drawing.Point(288, 19);
            this.BTN_Counter.Name = "BTN_Counter";
            this.BTN_Counter.Size = new System.Drawing.Size(85, 38);
            this.BTN_Counter.TabIndex = 19;
            this.BTN_Counter.Text = "Counter";
            this.BTN_Counter.UseVisualStyleBackColor = false;
            this.BTN_Counter.Click += new System.EventHandler(this.BTN_Counter_Click);
            this.BTN_Counter.MouseLeave += new System.EventHandler(this.BTN_Counter_MouseLeave);
            this.BTN_Counter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BTN_Counter_MouseMove);
            // 
            // LB_NameP
            // 
            this.LB_NameP.AutoSize = true;
            this.LB_NameP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LB_NameP.Location = new System.Drawing.Point(15, 11);
            this.LB_NameP.Name = "LB_NameP";
            this.LB_NameP.Size = new System.Drawing.Size(54, 17);
            this.LB_NameP.TabIndex = 22;
            this.LB_NameP.Text = "NumeP";
            // 
            // LB_NumeE
            // 
            this.LB_NumeE.AutoSize = true;
            this.LB_NumeE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LB_NumeE.Location = new System.Drawing.Point(659, 11);
            this.LB_NumeE.Name = "LB_NumeE";
            this.LB_NumeE.Size = new System.Drawing.Size(54, 17);
            this.LB_NumeE.TabIndex = 23;
            this.LB_NumeE.Text = "NumeE";
            // 
            // BTN_Shop
            // 
            this.BTN_Shop.BackColor = System.Drawing.Color.White;
            this.BTN_Shop.Location = new System.Drawing.Point(652, 63);
            this.BTN_Shop.Name = "BTN_Shop";
            this.BTN_Shop.Size = new System.Drawing.Size(163, 38);
            this.BTN_Shop.TabIndex = 24;
            this.BTN_Shop.Text = "Shop";
            this.BTN_Shop.UseVisualStyleBackColor = false;
            this.BTN_Shop.Click += new System.EventHandler(this.BTN_Shop_Click);
            // 
            // PB_Enemy
            // 
            this.PB_Enemy.Location = new System.Drawing.Point(662, 30);
            this.PB_Enemy.Name = "PB_Enemy";
            this.PB_Enemy.Size = new System.Drawing.Size(181, 149);
            this.PB_Enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Enemy.TabIndex = 25;
            this.PB_Enemy.TabStop = false;
            // 
            // RB_Knight
            // 
            this.RB_Knight.AutoSize = true;
            this.RB_Knight.Checked = true;
            this.RB_Knight.Location = new System.Drawing.Point(357, 19);
            this.RB_Knight.Name = "RB_Knight";
            this.RB_Knight.Size = new System.Drawing.Size(55, 17);
            this.RB_Knight.TabIndex = 26;
            this.RB_Knight.TabStop = true;
            this.RB_Knight.Text = "Knight";
            this.RB_Knight.UseVisualStyleBackColor = true;
            // 
            // RB_Barbarian
            // 
            this.RB_Barbarian.AutoSize = true;
            this.RB_Barbarian.Location = new System.Drawing.Point(418, 19);
            this.RB_Barbarian.Name = "RB_Barbarian";
            this.RB_Barbarian.Size = new System.Drawing.Size(70, 17);
            this.RB_Barbarian.TabIndex = 27;
            this.RB_Barbarian.Text = "Barbarian";
            this.RB_Barbarian.UseVisualStyleBackColor = true;
            // 
            // RB_Archer
            // 
            this.RB_Archer.AutoSize = true;
            this.RB_Archer.Location = new System.Drawing.Point(494, 19);
            this.RB_Archer.Name = "RB_Archer";
            this.RB_Archer.Size = new System.Drawing.Size(56, 17);
            this.RB_Archer.TabIndex = 28;
            this.RB_Archer.Text = "Archer";
            this.RB_Archer.UseVisualStyleBackColor = true;
            // 
            // LB_Classes
            // 
            this.LB_Classes.AutoSize = true;
            this.LB_Classes.Location = new System.Drawing.Point(303, 21);
            this.LB_Classes.Name = "LB_Classes";
            this.LB_Classes.Size = new System.Drawing.Size(46, 13);
            this.LB_Classes.TabIndex = 29;
            this.LB_Classes.Text = "Classes:";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(152, 18);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(145, 20);
            this.TB_Name.TabIndex = 30;
            this.TB_Name.Text = "Character Name";
            // 
            // GB_Actions
            // 
            this.GB_Actions.BackColor = System.Drawing.Color.Silver;
            this.GB_Actions.Controls.Add(this.BTN_Block);
            this.GB_Actions.Controls.Add(this.BTN_Stats);
            this.GB_Actions.Controls.Add(this.BTN_EnemyTurn);
            this.GB_Actions.Controls.Add(this.TB_Detalii);
            this.GB_Actions.Controls.Add(this.BTN_Inventory);
            this.GB_Actions.Controls.Add(this.BTN_Dodge);
            this.GB_Actions.Controls.Add(this.BTN_Attack);
            this.GB_Actions.Controls.Add(this.BTN_Shop);
            this.GB_Actions.Controls.Add(this.BTN_Heal);
            this.GB_Actions.Controls.Add(this.BTN_Counter);
            this.GB_Actions.Location = new System.Drawing.Point(22, 214);
            this.GB_Actions.Name = "GB_Actions";
            this.GB_Actions.Size = new System.Drawing.Size(821, 109);
            this.GB_Actions.TabIndex = 31;
            this.GB_Actions.TabStop = false;
            // 
            // GB_StartGame
            // 
            this.GB_StartGame.Controls.Add(this.LB_Classes);
            this.GB_StartGame.Controls.Add(this.BTN_StartGame);
            this.GB_StartGame.Controls.Add(this.TB_Name);
            this.GB_StartGame.Controls.Add(this.RB_Knight);
            this.GB_StartGame.Controls.Add(this.RB_Barbarian);
            this.GB_StartGame.Controls.Add(this.RB_Archer);
            this.GB_StartGame.Location = new System.Drawing.Point(161, 347);
            this.GB_StartGame.Name = "GB_StartGame";
            this.GB_StartGame.Size = new System.Drawing.Size(557, 46);
            this.GB_StartGame.TabIndex = 32;
            this.GB_StartGame.TabStop = false;
            // 
            // GB_Game
            // 
            this.GB_Game.Controls.Add(this.LB_Action);
            this.GB_Game.Controls.Add(this.GB_Actions);
            this.GB_Game.Controls.Add(this.LB_HPE);
            this.GB_Game.Controls.Add(this.PB_Enemy);
            this.GB_Game.Controls.Add(this.LB_HPP);
            this.GB_Game.Controls.Add(this.LB_NumeE);
            this.GB_Game.Controls.Add(this.label1);
            this.GB_Game.Controls.Add(this.LB_NameP);
            this.GB_Game.Controls.Add(this.PB_Player);
            this.GB_Game.Location = new System.Drawing.Point(12, 12);
            this.GB_Game.Name = "GB_Game";
            this.GB_Game.Size = new System.Drawing.Size(859, 329);
            this.GB_Game.TabIndex = 33;
            this.GB_Game.TabStop = false;
            this.GB_Game.Visible = false;
            // 
            // FightingScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(880, 400);
            this.Controls.Add(this.GB_Game);
            this.Controls.Add(this.GB_StartGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FightingScene";
            this.Text = "RPG_Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FightingScene_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Enemy)).EndInit();
            this.GB_Actions.ResumeLayout(false);
            this.GB_Actions.PerformLayout();
            this.GB_StartGame.ResumeLayout(false);
            this.GB_StartGame.PerformLayout();
            this.GB_Game.ResumeLayout(false);
            this.GB_Game.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.RadioButton RB_Knight;
        private System.Windows.Forms.RadioButton RB_Barbarian;
        private System.Windows.Forms.RadioButton RB_Archer;
        private System.Windows.Forms.Label LB_Classes;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.GroupBox GB_Actions;
        private System.Windows.Forms.GroupBox GB_StartGame;
        private System.Windows.Forms.GroupBox GB_Game;
    }
}

