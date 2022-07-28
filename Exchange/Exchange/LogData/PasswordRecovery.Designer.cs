namespace Exchange.LogData
{
    partial class PasswordRecovery
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
            this.FormName = new System.Windows.Forms.Label();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordField = new System.Windows.Forms.TextBox();
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
            this.FormName.Text = "Password Recovery";
            this.FormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.BackColor = System.Drawing.Color.White;
            this.ChangePasswordButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePasswordButton.Location = new System.Drawing.Point(115, 299);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(231, 32);
            this.ChangePasswordButton.TabIndex = 11;
            this.ChangePasswordButton.Text = "Change password";
            this.ChangePasswordButton.UseVisualStyleBackColor = false;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(115, 134);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(231, 23);
            this.LoginLabel.TabIndex = 9;
            this.LoginLabel.Text = "Login";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(115, 159);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(231, 32);
            this.LoginField.TabIndex = 7;
            this.LoginField.TextChanged += new System.EventHandler(this.LoginField_TextChanged);
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewPasswordLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.NewPasswordLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPasswordLabel.Location = new System.Drawing.Point(115, 204);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(227, 24);
            this.NewPasswordLabel.TabIndex = 13;
            this.NewPasswordLabel.Text = "New password";
            this.NewPasswordLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NewPasswordField
            // 
            this.NewPasswordField.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPasswordField.Location = new System.Drawing.Point(115, 229);
            this.NewPasswordField.Multiline = true;
            this.NewPasswordField.Name = "NewPasswordField";
            this.NewPasswordField.Size = new System.Drawing.Size(231, 32);
            this.NewPasswordField.TabIndex = 12;
            this.NewPasswordField.TextChanged += new System.EventHandler(this.NewPasswordField_TextChanged);
            // 
            // PasswordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Exchange.Properties.Resources.WoodWorkplace;
            this.ClientSize = new System.Drawing.Size(462, 507);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.NewPasswordField);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.FormName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PasswordRecovery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Recovery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormName;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.TextBox NewPasswordField;
    }
}