namespace Exchange
{
    partial class Sell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sell));
            this.UsdLabel = new System.Windows.Forms.Label();
            this.UahUsdLabel = new System.Windows.Forms.Label();
            this.UsdText = new System.Windows.Forms.TextBox();
            this.UahUsdText = new System.Windows.Forms.TextBox();
            this.CalculateUsdButton = new System.Windows.Forms.Button();
            this.EurLabel = new System.Windows.Forms.Label();
            this.UahEurLabel = new System.Windows.Forms.Label();
            this.PlnLabel = new System.Windows.Forms.Label();
            this.UahPlnLabel = new System.Windows.Forms.Label();
            this.EurText = new System.Windows.Forms.TextBox();
            this.UahEurText = new System.Windows.Forms.TextBox();
            this.PlnText = new System.Windows.Forms.TextBox();
            this.UahPlnText = new System.Windows.Forms.TextBox();
            this.CalculateEurButton = new System.Windows.Forms.Button();
            this.CalculatePlnButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.UsdPicture = new System.Windows.Forms.PictureBox();
            this.EurPicture = new System.Windows.Forms.PictureBox();
            this.PlnPicture = new System.Windows.Forms.PictureBox();
            this.SellingPanel = new System.Windows.Forms.Panel();
            this.SellingLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TurnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsdPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EurPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlnPicture)).BeginInit();
            this.SellingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsdLabel
            // 
            this.UsdLabel.AutoSize = true;
            this.UsdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsdLabel.Location = new System.Drawing.Point(80, 99);
            this.UsdLabel.Name = "UsdLabel";
            this.UsdLabel.Size = new System.Drawing.Size(92, 31);
            this.UsdLabel.TabIndex = 5;
            this.UsdLabel.Text = "USD :";
            // 
            // UahUsdLabel
            // 
            this.UahUsdLabel.AutoSize = true;
            this.UahUsdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UahUsdLabel.Location = new System.Drawing.Point(78, 160);
            this.UahUsdLabel.Name = "UahUsdLabel";
            this.UahUsdLabel.Size = new System.Drawing.Size(92, 31);
            this.UahUsdLabel.TabIndex = 2;
            this.UahUsdLabel.Text = "UAH :";
            // 
            // UsdText
            // 
            this.UsdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsdText.Location = new System.Drawing.Point(195, 103);
            this.UsdText.Name = "UsdText";
            this.UsdText.Size = new System.Drawing.Size(146, 26);
            this.UsdText.TabIndex = 3;
            this.UsdText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsdText_KeyPress);
            // 
            // UahUsdText
            // 
            this.UahUsdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UahUsdText.Location = new System.Drawing.Point(195, 176);
            this.UahUsdText.Name = "UahUsdText";
            this.UahUsdText.Size = new System.Drawing.Size(146, 26);
            this.UahUsdText.TabIndex = 21;
            this.UahUsdText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UahUsdText_KeyPress);
            // 
            // CalculateUsdButton
            // 
            this.CalculateUsdButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CalculateUsdButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculateUsdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateUsdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateUsdButton.ForeColor = System.Drawing.Color.Gold;
            this.CalculateUsdButton.Location = new System.Drawing.Point(351, 132);
            this.CalculateUsdButton.Name = "CalculateUsdButton";
            this.CalculateUsdButton.Size = new System.Drawing.Size(102, 28);
            this.CalculateUsdButton.TabIndex = 17;
            this.CalculateUsdButton.Text = "Calculate";
            this.CalculateUsdButton.UseVisualStyleBackColor = false;
            this.CalculateUsdButton.Click += new System.EventHandler(this.CalculateUsdButton_Click);
            // 
            // EurLabel
            // 
            this.EurLabel.AutoSize = true;
            this.EurLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EurLabel.Location = new System.Drawing.Point(80, 247);
            this.EurLabel.Name = "EurLabel";
            this.EurLabel.Size = new System.Drawing.Size(92, 31);
            this.EurLabel.TabIndex = 10;
            this.EurLabel.Text = "EUR :";
            // 
            // UahEurLabel
            // 
            this.UahEurLabel.AutoSize = true;
            this.UahEurLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UahEurLabel.Location = new System.Drawing.Point(75, 313);
            this.UahEurLabel.Name = "UahEurLabel";
            this.UahEurLabel.Size = new System.Drawing.Size(92, 31);
            this.UahEurLabel.TabIndex = 7;
            this.UahEurLabel.Text = "UAH :";
            // 
            // PlnLabel
            // 
            this.PlnLabel.AutoSize = true;
            this.PlnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlnLabel.Location = new System.Drawing.Point(80, 391);
            this.PlnLabel.Name = "PlnLabel";
            this.PlnLabel.Size = new System.Drawing.Size(87, 31);
            this.PlnLabel.TabIndex = 15;
            this.PlnLabel.Text = "PLN :";
            // 
            // UahPlnLabel
            // 
            this.UahPlnLabel.AutoSize = true;
            this.UahPlnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UahPlnLabel.Location = new System.Drawing.Point(75, 457);
            this.UahPlnLabel.Name = "UahPlnLabel";
            this.UahPlnLabel.Size = new System.Drawing.Size(92, 31);
            this.UahPlnLabel.TabIndex = 12;
            this.UahPlnLabel.Text = "UAH :";
            // 
            // EurText
            // 
            this.EurText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EurText.Location = new System.Drawing.Point(195, 251);
            this.EurText.Name = "EurText";
            this.EurText.Size = new System.Drawing.Size(146, 26);
            this.EurText.TabIndex = 8;
            this.EurText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EurText_KeyPress);
            // 
            // UahEurText
            // 
            this.UahEurText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UahEurText.Location = new System.Drawing.Point(195, 324);
            this.UahEurText.Name = "UahEurText";
            this.UahEurText.Size = new System.Drawing.Size(146, 26);
            this.UahEurText.TabIndex = 9;
            this.UahEurText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UahEurText_KeyPress);
            // 
            // PlnText
            // 
            this.PlnText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlnText.Location = new System.Drawing.Point(195, 395);
            this.PlnText.Name = "PlnText";
            this.PlnText.Size = new System.Drawing.Size(146, 26);
            this.PlnText.TabIndex = 13;
            this.PlnText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlnText_KeyPress);
            // 
            // UahPlnText
            // 
            this.UahPlnText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UahPlnText.Location = new System.Drawing.Point(195, 468);
            this.UahPlnText.Name = "UahPlnText";
            this.UahPlnText.Size = new System.Drawing.Size(146, 26);
            this.UahPlnText.TabIndex = 14;
            this.UahPlnText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UahPlnText_KeyPress);
            // 
            // CalculateEurButton
            // 
            this.CalculateEurButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CalculateEurButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculateEurButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateEurButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateEurButton.ForeColor = System.Drawing.Color.Gold;
            this.CalculateEurButton.Location = new System.Drawing.Point(351, 282);
            this.CalculateEurButton.Name = "CalculateEurButton";
            this.CalculateEurButton.Size = new System.Drawing.Size(102, 28);
            this.CalculateEurButton.TabIndex = 18;
            this.CalculateEurButton.Text = "Calculate";
            this.CalculateEurButton.UseVisualStyleBackColor = false;
            this.CalculateEurButton.Click += new System.EventHandler(this.CalculateEurButton_Click);
            // 
            // CalculatePlnButton
            // 
            this.CalculatePlnButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CalculatePlnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculatePlnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculatePlnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculatePlnButton.ForeColor = System.Drawing.Color.Gold;
            this.CalculatePlnButton.Location = new System.Drawing.Point(351, 431);
            this.CalculatePlnButton.Name = "CalculatePlnButton";
            this.CalculatePlnButton.Size = new System.Drawing.Size(99, 28);
            this.CalculatePlnButton.TabIndex = 19;
            this.CalculatePlnButton.Text = "Calculate";
            this.CalculatePlnButton.UseVisualStyleBackColor = false;
            this.CalculatePlnButton.Click += new System.EventHandler(this.CalculatePlnButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.Color.Gold;
            this.BackButton.Location = new System.Drawing.Point(351, 499);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(102, 28);
            this.BackButton.TabIndex = 20;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
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
            // SellingPanel
            // 
            this.SellingPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SellingPanel.Controls.Add(this.SellingLabel);
            this.SellingPanel.Location = new System.Drawing.Point(-4, 24);
            this.SellingPanel.Name = "SellingPanel";
            this.SellingPanel.Size = new System.Drawing.Size(483, 52);
            this.SellingPanel.TabIndex = 0;
            // 
            // SellingLabel
            // 
            this.SellingLabel.AutoSize = true;
            this.SellingLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SellingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SellingLabel.ForeColor = System.Drawing.Color.Gold;
            this.SellingLabel.Location = new System.Drawing.Point(165, 0);
            this.SellingLabel.Name = "SellingLabel";
            this.SellingLabel.Size = new System.Drawing.Size(141, 44);
            this.SellingLabel.TabIndex = 0;
            this.SellingLabel.Text = "Selling";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(457, -1);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(22, 22);
            this.ExitButton.TabIndex = 22;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TurnButton
            // 
            this.TurnButton.Location = new System.Drawing.Point(425, -1);
            this.TurnButton.Name = "TurnButton";
            this.TurnButton.Size = new System.Drawing.Size(28, 23);
            this.TurnButton.TabIndex = 23;
            this.TurnButton.Text = "-";
            this.TurnButton.UseVisualStyleBackColor = true;
            this.TurnButton.Click += new System.EventHandler(this.TurnButton_Click);
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(478, 546);
            this.Controls.Add(this.TurnButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SellingPanel);
            this.Controls.Add(this.PlnPicture);
            this.Controls.Add(this.EurPicture);
            this.Controls.Add(this.UsdPicture);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CalculatePlnButton);
            this.Controls.Add(this.CalculateEurButton);
            this.Controls.Add(this.UahPlnText);
            this.Controls.Add(this.PlnText);
            this.Controls.Add(this.UahEurText);
            this.Controls.Add(this.EurText);
            this.Controls.Add(this.UahPlnLabel);
            this.Controls.Add(this.PlnLabel);
            this.Controls.Add(this.UahEurLabel);
            this.Controls.Add(this.EurLabel);
            this.Controls.Add(this.CalculateUsdButton);
            this.Controls.Add(this.UahUsdText);
            this.Controls.Add(this.UsdText);
            this.Controls.Add(this.UahUsdLabel);
            this.Controls.Add(this.UsdLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sell";
            this.Text = "Selling";
            ((System.ComponentModel.ISupportInitialize)(this.UsdPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EurPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlnPicture)).EndInit();
            this.SellingPanel.ResumeLayout(false);
            this.SellingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UsdPicture;
        private System.Windows.Forms.PictureBox EurPicture;
        private System.Windows.Forms.PictureBox PlnPicture;
        private System.Windows.Forms.Label UsdLabel;
        private System.Windows.Forms.Label UahUsdLabel;
        private System.Windows.Forms.Label EurLabel;
        private System.Windows.Forms.Label UahEurLabel;
        private System.Windows.Forms.Label PlnLabel;
        private System.Windows.Forms.Label UahPlnLabel;
        private System.Windows.Forms.TextBox UsdText;
        private System.Windows.Forms.TextBox UahUsdText;
        private System.Windows.Forms.TextBox EurText;
        private System.Windows.Forms.TextBox UahEurText;
        private System.Windows.Forms.TextBox PlnText;
        private System.Windows.Forms.TextBox UahPlnText;
        private System.Windows.Forms.Button CalculateUsdButton;
        private System.Windows.Forms.Button CalculateEurButton;
        private System.Windows.Forms.Button CalculatePlnButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel SellingPanel;
        private System.Windows.Forms.Label SellingLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button TurnButton;
    }
}