namespace Exchange.LogData
{
    using System.IO;
    using System.Windows.Forms;
    using System;
    using System.Drawing;

    public partial class PasswordRecovery : Form
    {
        private string path = Application.StartupPath + @"\Logs\MyLogs.txt";
        private bool pressingTheLeftMouseButton = false;
        private Point mouseLocation;

        public PasswordRecovery()
        {
            InitializeComponent();
        }

        private void LoginField_TextChanged(object sender, EventArgs e)
        {
            this.LoginField.MaxLength = 16;
        }

        private void NewPasswordField_TextChanged(object sender, EventArgs e)
        {
            this.NewPasswordField.PasswordChar = '*';
            this.NewPasswordField.MaxLength = 16;
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            if (this.LoginField.Text.Length > 0 && this.NewPasswordField.Text.Length > 0)
            {
                PasswordResetVerification();
            }
            else if (this.LoginField.Text.Length <= 0 && this.NewPasswordField.Text.Length <= 0)
            {
                MessageBox.Show("Empty login and password fields!");
            }
            else if (this.LoginField.Text.Length <= 0)
            {
                MessageBox.Show("Empty login field!");
            }
            else
            {
                MessageBox.Show("Please, input new password!");
            }
        }

        private void ComeBackButton_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            this.Close();
            authorization.StartPosition = FormStartPosition.Manual;
            authorization.Location = this.Location;
            authorization.Size = this.Size;
            authorization.Show();

        }

        private void PasswordResetVerification()
        {
            if (File.Exists(this.path))
            {
                string[] readData = File.ReadAllLines(this.path);
                string[] loginData = new string[readData.Length];
                string[] passwordData = new string[readData.Length];
                int countLoginArray = 0;
                int countPasswordArray = 0;
                int correctCount = 0;

                for (int i = 0; i < readData.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        loginData[countLoginArray] = readData[i];
                        countLoginArray++;
                    }
                    else
                    {
                        passwordData[countPasswordArray] = readData[i];
                        countPasswordArray++;
                    }
                }

                for (int i = 0; i < loginData.Length; i++)
                {
                    if (this.LoginField.Text == loginData[i])
                    {
                        correctCount++;
                        readData[(i * 2) + 1] = this.NewPasswordField.Text;

                        File.WriteAllText(this.path, String.Empty);

                        for (int q = 0; q < readData.Length; q++)
                        {
                            using (StreamWriter sw = File.AppendText(this.path))
                            {
                                if (q % 2 == 0)
                                {
                                    sw.WriteLine(readData[q]);
                                }
                                else
                                {
                                    sw.WriteLine(readData[q]);
                                }
                            }
                        }

                        MessageBox.Show($"For login[{this.LoginField.Text}], the password has been successfully changed!");
                        break;
                    }
                }

                if (correctCount == 1 && this.NewPasswordField.Text.Length > 0)
                {
                    Authorization authorization = (Authorization)Application.OpenForms[1];
                    this.Close();
                    authorization.StartPosition = FormStartPosition.Manual;
                    authorization.Location = this.Location;
                    authorization.Size = this.Size;
                    authorization.Show();
                }
                else
                {
                    MessageBox.Show("Wrong logs!");
                }
            }
            else
            {
                MessageBox.Show("You don't have a data file! Register before resetting your password!");
            }
        }

        private void LoginField_KeyPress(object sender, KeyPressEventArgs key)
        {
            char validate = key.KeyChar;

            if (Char.IsControl(validate))
            {
                if (validate == (char)Keys.Enter)
                {
                    NewPasswordField.Focus();
                }
            }
        }

        private void NewPasswordField_KeyPress(object sender, KeyPressEventArgs key)
        {
            char validate = key.KeyChar;

            if (Char.IsControl(validate))
            {
                if (validate == (char)Keys.Enter)
                {
                    ChangePasswordButton.Focus();
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
