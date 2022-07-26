namespace Exchange
{
    using System;
    using System.Windows.Forms;
    using System.IO;

    public partial class Exchange : Form
    {
        Update updateForm;
        public Exchange()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            updateForm = new Update();
            updateForm.Show();
            
            updateForm.Owner = this;
            this.Hide(); 
            
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {

            if (updateForm.UsdBuyText.Text.Length == 0)
            {
                UsdBuyMainText.Text = UsdBuyMainText.Text;
            }
            else
            {
                UsdBuyMainText.Text = updateForm.UsdBuyText.Text;
            }


            if (updateForm.UsdSellText.Text.Length == 0)
            {

            }
            else
            {
                UsdSellMainText.Text = updateForm.UsdSellText.Text;
            }


            if (updateForm.EurBuyText.Text.Length == 0)
            {

            }
            else
            {
                EurBuyMainText.Text = updateForm.EurBuyText.Text;
            }


            if (updateForm.EurSellText.Text.Length == 0)
            {

            }
            else
            {
                EurSellMainText.Text = updateForm.EurSellText.Text;
            }


            if (updateForm.PlnBuyText.Text.Length == 0)
            {

            }
            else
            {
                PlnBuyMainText.Text = updateForm.PlnBuyText.Text;
            }

            if (updateForm.PlnSellText.Text.Length == 0)
            {

            }
            else
            {
                PlnSellMainText.Text = updateForm.PlnSellText.Text;
            }
        }

        private void BuyingButton_Click(object sender, EventArgs e)
        {
            Buy buyPage = new Buy();
            buyPage.Show();

            this.Hide();

        }
    }
}
