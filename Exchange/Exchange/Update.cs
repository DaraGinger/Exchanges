namespace Exchange
{
    using System;
    using System.Windows.Forms;
    using System.IO;

    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Exchange exchange = (Exchange)Application.OpenForms[0];
            exchange.Show();
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            

                if (UsdBuyText.Text.Length == 0 && UsdSellText.Text.Length == 0 &&
                   EurBuyText.Text.Length == 0 && EurSellText.Text.Length == 0 &&
                   PlnBuyText.Text.Length == 0 && PlnSellText.Text.Length == 0)
                {
                    SaveButton.Enabled = false;
                }
                else
                {
                    SaveButton.Enabled = true;
                    Exchange exchange = (Exchange)Application.OpenForms[0];
                    exchange.Show();
                    this.Close();
                }
        }

        private void UsdBuyText_TextChanged(object sender, EventArgs e)
        {

            


        }
    }
}
