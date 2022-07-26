namespace Exchange.LogData
{
    using System.IO;
    using System.Windows.Forms;
    using System;

    public partial class PasswordRecovery : Form
    {
        private string path = Path.GetFullPath(
            @"C:\Users\Admin\source\repos\Exchanges\Exchange\Exchange\LogData\Logs\MyLogs.txt");

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

        private void PasswordResetVerification()
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
                Authorization authorization = new Authorization();
                authorization.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong logs!");
            }
        }
    }
}
