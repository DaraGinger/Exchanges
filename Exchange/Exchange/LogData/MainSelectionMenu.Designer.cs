namespace Exchange.LogData
{
    partial class MainSelectionMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSelectionMenu));
            this.FormName = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.RegistrationLabel = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.turnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FormName
            // 
            this.FormName.BackColor = System.Drawing.Color.White;
            this.FormName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FormName.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormName.Location = new System.Drawing.Point(0, -1);
            this.FormName.Name = "FormName";
            this.FormName.Size = new System.Drawing.Size(462, 50);
            this.FormName.TabIndex = 6;
            this.FormName.Text = "Main Selection Menu";
            this.FormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginLabel
            // 
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(88, 143);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(293, 50);
            this.LoginLabel.TabIndex = 12;
            this.LoginLabel.Text = "Already have an account?\r\n";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegistrationLabel.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationLabel.Location = new System.Drawing.Point(88, 263);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(293, 50);
            this.RegistrationLabel.TabIndex = 13;
            this.RegistrationLabel.Text = "Don\'t have an account?";
            this.RegistrationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.SystemColors.Window;
            this.SignInButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInButton.Location = new System.Drawing.Point(115, 196);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(231, 32);
            this.SignInButton.TabIndex = 14;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.SystemColors.Window;
            this.SignUpButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignUpButton.Location = new System.Drawing.Point(115, 316);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(231, 32);
            this.SignUpButton.TabIndex = 15;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(438, -1);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(24, 23);
            this.ExitButton.TabIndex = 16;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // turnButton
            // 
            this.turnButton.Location = new System.Drawing.Point(438, 28);
            this.turnButton.Name = "turnButton";
            this.turnButton.Size = new System.Drawing.Size(28, 23);
            this.turnButton.TabIndex = 17;
            this.turnButton.Text = "-";
            this.turnButton.UseVisualStyleBackColor = true;
            this.turnButton.Click += new System.EventHandler(this.turnButton_Click);
            // 
            // MainSelectionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Exchange.Properties.Resources.WoodWorkplace;
            this.ClientSize = new System.Drawing.Size(462, 507);
            this.Controls.Add(this.turnButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.RegistrationLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.FormName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainSelectionMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Selection Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FormName;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label RegistrationLabel;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button turnButton;
    }
}