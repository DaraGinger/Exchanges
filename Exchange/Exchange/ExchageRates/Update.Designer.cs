﻿namespace Exchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TurnButton = new System.Windows.Forms.Button();
            this.UpdateLabel = new System.Windows.Forms.Label();
            this.BuyLabel = new System.Windows.Forms.Label();
            this.SellLabel = new System.Windows.Forms.Label();
            this.UsdLabel = new System.Windows.Forms.Label();
            this.EurLabel = new System.Windows.Forms.Label();
            this.PlnLabel = new System.Windows.Forms.Label();
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsdFlagPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EurFlagPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlnFlagPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.TurnButton);
            this.panel1.Controls.Add(this.UpdateLabel);
            this.panel1.Controls.Add(this.BuyLabel);
            this.panel1.Controls.Add(this.SellLabel);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 124);
            this.panel1.TabIndex = 0;
            // 
            // TurnButton
            // 
            this.TurnButton.BackColor = System.Drawing.Color.Black;
            this.TurnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TurnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TurnButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TurnButton.ForeColor = System.Drawing.Color.Gold;
            this.TurnButton.Location = new System.Drawing.Point(454, 25);
            this.TurnButton.Name = "TurnButton";
            this.TurnButton.Size = new System.Drawing.Size(25, 25);
            this.TurnButton.TabIndex = 17;
            this.TurnButton.Text = "—";
            this.TurnButton.UseVisualStyleBackColor = false;
            this.TurnButton.Click += new System.EventHandler(this.TurnButton_Click);
            // 
            // UpdateLabel
            // 
            this.UpdateLabel.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateLabel.ForeColor = System.Drawing.Color.Gold;
            this.UpdateLabel.Location = new System.Drawing.Point(3, 0);
            this.UpdateLabel.Name = "UpdateLabel";
            this.UpdateLabel.Size = new System.Drawing.Size(476, 45);
            this.UpdateLabel.TabIndex = 1;
            this.UpdateLabel.Text = "Update";
            this.UpdateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpdateLabel_MouseDown);
            this.UpdateLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpdateLabel_MouseMove);
            this.UpdateLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpdateLabel_MouseUp);
            // 
            // BuyLabel
            // 
            this.BuyLabel.AutoSize = true;
            this.BuyLabel.BackColor = System.Drawing.Color.Transparent;
            this.BuyLabel.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyLabel.ForeColor = System.Drawing.Color.Gold;
            this.BuyLabel.Location = new System.Drawing.Point(20, 73);
            this.BuyLabel.Name = "BuyLabel";
            this.BuyLabel.Size = new System.Drawing.Size(84, 51);
            this.BuyLabel.TabIndex = 1;
            this.BuyLabel.Text = "Buy";
            // 
            // SellLabel
            // 
            this.SellLabel.AutoSize = true;
            this.SellLabel.BackColor = System.Drawing.Color.Transparent;
            this.SellLabel.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SellLabel.ForeColor = System.Drawing.Color.Gold;
            this.SellLabel.Location = new System.Drawing.Point(373, 73);
            this.SellLabel.Name = "SellLabel";
            this.SellLabel.Size = new System.Drawing.Size(89, 51);
            this.SellLabel.TabIndex = 3;
            this.SellLabel.Text = "Sell";
            // 
            // UsdLabel
            // 
            this.UsdLabel.AutoSize = true;
            this.UsdLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsdLabel.Location = new System.Drawing.Point(211, 126);
            this.UsdLabel.Name = "UsdLabel";
            this.UsdLabel.Size = new System.Drawing.Size(67, 35);
            this.UsdLabel.TabIndex = 2;
            this.UsdLabel.Text = "USD";
            this.UsdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EurLabel
            // 
            this.EurLabel.AutoSize = true;
            this.EurLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EurLabel.Location = new System.Drawing.Point(214, 224);
            this.EurLabel.Name = "EurLabel";
            this.EurLabel.Size = new System.Drawing.Size(63, 35);
            this.EurLabel.TabIndex = 4;
            this.EurLabel.Text = "EUR";
            // 
            // PlnLabel
            // 
            this.PlnLabel.AutoSize = true;
            this.PlnLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlnLabel.Location = new System.Drawing.Point(214, 324);
            this.PlnLabel.Name = "PlnLabel";
            this.PlnLabel.Size = new System.Drawing.Size(61, 35);
            this.PlnLabel.TabIndex = 5;
            this.PlnLabel.Text = "PLN";
            // 
            // UsdBuyText
            // 
            this.UsdBuyText.BackColor = System.Drawing.SystemColors.Window;
            this.UsdBuyText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsdBuyText.Location = new System.Drawing.Point(27, 164);
            this.UsdBuyText.Name = "UsdBuyText";
            this.UsdBuyText.Size = new System.Drawing.Size(100, 26);
            this.UsdBuyText.TabIndex = 9;
            this.UsdBuyText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsdBuyText_KeyPress);
            // 
            // EurBuyText
            // 
            this.EurBuyText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EurBuyText.Location = new System.Drawing.Point(27, 264);
            this.EurBuyText.Name = "EurBuyText";
            this.EurBuyText.Size = new System.Drawing.Size(100, 26);
            this.EurBuyText.TabIndex = 11;
            this.EurBuyText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EurBuyText_KeyPress);
            // 
            // PlnBuyText
            // 
            this.PlnBuyText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlnBuyText.Location = new System.Drawing.Point(27, 364);
            this.PlnBuyText.Name = "PlnBuyText";
            this.PlnBuyText.Size = new System.Drawing.Size(100, 26);
            this.PlnBuyText.TabIndex = 13;
            this.PlnBuyText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlnBuyText_KeyPress);
            // 
            // UsdSellText
            // 
            this.UsdSellText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsdSellText.Location = new System.Drawing.Point(360, 164);
            this.UsdSellText.Name = "UsdSellText";
            this.UsdSellText.Size = new System.Drawing.Size(100, 26);
            this.UsdSellText.TabIndex = 10;
            this.UsdSellText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsdSellText_KeyPress);
            // 
            // EurSellText
            // 
            this.EurSellText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EurSellText.Location = new System.Drawing.Point(360, 264);
            this.EurSellText.Name = "EurSellText";
            this.EurSellText.Size = new System.Drawing.Size(100, 26);
            this.EurSellText.TabIndex = 12;
            this.EurSellText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EurSellText_KeyPress);
            // 
            // PlnSellText
            // 
            this.PlnSellText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlnSellText.Location = new System.Drawing.Point(360, 364);
            this.PlnSellText.Name = "PlnSellText";
            this.PlnSellText.Size = new System.Drawing.Size(100, 26);
            this.PlnSellText.TabIndex = 14;
            this.PlnSellText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlnSellText_KeyPress);
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkButton.ForeColor = System.Drawing.Color.Gold;
            this.OkButton.Location = new System.Drawing.Point(195, 462);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(100, 40);
            this.OkButton.TabIndex = 16;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // UsdFlagPicture
            // 
            this.UsdFlagPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsdFlagPicture.Image = global::Exchange.Properties.Resources.NewUsdFlag;
            this.UsdFlagPicture.Location = new System.Drawing.Point(202, 164);
            this.UsdFlagPicture.Name = "UsdFlagPicture";
            this.UsdFlagPicture.Size = new System.Drawing.Size(83, 49);
            this.UsdFlagPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UsdFlagPicture.TabIndex = 6;
            this.UsdFlagPicture.TabStop = false;
            // 
            // EurFlagPicture
            // 
            this.EurFlagPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EurFlagPicture.Image = global::Exchange.Properties.Resources.eurFlag;
            this.EurFlagPicture.Location = new System.Drawing.Point(204, 262);
            this.EurFlagPicture.Name = "EurFlagPicture";
            this.EurFlagPicture.Size = new System.Drawing.Size(83, 49);
            this.EurFlagPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EurFlagPicture.TabIndex = 7;
            this.EurFlagPicture.TabStop = false;
            // 
            // PlnFlagPicture
            // 
            this.PlnFlagPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlnFlagPicture.Image = global::Exchange.Properties.Resources.NewPlnFlag;
            this.PlnFlagPicture.Location = new System.Drawing.Point(204, 362);
            this.PlnFlagPicture.Name = "PlnFlagPicture";
            this.PlnFlagPicture.Size = new System.Drawing.Size(83, 50);
            this.PlnFlagPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlnFlagPicture.TabIndex = 8;
            this.PlnFlagPicture.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Black;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.Gold;
            this.ExitButton.Location = new System.Drawing.Point(454, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(25, 25);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(478, 546);
            this.Controls.Add(this.ExitButton);
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
            this.Controls.Add(this.PlnLabel);
            this.Controls.Add(this.EurLabel);
            this.Controls.Add(this.UsdLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsdFlagPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EurFlagPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlnFlagPicture)).EndInit();
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
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button TurnButton;
    }
}