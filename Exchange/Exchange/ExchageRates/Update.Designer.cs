namespace Exchange
{
    partial class Update
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
            this.UpdateLabel = new System.Windows.Forms.Label();
            this.UsdLabel = new System.Windows.Forms.Label();
            this.EurLabel = new System.Windows.Forms.Label();
            this.PlnLabel = new System.Windows.Forms.Label();
            this.BuyLabel = new System.Windows.Forms.Label();
            this.SellLabel = new System.Windows.Forms.Label();
            this.UsdBuyText = new System.Windows.Forms.TextBox();
            this.EurBuyText = new System.Windows.Forms.TextBox();
            this.PlnBuyText = new System.Windows.Forms.TextBox();
            this.UsdSellText = new System.Windows.Forms.TextBox();
            this.EurSellText = new System.Windows.Forms.TextBox();
            this.PlnSellText = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.UsdFlagPicture = new System.Windows.Forms.PictureBox();
            this.EurFlagPicture = new System.Windows.Forms.PictureBox();
            this.PlnFlagPicture = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsdFlagPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EurFlagPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlnFlagPicture)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.UpdateLabel);
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 52);
            this.panel1.TabIndex = 0;
            // 
            // UpdateLabel
            // 
            this.UpdateLabel.AutoSize = true;
            this.UpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateLabel.ForeColor = System.Drawing.Color.Gold;
            this.UpdateLabel.Location = new System.Drawing.Point(148, 6);
            this.UpdateLabel.Name = "UpdateLabel";
            this.UpdateLabel.Size = new System.Drawing.Size(154, 46);
            this.UpdateLabel.TabIndex = 1;
            this.UpdateLabel.Text = "Update";
            // 
            // UsdLabel
            // 
            this.UsdLabel.AutoSize = true;
            this.UsdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsdLabel.Location = new System.Drawing.Point(210, 216);
            this.UsdLabel.Name = "UsdLabel";
            this.UsdLabel.Size = new System.Drawing.Size(66, 29);
            this.UsdLabel.TabIndex = 2;
            this.UsdLabel.Text = "USD";
            this.UsdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EurLabel
            // 
            this.EurLabel.AutoSize = true;
            this.EurLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EurLabel.Location = new System.Drawing.Point(210, 308);
            this.EurLabel.Name = "EurLabel";
            this.EurLabel.Size = new System.Drawing.Size(66, 29);
            this.EurLabel.TabIndex = 4;
            this.EurLabel.Text = "EUR";
            // 
            // PlnLabel
            // 
            this.PlnLabel.AutoSize = true;
            this.PlnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlnLabel.Location = new System.Drawing.Point(210, 401);
            this.PlnLabel.Name = "PlnLabel";
            this.PlnLabel.Size = new System.Drawing.Size(63, 29);
            this.PlnLabel.TabIndex = 5;
            this.PlnLabel.Text = "PLN";
            // 
            // BuyLabel
            // 
            this.BuyLabel.AutoSize = true;
            this.BuyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyLabel.Location = new System.Drawing.Point(35, 153);
            this.BuyLabel.Name = "BuyLabel";
            this.BuyLabel.Size = new System.Drawing.Size(79, 39);
            this.BuyLabel.TabIndex = 1;
            this.BuyLabel.Text = "Buy";
            // 
            // SellLabel
            // 
            this.SellLabel.AutoSize = true;
            this.SellLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SellLabel.Location = new System.Drawing.Point(359, 153);
            this.SellLabel.Name = "SellLabel";
            this.SellLabel.Size = new System.Drawing.Size(79, 39);
            this.SellLabel.TabIndex = 3;
            this.SellLabel.Text = "Sell";
            // 
            // UsdBuyText
            // 
            this.UsdBuyText.BackColor = System.Drawing.SystemColors.Window;
            this.UsdBuyText.Location = new System.Drawing.Point(28, 248);
            this.UsdBuyText.Name = "UsdBuyText";
            this.UsdBuyText.Size = new System.Drawing.Size(100, 20);
            this.UsdBuyText.TabIndex = 9;
            this.UsdBuyText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsdBuyText_KeyPress);
            // 
            // EurBuyText
            // 
            this.EurBuyText.Location = new System.Drawing.Point(28, 340);
            this.EurBuyText.Name = "EurBuyText";
            this.EurBuyText.Size = new System.Drawing.Size(100, 20);
            this.EurBuyText.TabIndex = 11;
            this.EurBuyText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EurBuyText_KeyPress);
            // 
            // PlnBuyText
            // 
            this.PlnBuyText.Location = new System.Drawing.Point(28, 433);
            this.PlnBuyText.Name = "PlnBuyText";
            this.PlnBuyText.Size = new System.Drawing.Size(100, 20);
            this.PlnBuyText.TabIndex = 13;
            this.PlnBuyText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlnBuyText_KeyPress);
            // 
            // UsdSellText
            // 
            this.UsdSellText.Location = new System.Drawing.Point(338, 248);
            this.UsdSellText.Name = "UsdSellText";
            this.UsdSellText.Size = new System.Drawing.Size(100, 20);
            this.UsdSellText.TabIndex = 10;
            this.UsdSellText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsdSellText_KeyPress);
            // 
            // EurSellText
            // 
            this.EurSellText.Location = new System.Drawing.Point(338, 340);
            this.EurSellText.Name = "EurSellText";
            this.EurSellText.Size = new System.Drawing.Size(100, 20);
            this.EurSellText.TabIndex = 12;
            this.EurSellText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EurSellText_KeyPress);
            // 
            // PlnSellText
            // 
            this.PlnSellText.Location = new System.Drawing.Point(338, 433);
            this.PlnSellText.Name = "PlnSellText";
            this.PlnSellText.Size = new System.Drawing.Size(100, 20);
            this.PlnSellText.TabIndex = 14;
            this.PlnSellText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlnSellText_KeyPress);
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkButton.ForeColor = System.Drawing.Color.Gold;
            this.OkButton.Location = new System.Drawing.Point(191, 502);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(94, 32);
            this.OkButton.TabIndex = 16;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // UsdFlagPicture
            // 
            this.UsdFlagPicture.Image = global::Exchange.Properties.Resources.usdFlag;
            this.UsdFlagPicture.Location = new System.Drawing.Point(202, 248);
            this.UsdFlagPicture.Name = "UsdFlagPicture";
            this.UsdFlagPicture.Size = new System.Drawing.Size(71, 40);
            this.UsdFlagPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UsdFlagPicture.TabIndex = 6;
            this.UsdFlagPicture.TabStop = false;
            // 
            // EurFlagPicture
            // 
            this.EurFlagPicture.Image = global::Exchange.Properties.Resources.eurFlag;
            this.EurFlagPicture.Location = new System.Drawing.Point(202, 340);
            this.EurFlagPicture.Name = "EurFlagPicture";
            this.EurFlagPicture.Size = new System.Drawing.Size(71, 40);
            this.EurFlagPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EurFlagPicture.TabIndex = 7;
            this.EurFlagPicture.TabStop = false;
            // 
            // PlnFlagPicture
            // 
            this.PlnFlagPicture.Image = global::Exchange.Properties.Resources.plnFlag;
            this.PlnFlagPicture.Location = new System.Drawing.Point(202, 433);
            this.PlnFlagPicture.Name = "PlnFlagPicture";
            this.PlnFlagPicture.Size = new System.Drawing.Size(71, 40);
            this.PlnFlagPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlnFlagPicture.TabIndex = 8;
            this.PlnFlagPicture.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 22);
            this.panel2.TabIndex = 17;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(458, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(22, 22);
            this.ExitButton.TabIndex = 18;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(478, 546);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.PlnSellText);
            this.Controls.Add(this.EurSellText);
            this.Controls.Add(this.UsdSellText);
            this.Controls.Add(this.PlnBuyText);
            this.Controls.Add(this.EurBuyText);
            this.Controls.Add(this.UsdBuyText);
            this.Controls.Add(this.UsdFlagPicture);
            this.Controls.Add(this.EurFlagPicture);
            this.Controls.Add(this.PlnFlagPicture);
            this.Controls.Add(this.SellLabel);
            this.Controls.Add(this.BuyLabel);
            this.Controls.Add(this.PlnLabel);
            this.Controls.Add(this.EurLabel);
            this.Controls.Add(this.UsdLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsdFlagPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EurFlagPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlnFlagPicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label UpdateLabel;
        private System.Windows.Forms.Label UsdLabel;
        private System.Windows.Forms.Label EurLabel;
        private System.Windows.Forms.Label PlnLabel;
        private System.Windows.Forms.Label BuyLabel;
        private System.Windows.Forms.Label SellLabel;
        private System.Windows.Forms.PictureBox PlnFlagPicture;
        private System.Windows.Forms.PictureBox EurFlagPicture;
        private System.Windows.Forms.PictureBox UsdFlagPicture;
        public System.Windows.Forms.TextBox UsdBuyText;
        public System.Windows.Forms.TextBox EurBuyText;
        public System.Windows.Forms.TextBox PlnBuyText;
        public System.Windows.Forms.TextBox UsdSellText;
        public System.Windows.Forms.TextBox EurSellText;
        public System.Windows.Forms.TextBox PlnSellText;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ExitButton;
    }
}