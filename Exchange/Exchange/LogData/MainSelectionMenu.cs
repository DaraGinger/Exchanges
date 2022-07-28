namespace Exchange.LogData
{
    using System;
    using System.Windows.Forms;
    public partial class MainSelectionMenu : Form
    {
        public MainSelectionMenu()
        {
            InitializeComponent();
        }
        private void SignInButton_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            this.Hide();
            authorization.StartPosition = FormStartPosition.Manual;
            authorization.Location = this.Location;
            authorization.Size = this.Size;
            authorization.Show();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.StartPosition = FormStartPosition.Manual;
            registration.Location = this.Location;
            registration.Size = this.Size;
            registration.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
