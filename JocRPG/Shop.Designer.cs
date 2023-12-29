namespace JocRPG
{
    partial class Shop
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
            this.LB_ShopList = new System.Windows.Forms.ListBox();
            this.BTN_Cumparare = new System.Windows.Forms.Button();
            this.LB_Bani = new System.Windows.Forms.Label();
            this.TB_Detalii = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_BuyPotions = new System.Windows.Forms.Button();
            this.BTN_UpgradePotion = new System.Windows.Forms.Button();
            this.TB_PotionNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_PotionsCost = new System.Windows.Forms.Label();
            this.LB_PotionUpgradeCost = new System.Windows.Forms.Label();
            this.LB_HpPerPotion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_ShopList
            // 
            this.LB_ShopList.BackColor = System.Drawing.SystemColors.MenuBar;
            this.LB_ShopList.FormattingEnabled = true;
            this.LB_ShopList.Location = new System.Drawing.Point(8, 17);
            this.LB_ShopList.Margin = new System.Windows.Forms.Padding(2);
            this.LB_ShopList.Name = "LB_ShopList";
            this.LB_ShopList.Size = new System.Drawing.Size(217, 173);
            this.LB_ShopList.TabIndex = 0;
            this.LB_ShopList.SelectedValueChanged += new System.EventHandler(this.LB_ShopList_SelectedValueChanged);
            // 
            // BTN_Cumparare
            // 
            this.BTN_Cumparare.BackColor = System.Drawing.Color.White;
            this.BTN_Cumparare.Location = new System.Drawing.Point(311, 135);
            this.BTN_Cumparare.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Cumparare.Name = "BTN_Cumparare";
            this.BTN_Cumparare.Size = new System.Drawing.Size(93, 59);
            this.BTN_Cumparare.TabIndex = 1;
            this.BTN_Cumparare.Text = "Cumpara";
            this.BTN_Cumparare.UseVisualStyleBackColor = false;
            this.BTN_Cumparare.Click += new System.EventHandler(this.BTN_Cumparare_Click);
            // 
            // LB_Bani
            // 
            this.LB_Bani.AutoSize = true;
            this.LB_Bani.Location = new System.Drawing.Point(229, 158);
            this.LB_Bani.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Bani.Name = "LB_Bani";
            this.LB_Bani.Size = new System.Drawing.Size(39, 13);
            this.LB_Bani.TabIndex = 2;
            this.LB_Bani.Text = "Money";
            // 
            // TB_Detalii
            // 
            this.TB_Detalii.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TB_Detalii.Location = new System.Drawing.Point(228, 17);
            this.TB_Detalii.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Detalii.Multiline = true;
            this.TB_Detalii.Name = "TB_Detalii";
            this.TB_Detalii.ReadOnly = true;
            this.TB_Detalii.Size = new System.Drawing.Size(176, 114);
            this.TB_Detalii.TabIndex = 3;
            this.TB_Detalii.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Potions:";
            // 
            // BTN_BuyPotions
            // 
            this.BTN_BuyPotions.BackColor = System.Drawing.Color.White;
            this.BTN_BuyPotions.Location = new System.Drawing.Point(185, 31);
            this.BTN_BuyPotions.Name = "BTN_BuyPotions";
            this.BTN_BuyPotions.Size = new System.Drawing.Size(103, 23);
            this.BTN_BuyPotions.TabIndex = 5;
            this.BTN_BuyPotions.Text = "Buy Potions";
            this.BTN_BuyPotions.UseVisualStyleBackColor = false;
            this.BTN_BuyPotions.Click += new System.EventHandler(this.BTN_BuyPotions_Click);
            // 
            // BTN_UpgradePotion
            // 
            this.BTN_UpgradePotion.BackColor = System.Drawing.Color.White;
            this.BTN_UpgradePotion.Location = new System.Drawing.Point(185, 60);
            this.BTN_UpgradePotion.Name = "BTN_UpgradePotion";
            this.BTN_UpgradePotion.Size = new System.Drawing.Size(103, 23);
            this.BTN_UpgradePotion.TabIndex = 6;
            this.BTN_UpgradePotion.Text = "Upgrade Potions";
            this.BTN_UpgradePotion.UseVisualStyleBackColor = false;
            this.BTN_UpgradePotion.Click += new System.EventHandler(this.BTN_UpgradePotion_Click);
            // 
            // TB_PotionNumber
            // 
            this.TB_PotionNumber.Location = new System.Drawing.Point(77, 33);
            this.TB_PotionNumber.Name = "TB_PotionNumber";
            this.TB_PotionNumber.Size = new System.Drawing.Size(100, 20);
            this.TB_PotionNumber.TabIndex = 7;
            this.TB_PotionNumber.Text = "1";
            this.TB_PotionNumber.TextChanged += new System.EventHandler(this.TB_PotionNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hp per potion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cost";
            // 
            // LB_PotionsCost
            // 
            this.LB_PotionsCost.AutoSize = true;
            this.LB_PotionsCost.Location = new System.Drawing.Point(333, 40);
            this.LB_PotionsCost.Name = "LB_PotionsCost";
            this.LB_PotionsCost.Size = new System.Drawing.Size(38, 13);
            this.LB_PotionsCost.TabIndex = 10;
            this.LB_PotionsCost.Text = "P Cost";
            // 
            // LB_PotionUpgradeCost
            // 
            this.LB_PotionUpgradeCost.AutoSize = true;
            this.LB_PotionUpgradeCost.Location = new System.Drawing.Point(332, 65);
            this.LB_PotionUpgradeCost.Name = "LB_PotionUpgradeCost";
            this.LB_PotionUpgradeCost.Size = new System.Drawing.Size(39, 13);
            this.LB_PotionUpgradeCost.TabIndex = 11;
            this.LB_PotionUpgradeCost.Text = "U Cost";
            // 
            // LB_HpPerPotion
            // 
            this.LB_HpPerPotion.AutoSize = true;
            this.LB_HpPerPotion.Location = new System.Drawing.Point(118, 65);
            this.LB_HpPerPotion.Name = "LB_HpPerPotion";
            this.LB_HpPerPotion.Size = new System.Drawing.Size(21, 13);
            this.LB_HpPerPotion.TabIndex = 12;
            this.LB_HpPerPotion.Text = "Hp";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.LB_HpPerPotion);
            this.groupBox1.Controls.Add(this.BTN_BuyPotions);
            this.groupBox1.Controls.Add(this.LB_PotionUpgradeCost);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LB_PotionsCost);
            this.groupBox1.Controls.Add(this.BTN_UpgradePotion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TB_PotionNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 104);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Potions";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(410, 311);
            this.Controls.Add(this.TB_Detalii);
            this.Controls.Add(this.LB_Bani);
            this.Controls.Add(this.BTN_Cumparare);
            this.Controls.Add(this.LB_ShopList);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Shop";
            this.Text = "Shop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Shop_FormClosed);
            this.Load += new System.EventHandler(this.Shop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_ShopList;
        private System.Windows.Forms.Button BTN_Cumparare;
        private System.Windows.Forms.Label LB_Bani;
        private System.Windows.Forms.TextBox TB_Detalii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_BuyPotions;
        private System.Windows.Forms.Button BTN_UpgradePotion;
        private System.Windows.Forms.TextBox TB_PotionNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LB_PotionsCost;
        private System.Windows.Forms.Label LB_PotionUpgradeCost;
        private System.Windows.Forms.Label LB_HpPerPotion;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}