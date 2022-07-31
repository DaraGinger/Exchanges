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


        private void OkButton_Click(object sender, EventArgs e)
        {
            Exchange exchangePage = (Exchange)Application.OpenForms[0];
            exchangePage.Show();
            this.Hide();
            Validation();
        }

        private void Validation()
        {
            Exchange exchange = (Exchange)Application.OpenForms[0];
            if (UsdBuyText.Text.Length == 0)
            {

            }
            else
            {
                exchange.UsdBuyLabel.Text = UsdBuyText.Text;

            }


            if (UsdSellText.Text.Length == 0)
            {

            }
            else
            {
                exchange.UsdSellLabel.Text = UsdSellText.Text;
            }


            if (EurBuyText.Text.Length == 0)
            {

            }
            else
            {
                exchange.EurBuyLabel.Text = EurBuyText.Text;
            }


            if (EurSellText.Text.Length == 0)
            {

            }
            else
            {
                exchange.EurSellLabel.Text = EurSellText.Text;
            }


            if (PlnBuyText.Text.Length == 0)
            {

            }
            else
            {
                exchange.PlnBuyLabel.Text = PlnBuyText.Text;
            }

            if (PlnSellText.Text.Length == 0)
            {

            }
            else
            {
                exchange.PlnSellLabel.Text = PlnSellText.Text;
            }
        }

        private void UsdBuyText_KeyPress(object sender, KeyPressEventArgs key)
        {
            char validate = key.KeyChar;
            if (!Char.IsDigit(validate) && validate != 44)
            {
                key.Handled = true;
            }

            if (Char.IsControl(validate))
            {
                if (validate == (char)Keys.Enter)
                {
                    UsdSellText.Focus();
                }
            }
        }

        private void UsdSellText_KeyPress(object sender, KeyPressEventArgs key)
        {
            char validate = key.KeyChar;
            if (!Char.IsDigit(validate) && validate != 44)
            {
                key.Handled = true;
            }

            if (Char.IsControl(validate))
            {
                if (validate == (char)Keys.Enter)
                {
                    EurBuyText.Focus();
                }
            }
        }

        private void EurBuyText_KeyPress(object sender, KeyPressEventArgs key)
        {
            char validate = key.KeyChar;
            if (!Char.IsDigit(validate) && validate != 44)
            {
                key.Handled = true;
            }

            if (Char.IsControl(validate))
            {
                if (validate == (char)Keys.Enter)
                {
                    EurSellText.Focus();
                }
            }
        }

        private void EurSellText_KeyPress(object sender, KeyPressEventArgs key)
        {
            char validate = key.KeyChar;
            if (!Char.IsDigit(validate) && validate != 44)
            {
                key.Handled = true;
            }

            if (Char.IsControl(validate))
            {
                if (validate == (char)Keys.Enter)
                {
                    PlnBuyText.Focus();
                }
            }
        }

        private void PlnBuyText_KeyPress(object sender, KeyPressEventArgs key)
        {
            char validate = key.KeyChar;
            if (!Char.IsDigit(validate) && validate != 44)
            {
                key.Handled = true;
            }

            if (Char.IsControl(validate))
            {
                if (validate == (char)Keys.Enter)
                {
                    PlnSellText.Focus();
                }
            }
        }

        private void PlnSellText_KeyPress(object sender, KeyPressEventArgs key)
        {
            char validate = key.KeyChar;
            if (!Char.IsDigit(validate) && validate != 44)
            {
                key.Handled = true;
            }

            if (Char.IsControl(validate))
            {
                if (validate == (char)Keys.Enter)
                {
                    OkButton.Focus();
                }
            }
        }
    }
}
