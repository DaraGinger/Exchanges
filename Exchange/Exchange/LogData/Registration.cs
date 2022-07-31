namespace Exchange.LogData
{
    using System;
    using System.Windows.Forms;
    using System.IO;
    public partial class Registration : Form
    {   
        private string path = Application.StartupPath + @"\Logs\MyLogs.txt";

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
                this.Hide();
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
            MainSelectionMenu mainSelectionMenu = new MainSelectionMenu();
            this.Hide();
            mainSelectionMenu.StartPosition = FormStartPosition.Manual;
            mainSelectionMenu.Location = this.Location;
            mainSelectionMenu.Size = this.Size;
            mainSelectionMenu.Show();

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void LoginField_KeyPress(object sender, KeyPressEventArgs key)
        {
            char validate = key.KeyChar;

            Key.EnterText(key);

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

            Key.EnterText(key);

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

            Key.EnterText(key);

            if (Char.IsControl(validate))
            {
                if (validate == (char)Keys.Enter)
                {
                    SignUpButton.Focus();
                }
            }
        }
    }
}
