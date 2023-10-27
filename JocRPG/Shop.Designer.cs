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
            this.LB_ShopList.ItemHeight = 20;
            this.LB_ShopList.Location = new System.Drawing.Point(12, 26);
            this.LB_ShopList.Name = "LB_ShopList";
            this.LB_ShopList.Size = new System.Drawing.Size(324, 264);
            this.LB_ShopList.TabIndex = 0;
            this.LB_ShopList.SelectedValueChanged += new System.EventHandler(this.LB_ShopList_SelectedValueChanged);
            // 
            // BTN_Cumparare
            // 
            this.BTN_Cumparare.Location = new System.Drawing.Point(612, 63);
            this.BTN_Cumparare.Name = "BTN_Cumparare";
            this.BTN_Cumparare.Size = new System.Drawing.Size(139, 91);
            this.BTN_Cumparare.TabIndex = 1;
            this.BTN_Cumparare.Text = "Cumpara";
            this.BTN_Cumparare.UseVisualStyleBackColor = true;
            this.BTN_Cumparare.Click += new System.EventHandler(this.BTN_Cumparare_Click);
            // 
            // LB_Bani
            // 
            this.LB_Bani.AutoSize = true;
            this.LB_Bani.Location = new System.Drawing.Point(653, 206);
            this.LB_Bani.Name = "LB_Bani";
            this.LB_Bani.Size = new System.Drawing.Size(51, 20);
            this.LB_Bani.TabIndex = 2;
            this.LB_Bani.Text = "label1";
            // 
            // TB_Detalii
            // 
            this.TB_Detalii.Location = new System.Drawing.Point(342, 26);
            this.TB_Detalii.Multiline = true;
            this.TB_Detalii.Name = "TB_Detalii";
            this.TB_Detalii.Size = new System.Drawing.Size(242, 173);
            this.TB_Detalii.TabIndex = 3;
            this.TB_Detalii.Visible = false;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 306);
            this.Controls.Add(this.TB_Detalii);
            this.Controls.Add(this.LB_Bani);
            this.Controls.Add(this.BTN_Cumparare);
            this.Controls.Add(this.LB_ShopList);
            this.Name = "Shop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            this.Leave += new System.EventHandler(this.Shop_Leave);
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