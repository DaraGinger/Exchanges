namespace Exchange
{
    partial class Buy
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
            this.BuyPanel = new System.Windows.Forms.Panel();
            this.BuyingLabel = new System.Windows.Forms.Label();
            this.UahUsdLabel = new System.Windows.Forms.Label();
            this.UsdBuyingText = new System.Windows.Forms.TextBox();
            this.UahUsdBuyingText = new System.Windows.Forms.TextBox();
            this.UsdBuyingLabel = new System.Windows.Forms.Label();
            this.UsdPicture = new System.Windows.Forms.PictureBox();
            this.EurPicture = new System.Windows.Forms.PictureBox();
            this.EurBuyingLabel = new System.Windows.Forms.Label();
            this.UahEurBuyingText = new System.Windows.Forms.TextBox();
            this.EurBuyingText = new System.Windows.Forms.TextBox();
            this.UahEurLabel = new System.Windows.Forms.Label();
            this.PlnPicture = new System.Windows.Forms.PictureBox();
            this.PlnBuyingLabel = new System.Windows.Forms.Label();
            this.UahPlnBuyingText = new System.Windows.Forms.TextBox();
            this.PlnBuyingText = new System.Windows.Forms.TextBox();
            this.UahPlnLabel = new System.Windows.Forms.Label();
            this.CalculateUsdButton = new System.Windows.Forms.Button();
            this.CalculateEurButton = new System.Windows.Forms.Button();
            this.CalculatePlnButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BuyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsdPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EurPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlnPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BuyPanel
            // 
            this.BuyPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BuyPanel.Controls.Add(this.BuyingLabel);
            this.BuyPanel.Location = new System.Drawing.Point(-4, 24);
            this.BuyPanel.Name = "BuyPanel";
            this.BuyPanel.Size = new System.Drawing.Size(468, 52);
            this.BuyPanel.TabIndex = 0;
            // 
            // BuyingLabel
            // 
            this.BuyingLabel.AutoSize = true;
            this.BuyingLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BuyingLabel.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyingLabel.ForeColor = System.Drawing.Color.Gold;
            this.BuyingLabel.Location = new System.Drawing.Point(165, 0);
            this.BuyingLabel.Name = "BuyingLabel";
            this.BuyingLabel.Size = new System.Drawing.Size(139, 45);
            this.BuyingLabel.TabIndex = 0;
            this.BuyingLabel.Text = "Buying";
            // 
            // UahUsdLabel
            // 
            this.UahUsdLabel.AutoSize = true;
            this.UahUsdLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UahUsdLabel.Location = new System.Drawing.Point(75, 165);
            this.UahUsdLabel.Name = "UahUsdLabel";
            this.UahUsdLabel.Size = new System.Drawing.Size(90, 31);
            this.UahUsdLabel.TabIndex = 2;
            this.UahUsdLabel.Text = "UAH :";
            // 
            // UsdBuyingText
            // 
            this.UsdBuyingText.Location = new System.Drawing.Point(195, 103);
            this.UsdBuyingText.Name = "UsdBuyingText";
            this.UsdBuyingText.Size = new System.Drawing.Size(146, 20);
            this.UsdBuyingText.TabIndex = 3;
            this.UsdBuyingText.TextChanged += new System.EventHandler(this.UsdBuyingText_TextChanged);
            // 
            // UahUsdBuyingText
            // 
            this.UahUsdBuyingText.Location = new System.Drawing.Point(195, 176);
            this.UahUsdBuyingText.Name = "UahUsdBuyingText";
            this.UahUsdBuyingText.Size = new System.Drawing.Size(146, 20);
            this.UahUsdBuyingText.TabIndex = 4;
            // 
            // UsdBuyingLabel
            // 
            this.UsdBuyingLabel.AutoSize = true;
            this.UsdBuyingLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsdBuyingLabel.Location = new System.Drawing.Point(80, 99);
            this.UsdBuyingLabel.Name = "UsdBuyingLabel";
            this.UsdBuyingLabel.Size = new System.Drawing.Size(85, 31);
            this.UsdBuyingLabel.TabIndex = 5;
            this.UsdBuyingLabel.Text = "USD :";
            // 
            // UsdPicture
            // 
            this.UsdPicture.Image = global::Exchange.Properties.Resources.usdFlag;
            this.UsdPicture.Location = new System.Drawing.Point(28, 99);
            this.UsdPicture.Name = "UsdPicture";
            this.UsdPicture.Size = new System.Drawing.Size(46, 27);
            this.UsdPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UsdPicture.TabIndex = 6;
            this.UsdPicture.TabStop = false;
            // 
            // EurPicture
            // 
            this.EurPicture.Image = global::Exchange.Properties.Resources.eurFlag;
            this.EurPicture.Location = new System.Drawing.Point(28, 247);
            this.EurPicture.Name = "EurPicture";
            this.EurPicture.Size = new System.Drawing.Size(46, 27);
            this.EurPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EurPicture.TabIndex = 11;
            this.EurPicture.TabStop = false;
            // 
            // EurBuyingLabel
            // 
            this.EurBuyingLabel.AutoSize = true;
            this.EurBuyingLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EurBuyingLabel.Location = new System.Drawing.Point(80, 247);
            this.EurBuyingLabel.Name = "EurBuyingLabel";
            this.EurBuyingLabel.Size = new System.Drawing.Size(88, 31);
            this.EurBuyingLabel.TabIndex = 10;
            this.EurBuyingLabel.Text = "EUR :";
            // 
            // UahEurBuyingText
            // 
            this.UahEurBuyingText.Location = new System.Drawing.Point(195, 324);
            this.UahEurBuyingText.Name = "UahEurBuyingText";
            this.UahEurBuyingText.Size = new System.Drawing.Size(146, 20);
            this.UahEurBuyingText.TabIndex = 9;
            // 
            // EurBuyingText
            // 
            this.EurBuyingText.Location = new System.Drawing.Point(195, 251);
            this.EurBuyingText.Name = "EurBuyingText";
            this.EurBuyingText.Size = new System.Drawing.Size(146, 20);
            this.EurBuyingText.TabIndex = 8;
            // 
            // UahEurLabel
            // 
            this.UahEurLabel.AutoSize = true;
            this.UahEurLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UahEurLabel.Location = new System.Drawing.Point(75, 313);
            this.UahEurLabel.Name = "UahEurLabel";
            this.UahEurLabel.Size = new System.Drawing.Size(90, 31);
            this.UahEurLabel.TabIndex = 7;
            this.UahEurLabel.Text = "UAH :";
            // 
            // PlnPicture
            // 
            this.PlnPicture.Image = global::Exchange.Properties.Resources.plnFlag;
            this.PlnPicture.Location = new System.Drawing.Point(28, 391);
            this.PlnPicture.Name = "PlnPicture";
            this.PlnPicture.Size = new System.Drawing.Size(46, 27);
            this.PlnPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlnPicture.TabIndex = 16;
            this.PlnPicture.TabStop = false;
            // 
            // PlnBuyingLabel
            // 
            this.PlnBuyingLabel.AutoSize = true;
            this.PlnBuyingLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlnBuyingLabel.Location = new System.Drawing.Point(80, 391);
            this.PlnBuyingLabel.Name = "PlnBuyingLabel";
            this.PlnBuyingLabel.Size = new System.Drawing.Size(85, 31);
            this.PlnBuyingLabel.TabIndex = 15;
            this.PlnBuyingLabel.Text = "PLN :";
            // 
            // UahPlnBuyingText
            // 
            this.UahPlnBuyingText.Location = new System.Drawing.Point(195, 468);
            this.UahPlnBuyingText.Name = "UahPlnBuyingText";
            this.UahPlnBuyingText.Size = new System.Drawing.Size(146, 20);
            this.UahPlnBuyingText.TabIndex = 14;
            // 
            // PlnBuyingText
            // 
            this.PlnBuyingText.Location = new System.Drawing.Point(195, 395);
            this.PlnBuyingText.Name = "PlnBuyingText";
            this.PlnBuyingText.Size = new System.Drawing.Size(146, 20);
            this.PlnBuyingText.TabIndex = 13;
            // 
            // UahPlnLabel
            // 
            this.UahPlnLabel.AutoSize = true;
            this.UahPlnLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UahPlnLabel.Location = new System.Drawing.Point(75, 457);
            this.UahPlnLabel.Name = "UahPlnLabel";
            this.UahPlnLabel.Size = new System.Drawing.Size(90, 31);
            this.UahPlnLabel.TabIndex = 12;
            this.UahPlnLabel.Text = "UAH :";
            // 
            // CalculateUsdButton
            // 
            this.CalculateUsdButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CalculateUsdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateUsdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateUsdButton.ForeColor = System.Drawing.Color.Gold;
            this.CalculateUsdButton.Location = new System.Drawing.Point(362, 132);
            this.CalculateUsdButton.Name = "CalculateUsdButton";
            this.CalculateUsdButton.Size = new System.Drawing.Size(91, 28);
            this.CalculateUsdButton.TabIndex = 17;
            this.CalculateUsdButton.Text = "Calculate";
            this.CalculateUsdButton.UseVisualStyleBackColor = false;
            this.CalculateUsdButton.Click += new System.EventHandler(this.CalculateUsdButton_Click);
            // 
            // CalculateEurButton
            // 
            this.CalculateEurButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CalculateEurButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateEurButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateEurButton.ForeColor = System.Drawing.Color.Gold;
            this.CalculateEurButton.Location = new System.Drawing.Point(362, 282);
            this.CalculateEurButton.Name = "CalculateEurButton";
            this.CalculateEurButton.Size = new System.Drawing.Size(91, 28);
            this.CalculateEurButton.TabIndex = 18;
            this.CalculateEurButton.Text = "Calculate";
            this.CalculateEurButton.UseVisualStyleBackColor = false;
            this.CalculateEurButton.Click += new System.EventHandler(this.CalculateEurButton_Click);
            // 
            // CalculatePlnButton
            // 
            this.CalculatePlnButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CalculatePlnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculatePlnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculatePlnButton.ForeColor = System.Drawing.Color.Gold;
            this.CalculatePlnButton.Location = new System.Drawing.Point(362, 426);
            this.CalculatePlnButton.Name = "CalculatePlnButton";
            this.CalculatePlnButton.Size = new System.Drawing.Size(91, 28);
            this.CalculatePlnButton.TabIndex = 19;
            this.CalculatePlnButton.Text = "Calculate";
            this.CalculatePlnButton.UseVisualStyleBackColor = false;
            this.CalculatePlnButton.Click += new System.EventHandler(this.CalculatePlnButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(462, 533);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CalculatePlnButton);
            this.Controls.Add(this.CalculateEurButton);
            this.Controls.Add(this.CalculateUsdButton);
            this.Controls.Add(this.PlnPicture);
            this.Controls.Add(this.PlnBuyingLabel);
            this.Controls.Add(this.UahPlnBuyingText);
            this.Controls.Add(this.PlnBuyingText);
            this.Controls.Add(this.UahPlnLabel);
            this.Controls.Add(this.EurPicture);
            this.Controls.Add(this.EurBuyingLabel);
            this.Controls.Add(this.UahEurBuyingText);
            this.Controls.Add(this.EurBuyingText);
            this.Controls.Add(this.UahEurLabel);
            this.Controls.Add(this.UsdPicture);
            this.Controls.Add(this.UsdBuyingLabel);
            this.Controls.Add(this.UahUsdBuyingText);
            this.Controls.Add(this.UsdBuyingText);
            this.Controls.Add(this.UahUsdLabel);
            this.Controls.Add(this.BuyPanel);
            this.Location = new System.Drawing.Point(-4, 24);
            this.Name = "Buy";
            this.Text = "Calculate";
            this.BuyPanel.ResumeLayout(false);
            this.BuyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsdPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EurPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlnPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BuyPanel;
        private System.Windows.Forms.Label BuyingLabel;
        private System.Windows.Forms.Label UahUsdLabel;
        private System.Windows.Forms.TextBox UsdBuyingText;
        private System.Windows.Forms.TextBox UahUsdBuyingText;
        private System.Windows.Forms.Label UsdBuyingLabel;
        private System.Windows.Forms.PictureBox UsdPicture;
        private System.Windows.Forms.PictureBox EurPicture;
        private System.Windows.Forms.Label EurBuyingLabel;
        private System.Windows.Forms.TextBox UahEurBuyingText;
        private System.Windows.Forms.TextBox EurBuyingText;
        private System.Windows.Forms.Label UahEurLabel;
        private System.Windows.Forms.PictureBox PlnPicture;
        private System.Windows.Forms.Label PlnBuyingLabel;
        private System.Windows.Forms.TextBox UahPlnBuyingText;
        private System.Windows.Forms.TextBox PlnBuyingText;
        private System.Windows.Forms.Label UahPlnLabel;
        private System.Windows.Forms.Button CalculateUsdButton;
        private System.Windows.Forms.Button CalculateEurButton;
        private System.Windows.Forms.Button CalculatePlnButton;
        private System.Windows.Forms.Button button1;
    }
}