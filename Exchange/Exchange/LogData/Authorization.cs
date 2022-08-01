namespace Exchange.LogData
{
    using System;
    using System.IO;
    using System.Windows.Forms;
    using Exchange;
    public partial class Authorization : Form
    {
        private string path = Application.StartupPath + @"\Logs\MyLogs.txt";

        public Authorization()
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

        private void SignInButton_Click(object sender, EventArgs e)
        {             
            if (this.LoginField.Text.Length > 0 && this.PasswordField.Text.Length > 0)
            {
                AuthorizationDataVerification();
            }
            else if (this.LoginField.Text.Length <= 0 && this.PasswordField.Text.Length <= 0)
            {
                MessageBox.Show("Empty login and password fields!");
            }
            else if (this.LoginField.Text.Length <= 0)
            {
                MessageBox.Show("Empty login field!");
            }
            else
            {
                MessageBox.Show("Empty password field!");
            }
        }

        private void ResetPasswordLabelLink_Click(object sender, EventArgs e)
        {
            PasswordRecovery passwordRecovery = new PasswordRecovery();
            this.Hide();
            passwordRecovery.StartPosition = FormStartPosition.Manual;
            passwordRecovery.Location = this.Location;
            passwordRecovery.Size = this.Size;
            passwordRecovery.Show();
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

        private void AuthorizationDataVerification()
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

            for (int i = 0; i < readData.Length / 2; i++)
            {
                if (this.LoginField.Text == loginData[i] && this.PasswordField.Text == passwordData[i])
                {
                    correctCount++;
                    break;
                }
            }

            if (correctCount == 1)
            {
                ExchangeMainPage exchange = new ExchangeMainPage();
                this.Close();
                exchange.StartPosition = FormStartPosition.Manual;
                exchange.Location = this.Location;
                exchange.Show();
            }
            else
            {
                MessageBox.Show("Wrong logs!");
            }
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
                    SignInButton.Focus();
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
    }
}
