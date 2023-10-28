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
            this.SuspendLayout();
            // 
            // LB_ShopList
            // 
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
            this.BTN_Cumparare.Location = new System.Drawing.Point(311, 135);
            this.BTN_Cumparare.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Cumparare.Name = "BTN_Cumparare";
            this.BTN_Cumparare.Size = new System.Drawing.Size(93, 59);
            this.BTN_Cumparare.TabIndex = 1;
            this.BTN_Cumparare.Text = "Cumpara";
            this.BTN_Cumparare.UseVisualStyleBackColor = true;
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
            this.TB_Detalii.Location = new System.Drawing.Point(228, 17);
            this.TB_Detalii.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Detalii.Multiline = true;
            this.TB_Detalii.Name = "TB_Detalii";
            this.TB_Detalii.Size = new System.Drawing.Size(176, 114);
            this.TB_Detalii.TabIndex = 3;
            this.TB_Detalii.Visible = false;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(409, 196);
            this.Controls.Add(this.TB_Detalii);
            this.Controls.Add(this.LB_Bani);
            this.Controls.Add(this.BTN_Cumparare);
            this.Controls.Add(this.LB_ShopList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Shop";
            this.Text = "Shop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Shop_FormClosed);
            this.Load += new System.EventHandler(this.Shop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_ShopList;
        private System.Windows.Forms.Button BTN_Cumparare;
        private System.Windows.Forms.Label LB_Bani;
        private System.Windows.Forms.TextBox TB_Detalii;
    }
}