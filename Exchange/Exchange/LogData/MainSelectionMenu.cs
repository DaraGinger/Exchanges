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
            authorization.Show();
            this.Hide();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
