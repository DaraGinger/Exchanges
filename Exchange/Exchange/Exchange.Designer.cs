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
            this.ExchangePanel = new System.Windows.Forms.Panel();
            this.ExchangeLabel = new System.Windows.Forms.Label();
            this.BuyLabel = new System.Windows.Forms.Label();
            this.UsdLabel = new System.Windows.Forms.Label();
            this.SellLabel = new System.Windows.Forms.Label();
            this.EurLabel = new System.Windows.Forms.Label();
            this.PlnLabel = new System.Windows.Forms.Label();
            this.PlnFlagPicture = new System.Windows.Forms.PictureBox();
            this.EurFlagPicture = new System.Windows.Forms.PictureBox();
            this.UsdFlagPicture = new System.Windows.Forms.PictureBox();
            this.UpdasteButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.BuyingButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.UsdBuyMainText = new System.Windows.Forms.TextBox();
            this.EurBuyMainText = new System.Windows.Forms.TextBox();
            this.PlnBuyMainText = new System.Windows.Forms.TextBox();
            this.UsdSellMainText = new System.Windows.Forms.TextBox();
            this.EurSellMainText = new System.Windows.Forms.TextBox();
            this.PlnSellMainText = new System.Windows.Forms.TextBox();
            this.ExchangePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlnFlagPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EurFlagPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsdFlagPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ExchangePanel
            // 
            this.ExchangePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExchangePanel.Controls.Add(this.ExchangeLabel);
            this.ExchangePanel.Location = new System.Drawing.Point(-5, 24);
            this.ExchangePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExchangePanel.Name = "ExchangePanel";
            this.ExchangePanel.Size = new System.Drawing.Size(546, 52);
            this.ExchangePanel.TabIndex = 0;
            // 
            // ExchangeLabel
            // 
            this.ExchangeLabel.AutoSize = true;
            this.ExchangeLabel.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExchangeLabel.ForeColor = System.Drawing.Color.Gold;
            this.ExchangeLabel.Location = new System.Drawing.Point(136, 0);
            this.ExchangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExchangeLabel.Name = "ExchangeLabel";
            this.ExchangeLabel.Size = new System.Drawing.Size(275, 45);
            this.ExchangeLabel.TabIndex = 1;
            this.ExchangeLabel.Text = "Exchange Rate";
            // 
            // BuyLabel
            // 
            this.BuyLabel.AutoSize = true;
            this.BuyLabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyLabel.Location = new System.Drawing.Point(57, 107);
            this.BuyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BuyLabel.Name = "BuyLabel";
            this.BuyLabel.Size = new System.Drawing.Size(82, 42);
            this.BuyLabel.TabIndex = 1;
            this.BuyLabel.Text = "Buy";
            // 
            // UsdLabel
            // 
            this.UsdLabel.AutoSize = true;
            this.UsdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsdLabel.Location = new System.Drawing.Point(230, 166);
            this.UsdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsdLabel.Name = "UsdLabel";
            this.UsdLabel.Size = new System.Drawing.Size(66, 29);
            this.UsdLabel.TabIndex = 2;
            this.UsdLabel.Text = "USD";
            this.UsdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SellLabel
            // 
            this.SellLabel.AutoSize = true;
            this.SellLabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SellLabel.Location = new System.Drawing.Point(371, 107);
            this.SellLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SellLabel.Name = "SellLabel";
            this.SellLabel.Size = new System.Drawing.Size(75, 42);
            this.SellLabel.TabIndex = 3;
            this.SellLabel.Text = "Sell";
            // 
            // EurLabel
            // 
            this.EurLabel.AutoSize = true;
            this.EurLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EurLabel.Location = new System.Drawing.Point(229, 260);
            this.EurLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EurLabel.Name = "EurLabel";
            this.EurLabel.Size = new System.Drawing.Size(66, 29);
            this.EurLabel.TabIndex = 4;
            this.EurLabel.Text = "EUR";
            // 
            // PlnLabel
            // 
            this.PlnLabel.AutoSize = true;
            this.PlnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlnLabel.Location = new System.Drawing.Point(230, 358);
            this.PlnLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlnLabel.Name = "PlnLabel";
            this.PlnLabel.Size = new System.Drawing.Size(63, 29);
            this.PlnLabel.TabIndex = 5;
            this.PlnLabel.Text = "PLN";
            // 
            // PlnFlagPicture
            // 
            this.PlnFlagPicture.Image = global::Exchange.Properties.Resources.plnFlag;
            this.PlnFlagPicture.Location = new System.Drawing.Point(223, 389);
            this.PlnFlagPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PlnFlagPicture.Name = "PlnFlagPicture";
            this.PlnFlagPicture.Size = new System.Drawing.Size(83, 40);
            this.PlnFlagPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlnFlagPicture.TabIndex = 8;
            this.PlnFlagPicture.TabStop = false;
            // 
            // EurFlagPicture
            // 
            this.EurFlagPicture.Image = global::Exchange.Properties.Resources.eurFlag;
            this.EurFlagPicture.Location = new System.Drawing.Point(223, 291);
            this.EurFlagPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EurFlagPicture.Name = "EurFlagPicture";
            this.EurFlagPicture.Size = new System.Drawing.Size(83, 40);
            this.EurFlagPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EurFlagPicture.TabIndex = 7;
            this.EurFlagPicture.TabStop = false;
            // 
            // UsdFlagPicture
            // 
            this.UsdFlagPicture.Image = global::Exchange.Properties.Resources.usdFlag;
            this.UsdFlagPicture.Location = new System.Drawing.Point(223, 197);
            this.UsdFlagPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UsdFlagPicture.Name = "UsdFlagPicture";
            this.UsdFlagPicture.Size = new System.Drawing.Size(83, 40);
            this.UsdFlagPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UsdFlagPicture.TabIndex = 6;
            this.UsdFlagPicture.TabStop = false;
            // 
            // UpdasteButton
            // 
            this.UpdasteButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdasteButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdasteButton.FlatAppearance.BorderSize = 0;
            this.UpdasteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdasteButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdasteButton.ForeColor = System.Drawing.Color.Gold;
            this.UpdasteButton.Location = new System.Drawing.Point(202, 450);
            this.UpdasteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpdasteButton.Name = "UpdasteButton";
            this.UpdasteButton.Size = new System.Drawing.Size(117, 31);
            this.UpdasteButton.TabIndex = 15;
            this.UpdasteButton.Text = "Update";
            this.UpdasteButton.UseVisualStyleBackColor = false;
            this.UpdasteButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshButton.ForeColor = System.Drawing.Color.Gold;
            this.RefreshButton.Location = new System.Drawing.Point(180, 500);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(159, 31);
            this.RefreshButton.TabIndex = 17;
            this.RefreshButton.Text = "Refresh page";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // BuyingButton
            // 
            this.BuyingButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BuyingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyingButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyingButton.ForeColor = System.Drawing.Color.Gold;
            this.BuyingButton.Location = new System.Drawing.Point(38, 468);
            this.BuyingButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuyingButton.Name = "BuyingButton";
            this.BuyingButton.Size = new System.Drawing.Size(117, 31);
            this.BuyingButton.TabIndex = 18;
            this.BuyingButton.Text = "Buying";
            this.BuyingButton.UseVisualStyleBackColor = false;
            this.BuyingButton.Click += new System.EventHandler(this.BuyingButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(366, 469);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 30);
            this.button3.TabIndex = 19;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // UsdBuyMainText
            // 
            this.UsdBuyMainText.BackColor = System.Drawing.Color.Gold;
            this.UsdBuyMainText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsdBuyMainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsdBuyMainText.Location = new System.Drawing.Point(51, 182);
            this.UsdBuyMainText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UsdBuyMainText.Name = "UsdBuyMainText";
            this.UsdBuyMainText.Size = new System.Drawing.Size(104, 31);
            this.UsdBuyMainText.TabIndex = 20;
            this.UsdBuyMainText.Text = "27.36";
            // 
            // EurBuyMainText
            // 
            this.EurBuyMainText.BackColor = System.Drawing.Color.Gold;
            this.EurBuyMainText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EurBuyMainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EurBuyMainText.Location = new System.Drawing.Point(65, 278);
            this.EurBuyMainText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EurBuyMainText.Name = "EurBuyMainText";
            this.EurBuyMainText.Size = new System.Drawing.Size(104, 31);
            this.EurBuyMainText.TabIndex = 21;
            this.EurBuyMainText.Text = "31.68";
            // 
            // PlnBuyMainText
            // 
            this.PlnBuyMainText.BackColor = System.Drawing.Color.Gold;
            this.PlnBuyMainText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlnBuyMainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlnBuyMainText.Location = new System.Drawing.Point(65, 374);
            this.PlnBuyMainText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PlnBuyMainText.Name = "PlnBuyMainText";
            this.PlnBuyMainText.Size = new System.Drawing.Size(104, 31);
            this.PlnBuyMainText.TabIndex = 22;
            this.PlnBuyMainText.Text = "5.67";
            // 
            // UsdSellMainText
            // 
            this.UsdSellMainText.BackColor = System.Drawing.Color.Gold;
            this.UsdSellMainText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsdSellMainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsdSellMainText.Location = new System.Drawing.Point(379, 182);
            this.UsdSellMainText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UsdSellMainText.Name = "UsdSellMainText";
            this.UsdSellMainText.Size = new System.Drawing.Size(104, 31);
            this.UsdSellMainText.TabIndex = 23;
            this.UsdSellMainText.Text = "28.20";
            // 
            // EurSellMainText
            // 
            this.EurSellMainText.BackColor = System.Drawing.Color.Gold;
            this.EurSellMainText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EurSellMainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EurSellMainText.Location = new System.Drawing.Point(379, 278);
            this.EurSellMainText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EurSellMainText.Name = "EurSellMainText";
            this.EurSellMainText.Size = new System.Drawing.Size(104, 31);
            this.EurSellMainText.TabIndex = 24;
            this.EurSellMainText.Text = "32.80";
            // 
            // PlnSellMainText
            // 
            this.PlnSellMainText.BackColor = System.Drawing.Color.Gold;
            this.PlnSellMainText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlnSellMainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlnSellMainText.Location = new System.Drawing.Point(379, 374);
            this.PlnSellMainText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PlnSellMainText.Name = "PlnSellMainText";
            this.PlnSellMainText.Size = new System.Drawing.Size(104, 31);
            this.PlnSellMainText.TabIndex = 25;
            this.PlnSellMainText.Text = "6.66";
            // 
            // Exchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(539, 533);
            this.Controls.Add(this.PlnSellMainText);
            this.Controls.Add(this.EurSellMainText);
            this.Controls.Add(this.UsdSellMainText);
            this.Controls.Add(this.PlnBuyMainText);
            this.Controls.Add(this.EurBuyMainText);
            this.Controls.Add(this.UsdBuyMainText);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BuyingButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.UpdasteButton);
            this.Controls.Add(this.PlnFlagPicture);
            this.Controls.Add(this.EurFlagPicture);
            this.Controls.Add(this.UsdFlagPicture);
            this.Controls.Add(this.PlnLabel);
            this.Controls.Add(this.EurLabel);
            this.Controls.Add(this.SellLabel);
            this.Controls.Add(this.UsdLabel);
            this.Controls.Add(this.BuyLabel);
            this.Controls.Add(this.ExchangePanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Exchange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exchange";
            this.ExchangePanel.ResumeLayout(false);
            this.ExchangePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlnFlagPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EurFlagPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsdFlagPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ExchangePanel;
        private System.Windows.Forms.Label BuyLabel;
        private System.Windows.Forms.Label UsdLabel;
        private System.Windows.Forms.Label ExchangeLabel;
        private System.Windows.Forms.Label SellLabel;
        private System.Windows.Forms.Label EurLabel;
        private System.Windows.Forms.Label PlnLabel;
        private System.Windows.Forms.PictureBox UsdFlagPicture;
        private System.Windows.Forms.PictureBox EurFlagPicture;
        private System.Windows.Forms.PictureBox PlnFlagPicture;
        private System.Windows.Forms.Button UpdasteButton;
        public System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button BuyingButton;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox UsdBuyMainText;
        public System.Windows.Forms.TextBox EurBuyMainText;
        public System.Windows.Forms.TextBox PlnBuyMainText;
        public System.Windows.Forms.TextBox UsdSellMainText;
        public System.Windows.Forms.TextBox EurSellMainText;
        public System.Windows.Forms.TextBox PlnSellMainText;
    }
}