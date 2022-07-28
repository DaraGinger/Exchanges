namespace Exchange.LogData
{
    partial class Registration
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
            this.SignUpButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.RepeatPasswordLabel = new System.Windows.Forms.Label();
            this.RepeatPasswordField = new System.Windows.Forms.TextBox();
            this.FormName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.SystemColors.Window;
            this.SignUpButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignUpButton.Location = new System.Drawing.Point(115, 365);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(231, 32);
            this.SignUpButton.TabIndex = 9;
            this.SignUpButton.Text = "Sign up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.PasswordLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(115, 204);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(231, 22);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginLabel
            // 
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(115, 134);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(231, 22);
            this.LoginLabel.TabIndex = 7;
            this.LoginLabel.Text = "Login";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordField.Location = new System.Drawing.Point(115, 229);
            this.PasswordField.Multiline = true;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(231, 32);
            this.PasswordField.TabIndex = 6;
            this.PasswordField.TextChanged += new System.EventHandler(this.PasswordField_TextChanged);
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(115, 159);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(231, 32);
            this.LoginField.TabIndex = 5;
            this.LoginField.TextChanged += new System.EventHandler(this.LoginField_TextChanged);
            // 
            // RepeatPasswordLabel
            // 
            this.RepeatPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.RepeatPasswordLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.RepeatPasswordLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepeatPasswordLabel.Location = new System.Drawing.Point(115, 277);
            this.RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            this.RepeatPasswordLabel.Size = new System.Drawing.Size(231, 22);
            this.RepeatPasswordLabel.TabIndex = 11;
            this.RepeatPasswordLabel.Text = "Repeat password";
            this.RepeatPasswordLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RepeatPasswordField
            // 
            this.RepeatPasswordField.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepeatPasswordField.Location = new System.Drawing.Point(115, 302);
            this.RepeatPasswordField.Multiline = true;
            this.RepeatPasswordField.Name = "RepeatPasswordField";
            this.RepeatPasswordField.Size = new System.Drawing.Size(231, 32);
            this.RepeatPasswordField.TabIndex = 10;
            this.RepeatPasswordField.TextChanged += new System.EventHandler(this.RepeatPasswordField_Click);
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
            this.FormName.TabIndex = 12;
            this.FormName.Text = "Registration";
            this.FormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Exchange.Properties.Resources.WoodWorkplace;
            this.ClientSize = new System.Drawing.Size(462, 507);
            this.Controls.Add(this.FormName);
            this.Controls.Add(this.RepeatPasswordLabel);
            this.Controls.Add(this.RepeatPasswordField);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.LoginField);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.Label RepeatPasswordLabel;
        private System.Windows.Forms.TextBox RepeatPasswordField;
        private System.Windows.Forms.Label FormName;
    }
}