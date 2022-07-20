namespace Exchange
{
    partial class Exchange
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExchangeLabel = new System.Windows.Forms.Label();
            this.BuyLabel = new System.Windows.Forms.Label();
            this.UsdLabel = new System.Windows.Forms.Label();
            this.SellLabel = new System.Windows.Forms.Label();
            this.EurLabel = new System.Windows.Forms.Label();
            this.PlnLabel = new System.Windows.Forms.Label();
            this.PlnFlagPicture = new System.Windows.Forms.PictureBox();
            this.EurFlagPicture = new System.Windows.Forms.PictureBox();
            this.UsdFlagPicture = new System.Windows.Forms.PictureBox();
            this.UsdBuyLabel = new System.Windows.Forms.Label();
            this.UsdSellLabel = new System.Windows.Forms.Label();
            this.EurBuyLabel = new System.Windows.Forms.Label();
            this.EurSellLabel = new System.Windows.Forms.Label();
            this.PlnBuyLabel = new System.Windows.Forms.Label();
            this.PlnSellLabel = new System.Windows.Forms.Label();
            this.UpdasteButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlnFlagPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EurFlagPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsdFlagPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.ExchangeLabel);
            this.panel1.Location = new System.Drawing.Point(-4, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 52);
            this.panel1.TabIndex = 0;
            // 
            // ExchangeLabel
            // 
            this.ExchangeLabel.AutoSize = true;
            this.ExchangeLabel.Font = new System.Drawing.Font("Bookman Old Style", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExchangeLabel.ForeColor = System.Drawing.Color.Gold;
            this.ExchangeLabel.Location = new System.Drawing.Point(75, 0);
            this.ExchangeLabel.Name = "ExchangeLabel";
            this.ExchangeLabel.Size = new System.Drawing.Size(329, 47);
            this.ExchangeLabel.TabIndex = 1;
            this.ExchangeLabel.Text = "Exchange Rate";
            // 
            // BuyLabel
            // 
            this.BuyLabel.AutoSize = true;
            this.BuyLabel.Font = new System.Drawing.Font("Bookman Old Style", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyLabel.Location = new System.Drawing.Point(49, 107);
            this.BuyLabel.Name = "BuyLabel";
            this.BuyLabel.Size = new System.Drawing.Size(84, 40);
            this.BuyLabel.TabIndex = 1;
            this.BuyLabel.Text = "Buy";
            // 
            // UsdLabel
            // 
            this.UsdLabel.AutoSize = true;
            this.UsdLabel.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsdLabel.Location = new System.Drawing.Point(197, 166);
            this.UsdLabel.Name = "UsdLabel";
            this.UsdLabel.Size = new System.Drawing.Size(65, 28);
            this.UsdLabel.TabIndex = 2;
            this.UsdLabel.Text = "USD";
            this.UsdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SellLabel
            // 
            this.SellLabel.AutoSize = true;
            this.SellLabel.Font = new System.Drawing.Font("Bookman Old Style", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SellLabel.Location = new System.Drawing.Point(318, 107);
            this.SellLabel.Name = "SellLabel";
            this.SellLabel.Size = new System.Drawing.Size(83, 40);
            this.SellLabel.TabIndex = 3;
            this.SellLabel.Text = "Sell";
            // 
            // EurLabel
            // 
            this.EurLabel.AutoSize = true;
            this.EurLabel.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EurLabel.Location = new System.Drawing.Point(196, 260);
            this.EurLabel.Name = "EurLabel";
            this.EurLabel.Size = new System.Drawing.Size(66, 28);
            this.EurLabel.TabIndex = 4;
            this.EurLabel.Text = "EUR";
            // 
            // PlnLabel
            // 
            this.PlnLabel.AutoSize = true;
            this.PlnLabel.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlnLabel.Location = new System.Drawing.Point(197, 358);
            this.PlnLabel.Name = "PlnLabel";
            this.PlnLabel.Size = new System.Drawing.Size(61, 28);
            this.PlnLabel.TabIndex = 5;
            this.PlnLabel.Text = "PLN";
            // 
            // PlnFlagPicture
            // 
            this.PlnFlagPicture.Image = global::Exchange.Properties.Resources.plnFlag;
            this.PlnFlagPicture.Location = new System.Drawing.Point(191, 389);
            this.PlnFlagPicture.Name = "PlnFlagPicture";
            this.PlnFlagPicture.Size = new System.Drawing.Size(71, 40);
            this.PlnFlagPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlnFlagPicture.TabIndex = 8;
            this.PlnFlagPicture.TabStop = false;
            // 
            // EurFlagPicture
            // 
            this.EurFlagPicture.Image = global::Exchange.Properties.Resources.eurFlag;
            this.EurFlagPicture.Location = new System.Drawing.Point(191, 291);
            this.EurFlagPicture.Name = "EurFlagPicture";
            this.EurFlagPicture.Size = new System.Drawing.Size(71, 40);
            this.EurFlagPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EurFlagPicture.TabIndex = 7;
            this.EurFlagPicture.TabStop = false;
            // 
            // UsdFlagPicture
            // 
            this.UsdFlagPicture.Image = global::Exchange.Properties.Resources.usdFlag;
            this.UsdFlagPicture.Location = new System.Drawing.Point(191, 197);
            this.UsdFlagPicture.Name = "UsdFlagPicture";
            this.UsdFlagPicture.Size = new System.Drawing.Size(71, 40);
            this.UsdFlagPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UsdFlagPicture.TabIndex = 6;
            this.UsdFlagPicture.TabStop = false;
            // 
            // UsdBuyLabel
            // 
            this.UsdBuyLabel.AutoSize = true;
            this.UsdBuyLabel.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsdBuyLabel.Location = new System.Drawing.Point(50, 182);
            this.UsdBuyLabel.Name = "UsdBuyLabel";
            this.UsdBuyLabel.Size = new System.Drawing.Size(95, 32);
            this.UsdBuyLabel.TabIndex = 9;
            this.UsdBuyLabel.Text = "27.50";
            // 
            // UsdSellLabel
            // 
            this.UsdSellLabel.AutoSize = true;
            this.UsdSellLabel.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsdSellLabel.Location = new System.Drawing.Point(319, 182);
            this.UsdSellLabel.Name = "UsdSellLabel";
            this.UsdSellLabel.Size = new System.Drawing.Size(95, 32);
            this.UsdSellLabel.TabIndex = 10;
            this.UsdSellLabel.Text = "28.40";
            // 
            // EurBuyLabel
            // 
            this.EurBuyLabel.AutoSize = true;
            this.EurBuyLabel.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EurBuyLabel.Location = new System.Drawing.Point(50, 281);
            this.EurBuyLabel.Name = "EurBuyLabel";
            this.EurBuyLabel.Size = new System.Drawing.Size(95, 32);
            this.EurBuyLabel.TabIndex = 11;
            this.EurBuyLabel.Text = "31.65";
            // 
            // EurSellLabel
            // 
            this.EurSellLabel.AutoSize = true;
            this.EurSellLabel.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EurSellLabel.Location = new System.Drawing.Point(319, 281);
            this.EurSellLabel.Name = "EurSellLabel";
            this.EurSellLabel.Size = new System.Drawing.Size(95, 32);
            this.EurSellLabel.TabIndex = 12;
            this.EurSellLabel.Text = "32.30";
            // 
            // PlnBuyLabel
            // 
            this.PlnBuyLabel.AutoSize = true;
            this.PlnBuyLabel.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlnBuyLabel.Location = new System.Drawing.Point(56, 377);
            this.PlnBuyLabel.Name = "PlnBuyLabel";
            this.PlnBuyLabel.Size = new System.Drawing.Size(77, 32);
            this.PlnBuyLabel.TabIndex = 13;
            this.PlnBuyLabel.Text = "5.80";
            // 
            // PlnSellLabel
            // 
            this.PlnSellLabel.AutoSize = true;
            this.PlnSellLabel.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlnSellLabel.Location = new System.Drawing.Point(337, 377);
            this.PlnSellLabel.Name = "PlnSellLabel";
            this.PlnSellLabel.Size = new System.Drawing.Size(77, 32);
            this.PlnSellLabel.TabIndex = 14;
            this.PlnSellLabel.Text = "6.66";
            // 
            // UpdasteButton
            // 
            this.UpdasteButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdasteButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdasteButton.FlatAppearance.BorderSize = 0;
            this.UpdasteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdasteButton.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdasteButton.ForeColor = System.Drawing.Color.Gold;
            this.UpdasteButton.Location = new System.Drawing.Point(175, 464);
            this.UpdasteButton.Name = "UpdasteButton";
            this.UpdasteButton.Size = new System.Drawing.Size(100, 31);
            this.UpdasteButton.TabIndex = 15;
            this.UpdasteButton.Text = "Update";
            this.UpdasteButton.UseVisualStyleBackColor = false;
            this.UpdasteButton.Click += new System.EventHandler(this.UpdasteButton_Click);
            // 
            // Exchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(462, 507);
            this.Controls.Add(this.UpdasteButton);
            this.Controls.Add(this.PlnSellLabel);
            this.Controls.Add(this.PlnBuyLabel);
            this.Controls.Add(this.EurSellLabel);
            this.Controls.Add(this.EurBuyLabel);
            this.Controls.Add(this.UsdSellLabel);
            this.Controls.Add(this.UsdBuyLabel);
            this.Controls.Add(this.PlnFlagPicture);
            this.Controls.Add(this.EurFlagPicture);
            this.Controls.Add(this.UsdFlagPicture);
            this.Controls.Add(this.PlnLabel);
            this.Controls.Add(this.EurLabel);
            this.Controls.Add(this.SellLabel);
            this.Controls.Add(this.UsdLabel);
            this.Controls.Add(this.BuyLabel);
            this.Controls.Add(this.panel1);
            this.Name = "Exchange";
            this.Text = "Exchange";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlnFlagPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EurFlagPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsdFlagPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label BuyLabel;
        private System.Windows.Forms.Label UsdLabel;
        public System.Windows.Forms.Label ExchangeLabel;
        private System.Windows.Forms.Label SellLabel;
        private System.Windows.Forms.Label EurLabel;
        private System.Windows.Forms.Label PlnLabel;
        private System.Windows.Forms.PictureBox UsdFlagPicture;
        private System.Windows.Forms.PictureBox EurFlagPicture;
        private System.Windows.Forms.PictureBox PlnFlagPicture;
        private System.Windows.Forms.Label UsdBuyLabel;
        private System.Windows.Forms.Label UsdSellLabel;
        private System.Windows.Forms.Label EurBuyLabel;
        private System.Windows.Forms.Label EurSellLabel;
        private System.Windows.Forms.Label PlnBuyLabel;
        private System.Windows.Forms.Label PlnSellLabel;
        private System.Windows.Forms.Button UpdasteButton;
    }
}