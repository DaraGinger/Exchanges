namespace Exchange
{
    using System;
    using System.Windows.Forms;
    
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Exchange exchangePage = (Exchange)Application.OpenForms[0];
            exchangePage.Show();
            this.Hide();
        }

        private void UsdBuyText_KeyPress(object sender, KeyPressEventArgs key)
        {
            if (Char.IsControl(key.KeyChar))
            {
                if(key.KeyChar == (char)Keys.Enter)
                {
                    if(sender.Equals(UsdSellText))
                    {
                        UsdBuyText.Focus();
                    }
                }
            }
        }
    }
}
