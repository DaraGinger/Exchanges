namespace Exchange
{
    using System;
    using System.Windows.Forms;

    public partial class Exchange : Form
    {
        public Exchange()
        {
            InitializeComponent();
        }

        private void UpdasteButton_Click(object sender, EventArgs e)
        {
            Update updateForm = new Update();
            updateForm.Show();
        }
    }
}
