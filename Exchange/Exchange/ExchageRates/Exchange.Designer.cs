namespace Exchange
{
    partial class ExchangeMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExchangeMainPage));
            this.ExchangePanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.ExchangeLabel = new System.Windows.Forms.Label();
            this.BuyLabel = new System.Windows.Forms.Label();
            this.SellLabel = new System.Windows.Forms.Label();
            this.UsdLabel = new System.Windows.Forms.Label();
            this.EurLabel = new System.Windows.Forms.Label();
            this.PlnLabel = new System.Windows.Forms.Label();
            this.UpdasteButton = new System.Windows.Forms.Button();
            this.BuyingButton = new System.Windows.Forms.Button();
            this.SellButton = new System.Windows.Forms.Button();
            this.UsdBuyLabel = new System.Windows.Forms.Label();
            this.EurBuyLabel = new System.Windows.Forms.Label();
            this.PlnBuyLabel = new System.Windows.Forms.Label();
            this.UsdSellLabel = new System.Windows.Forms.Label();
            this.EurSellLabel = new System.Windows.Forms.Label();
            this.PlnSellLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PlnFlagPicture = new System.Windows.Forms.PictureBox();
            this.EurFlagPicture = new System.Windows.Forms.PictureBox();
            this.UsdFlagPicture = new System.Windows.Forms.PictureBox();
            this.ExchangePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlnFlagPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EurFlagPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsdFlagPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ExchangePanel
            // 
            this.ExchangePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExchangePanel.Controls.Add(this.CloseButton);
            this.ExchangePanel.Controls.Add(this.button2);
            this.ExchangePanel.Controls.Add(this.ExchangeLabel);
            this.ExchangePanel.Controls.Add(this.BuyLabel);
            this.ExchangePanel.Controls.Add(this.SellLabel);
            this.ExchangePanel.Location = new System.Drawing.Point(0, -1);
            this.ExchangePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExchangePanel.Name = "ExchangePanel";
            this.ExchangePanel.Size = new System.Drawing.Size(479, 124);
            this.ExchangePanel.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Gold;
            this.button2.Location = new System.Drawing.Point(454, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 35;
            this.button2.Text = "—";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExchangeLabel
            // 
            this.ExchangeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExchangeLabel.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExchangeLabel.ForeColor = System.Drawing.Color.Gold;
            this.ExchangeLabel.Location = new System.Drawing.Point(-3, -2);
            this.ExchangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExchangeLabel.Name = "ExchangeLabel";
            this.ExchangeLabel.Size = new System.Drawing.Size(482, 52);
            this.ExchangeLabel.TabIndex = 1;
            this.ExchangeLabel.Text = "Exchange Rate";
            this.ExchangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExchangeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExchangeLabel_MouseDown);
            this.ExchangeLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ExchangeLabel_MouseMove);
            this.ExchangeLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ExchangeLabel_MouseUp);
            // 
            // BuyLabel
            // 
            this.BuyLabel.AutoSize = true;
            this.BuyLabel.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyLabel.ForeColor = System.Drawing.Color.Gold;
            this.BuyLabel.Location = new System.Drawing.Point(25, 73);
            this.BuyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BuyLabel.Name = "BuyLabel";
            this.BuyLabel.Size = new System.Drawing.Size(84, 51);
            this.BuyLabel.TabIndex = 1;
            this.BuyLabel.Text = "Buy";
            // 
            // SellLabel
            // 
            this.SellLabel.AutoSize = true;
            this.SellLabel.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SellLabel.ForeColor = System.Drawing.Color.Gold;
            this.SellLabel.Location = new System.Drawing.Point(358, 73);
            this.SellLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.UsdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.EurLabel.Location = new System.Drawing.Point(212, 224);
            this.EurLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EurLabel.Name = "EurLabel";
            this.EurLabel.Size = new System.Drawing.Size(63, 35);
            this.EurLabel.TabIndex = 4;
            this.EurLabel.Text = "EUR";
            this.EurLabel.Click += new System.EventHandler(this.EurLabel_Click);
            // 
            // PlnLabel
            // 
            this.PlnLabel.AutoSize = true;
            this.PlnLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlnLabel.Location = new System.Drawing.Point(212, 324);
            this.PlnLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlnLabel.Name = "PlnLabel";
            this.PlnLabel.Size = new System.Drawing.Size(61, 35);
            this.PlnLabel.TabIndex = 5;
            this.PlnLabel.Text = "PLN";
            // 
            // UpdasteButton
            // 
            this.UpdasteButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdasteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdasteButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdasteButton.FlatAppearance.BorderSize = 0;
            this.UpdasteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdasteButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdasteButton.ForeColor = System.Drawing.Color.Gold;
            this.UpdasteButton.Location = new System.Drawing.Point(182, 437);
            this.UpdasteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpdasteButton.Name = "UpdasteButton";
            this.UpdasteButton.Size = new System.Drawing.Size(120, 35);
            this.UpdasteButton.TabIndex = 15;
            this.UpdasteButton.Text = "Update";
            this.UpdasteButton.UseVisualStyleBackColor = false;
            this.UpdasteButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // BuyingButton
            // 
            this.BuyingButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BuyingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyingButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BuyingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyingButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyingButton.ForeColor = System.Drawing.Color.Gold;
            this.BuyingButton.Location = new System.Drawing.Point(34, 478);
            this.BuyingButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuyingButton.Name = "BuyingButton";
            this.BuyingButton.Size = new System.Drawing.Size(120, 35);
            this.BuyingButton.TabIndex = 18;
            this.BuyingButton.Text = "Buying";
            this.BuyingButton.UseVisualStyleBackColor = false;
            this.BuyingButton.Click += new System.EventHandler(this.BuyingButton_Click);
            // 
            // SellButton
            // 
            this.SellButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SellButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SellButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SellButton.ForeColor = System.Drawing.Color.Gold;
            this.SellButton.Location = new System.Drawing.Point(333, 478);
            this.SellButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(120, 35);
            this.SellButton.TabIndex = 19;
            this.SellButton.Text = "Sell";
            this.SellButton.UseVisualStyleBackColor = false;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // UsdBuyLabel
            // 
            this.UsdBuyLabel.AutoSize = true;
            this.UsdBuyLabel.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsdBuyLabel.Location = new System.Drawing.Point(27, 164);
            this.UsdBuyLabel.Name = "UsdBuyLabel";
            this.UsdBuyLabel.Size = new System.Drawing.Size(93, 38);
            this.UsdBuyLabel.TabIndex = 26;
            this.UsdBuyLabel.Text = "27,30";
            // 
            // EurBuyLabel
            // 
            this.EurBuyLabel.AutoSize = true;
            this.EurBuyLabel.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EurBuyLabel.Location = new System.Drawing.Point(27, 264);
            this.EurBuyLabel.Name = "EurBuyLabel";
            this.EurBuyLabel.Size = new System.Drawing.Size(93, 38);
            this.EurBuyLabel.TabIndex = 27;
            this.EurBuyLabel.Text = "31,57";
            // 
            // PlnBuyLabel
            // 
            this.PlnBuyLabel.AutoSize = true;
            this.PlnBuyLabel.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlnBuyLabel.Location = new System.Drawing.Point(27, 364);
            this.PlnBuyLabel.Name = "PlnBuyLabel";
            this.PlnBuyLabel.Size = new System.Drawing.Size(77, 38);
            this.PlnBuyLabel.TabIndex = 28;
            this.PlnBuyLabel.Text = "5,45";
            // 
            // UsdSellLabel
            // 
            this.UsdSellLabel.AutoSize = true;
            this.UsdSellLabel.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsdSellLabel.Location = new System.Drawing.Point(360, 164);
            this.UsdSellLabel.Name = "UsdSellLabel";
            this.UsdSellLabel.Size = new System.Drawing.Size(93, 38);
            this.UsdSellLabel.TabIndex = 29;
            this.UsdSellLabel.Text = "28,60";
            this.UsdSellLabel.Click += new System.EventHandler(this.UsdSellLabel_Click);
            // 
            // EurSellLabel
            // 
            this.EurSellLabel.AutoSize = true;
            this.EurSellLabel.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EurSellLabel.Location = new System.Drawing.Point(360, 264);
            this.EurSellLabel.Name = "EurSellLabel";
            this.EurSellLabel.Size = new System.Drawing.Size(93, 38);
            this.EurSellLabel.TabIndex = 30;
            this.EurSellLabel.Text = "32,90";
            // 
            // PlnSellLabel
            // 
            this.PlnSellLabel.AutoSize = true;
            this.PlnSellLabel.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlnSellLabel.Location = new System.Drawing.Point(360, 364);
            this.PlnSellLabel.Name = "PlnSellLabel";
            this.PlnSellLabel.Size = new System.Drawing.Size(77, 38);
            this.PlnSellLabel.TabIndex = 32;
            this.PlnSellLabel.Text = "6,66";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.ForeColor = System.Drawing.Color.Gold;
            this.SaveButton.Location = new System.Drawing.Point(182, 512);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(120, 35);
            this.SaveButton.TabIndex = 33;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Black;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.Gold;
            this.CloseButton.Location = new System.Drawing.Point(454, 1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 25);
            this.CloseButton.TabIndex = 34;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PlnFlagPicture
            // 
            this.PlnFlagPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlnFlagPicture.Image = global::Exchange.Properties.Resources.NewPlnFlag;
            this.PlnFlagPicture.Location = new System.Drawing.Point(204, 362);
            this.PlnFlagPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PlnFlagPicture.Name = "PlnFlagPicture";
            this.PlnFlagPicture.Size = new System.Drawing.Size(80, 40);
            this.PlnFlagPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlnFlagPicture.TabIndex = 8;
            this.PlnFlagPicture.TabStop = false;
            // 
            // EurFlagPicture
            // 
            this.EurFlagPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EurFlagPicture.Image = global::Exchange.Properties.Resources.eurFlag;
            this.EurFlagPicture.Location = new System.Drawing.Point(204, 262);
            this.EurFlagPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EurFlagPicture.Name = "EurFlagPicture";
            this.EurFlagPicture.Size = new System.Drawing.Size(80, 40);
            this.EurFlagPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EurFlagPicture.TabIndex = 7;
            this.EurFlagPicture.TabStop = false;
            // 
            // UsdFlagPicture
            // 
            this.UsdFlagPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsdFlagPicture.Image = global::Exchange.Properties.Resources.NewUsdFlag;
            this.UsdFlagPicture.Location = new System.Drawing.Point(204, 162);
            this.UsdFlagPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UsdFlagPicture.Name = "UsdFlagPicture";
            this.UsdFlagPicture.Size = new System.Drawing.Size(80, 40);
            this.UsdFlagPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UsdFlagPicture.TabIndex = 6;
            this.UsdFlagPicture.TabStop = false;
            this.UsdFlagPicture.Click += new System.EventHandler(this.UsdFlagPicture_Click);
            // 
            // ExchangeMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(479, 553);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PlnSellLabel);
            this.Controls.Add(this.EurSellLabel);
            this.Controls.Add(this.UsdSellLabel);
            this.Controls.Add(this.PlnBuyLabel);
            this.Controls.Add(this.EurBuyLabel);
            this.Controls.Add(this.UsdBuyLabel);
            this.Controls.Add(this.SellButton);
            this.Controls.Add(this.BuyingButton);
            this.Controls.Add(this.UpdasteButton);
            this.Controls.Add(this.PlnFlagPicture);
            this.Controls.Add(this.EurFlagPicture);
            this.Controls.Add(this.UsdFlagPicture);
            this.Controls.Add(this.PlnLabel);
            this.Controls.Add(this.EurLabel);
            this.Controls.Add(this.UsdLabel);
            this.Controls.Add(this.ExchangePanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ExchangeMainPage";
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
        private System.Windows.Forms.Button BuyingButton;
        private System.Windows.Forms.Button SellButton;
        public System.Windows.Forms.Label UsdBuyLabel;
        public System.Windows.Forms.Label EurBuyLabel;
        public System.Windows.Forms.Label PlnBuyLabel;
        public System.Windows.Forms.Label UsdSellLabel;
        public System.Windows.Forms.Label EurSellLabel;
        public System.Windows.Forms.Label PlnSellLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button button2;
    }
}