namespace Exchange.LogData
{
    using System;
    using System.Windows.Forms;
    using System.IO;
    using System.Drawing;

    public partial class Registration : Form
    {   
        private string path = Application.StartupPath + @"\Logs\MyLogs.txt";
        private bool pressingTheLeftMouseButton = false;
        private Point mouseLocation;
        public Registration()
        {
            InitializeComponent();
        }

        private void LoginField_TextChanged(object sender, EventArgs e)
        {
            this.LoginField.MaxLength = 16;
        }

        private void PasswordField_TextChanged(object sender, EventArgs e)
        {
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.MaxLength = 16;
        }

        private void RepeatPasswordField_Click(object sender, EventArgs e)
        {
            this.RepeatPasswordField.PasswordChar = '*';
            this.RepeatPasswordField.MaxLength = 16;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (this.LoginField.Text.Length > 0 && this.PasswordField.Text.Length > 0 &&
                this.PasswordField.Text == this.RepeatPasswordField.Text)
            {
                using (StreamWriter sw = File.AppendText(this.path))
                {
                    sw.WriteLine(this.LoginField.Text);
                    sw.WriteLine(this.PasswordField.Text);
                }

                Authorization authorization = new Authorization();
                this.Close();
                authorization.StartPosition = FormStartPosition.Manual;
                authorization.Location = this.Location;
                authorization.Size = this.Size;
                authorization.Show();
            }
            else
            {
                MessageBox.Show("ERROR! Pls try again!");
            }
        }

        private void ComeBackButton_Click(object sender, EventArgs e)
        {
            MainSelectionMenu mainSelectionMenu = (MainSelectionMenu)Application.OpenForms[0];
            this.Close();
            mainSelectionMenu.StartPosition = FormStartPosition.Manual;
            mainSelectionMenu.Location = this.Location;
            mainSelectionMenu.Size = this.Size;
            mainSelectionMenu.Show();

        }

        private void LoginField_KeyPress(object sender, KeyPressEventArgs key)
        {
            char validate = key.KeyChar;

            if (Char.IsControl(validate))
            {
                if (validate == (char)Keys.Enter)
                {
                    PasswordField.Focus();
                }
            }
        }

        private void PasswordField_KeyPress(object sender, KeyPressEventArgs key)
        {
            char validate = key.KeyChar;

            if (Char.IsControl(validate))
            {
                if (validate == (char)Keys.Enter)
                {
                    RepeatPasswordField.Focus();
                }
            }
        }

        private void RepeatPasswordField_KeyPress(object sender, KeyPressEventArgs key)
        {
            char validate = key.KeyChar;

            if (Char.IsControl(validate))
            {
                if (validate == (char)Keys.Enter)
                {
                    SignUpButton.Focus();
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TurnButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormName_MouseDown(object sender, MouseEventArgs e)
        {
            int xMouseLocationOnScreen;
            int yMouseLocationOnScreen;

            if (e.Button == MouseButtons.Left)
            {
                xMouseLocationOnScreen = -e.X;
                yMouseLocationOnScreen = -e.Y;
                this.mouseLocation = new Point(xMouseLocationOnScreen, yMouseLocationOnScreen);
                this.pressingTheLeftMouseButton = true;
            }
        }

        private void FormName_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.pressingTheLeftMouseButton)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(this.mouseLocation.X, this.mouseLocation.Y);
                this.Location = mousePos;
            }
        }

        private void FormName_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.pressingTheLeftMouseButton = false;
            }
        }
    }
}
