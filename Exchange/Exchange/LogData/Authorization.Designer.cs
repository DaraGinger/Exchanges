﻿namespace Exchange.LogData
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.LoginField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.FormName = new System.Windows.Forms.Label();
            this.ResetPasswordLabelLink = new System.Windows.Forms.LinkLabel();
            this.ComeBackButton = new System.Windows.Forms.Button();
            this.TurnButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(115, 159);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(231, 29);
            this.LoginField.TabIndex = 0;
            this.LoginField.TextChanged += new System.EventHandler(this.LoginField_TextChanged);
            this.LoginField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginField_KeyPress);
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordField.Location = new System.Drawing.Point(115, 229);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(231, 29);
            this.PasswordField.TabIndex = 1;
            this.PasswordField.TextChanged += new System.EventHandler(this.PasswordField_TextChanged);
            this.PasswordField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordField_KeyPress);
            // 
            // LoginLabel
            // 
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(115, 131);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(231, 25);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Login";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.PasswordLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(114, 201);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(231, 25);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.Color.White;
            this.SignInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInButton.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInButton.Location = new System.Drawing.Point(115, 299);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(231, 32);
            this.SignInButton.TabIndex = 4;
            this.SignInButton.Text = "Sign in";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // FormName
            // 
            this.FormName.BackColor = System.Drawing.Color.White;
            this.FormName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FormName.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormName.Location = new System.Drawing.Point(0, -1);
            this.FormName.Name = "FormName";
            this.FormName.Size = new System.Drawing.Size(462, 50);
            this.FormName.TabIndex = 5;
            this.FormName.Text = "Authorization";
            this.FormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FormName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormName_MouseDown);
            this.FormName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormName_MouseMove);
            this.FormName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormName_MouseUp);
            // 
            // ResetPasswordLabelLink
            // 
            this.ResetPasswordLabelLink.ActiveLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.ResetPasswordLabelLink.BackColor = System.Drawing.Color.Transparent;
            this.ResetPasswordLabelLink.Cursor = System.Windows.Forms.Cursors.Help;
            this.ResetPasswordLabelLink.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.ResetPasswordLabelLink.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetPasswordLabelLink.LinkColor = System.Drawing.Color.White;
            this.ResetPasswordLabelLink.Location = new System.Drawing.Point(115, 264);
            this.ResetPasswordLabelLink.Name = "ResetPasswordLabelLink";
            this.ResetPasswordLabelLink.Size = new System.Drawing.Size(231, 23);
            this.ResetPasswordLabelLink.TabIndex = 6;
            this.ResetPasswordLabelLink.TabStop = true;
            this.ResetPasswordLabelLink.Text = "Forgot your password?";
            this.ResetPasswordLabelLink.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ResetPasswordLabelLink.VisitedLinkColor = System.Drawing.Color.White;
            this.ResetPasswordLabelLink.Click += new System.EventHandler(this.ResetPasswordLabelLink_Click);
            // 
            // ComeBackButton
            // 
            this.ComeBackButton.BackColor = System.Drawing.Color.White;
            this.ComeBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComeBackButton.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComeBackButton.Location = new System.Drawing.Point(115, 369);
            this.ComeBackButton.Name = "ComeBackButton";
            this.ComeBackButton.Size = new System.Drawing.Size(231, 32);
            this.ComeBackButton.TabIndex = 7;
            this.ComeBackButton.Text = "Come Back";
            this.ComeBackButton.UseVisualStyleBackColor = false;
            this.ComeBackButton.Click += new System.EventHandler(this.ComeBackButton_Click);
            // 
            // TurnButton
            // 
            this.TurnButton.BackColor = System.Drawing.Color.White;
            this.TurnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TurnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TurnButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TurnButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TurnButton.Location = new System.Drawing.Point(437, 24);
            this.TurnButton.Name = "TurnButton";
            this.TurnButton.Size = new System.Drawing.Size(25, 25);
            this.TurnButton.TabIndex = 19;
            this.TurnButton.Text = "—";
            this.TurnButton.UseVisualStyleBackColor = false;
            this.TurnButton.Click += new System.EventHandler(this.TurnButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.White;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(437, -1);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(25, 25);
            this.ExitButton.TabIndex = 18;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Exchange.Properties.Resources.WoodWorkplace;
            this.ClientSize = new System.Drawing.Size(462, 507);
            this.Controls.Add(this.TurnButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ComeBackButton);
            this.Controls.Add(this.ResetPasswordLabelLink);
            this.Controls.Add(this.FormName);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.LoginField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Label FormName;
        private System.Windows.Forms.LinkLabel ResetPasswordLabelLink;
        private System.Windows.Forms.Button ComeBackButton;
        private System.Windows.Forms.Button TurnButton;
        private System.Windows.Forms.Button ExitButton;
    }
}