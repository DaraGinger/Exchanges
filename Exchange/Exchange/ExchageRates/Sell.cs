namespace Exchange
{
    using System.Windows.Forms;
    using System;

    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
        }

        ExchangeMainPage exchange = (ExchangeMainPage)Application.OpenForms[2];
        
        private void CalculateUsdButton_Click(object sender, EventArgs e)
        {
            double koursePln;

            if (PlnText.Text.Length == 0)
            {
                koursePln = Convert.ToDouble(exchange.PlnSellLabel.Text);

                double uah = Convert.ToDouble(UahPlnText.Text);

                double quotient = uah / koursePln;

                UsdText.Text = quotient.ToString();
            }
            else
            {
                koursePln = Convert.ToDouble(exchange.PlnSellLabel.Text);

                double usd = Convert.ToDouble(PlnText.Text);

                double pro = koursePln * usd;

                UahPlnText.Text = pro.ToString();
            }

        }

        private void CalculateEurButton_Click(object sender, EventArgs e)
        {
            double kourseEur;

            if (EurText.Text.Length == 0)
            {
                kourseEur = Convert.ToDouble(exchange.EurSellLabel.Text);

                double uah = Convert.ToDouble(UahEurText.Text);

                double quotient = uah / kourseEur;

                EurText.Text = quotient.ToString();
            }
            else
            {
                kourseEur = Convert.ToDouble(exchange.EurSellLabel.Text);

                double usd = Convert.ToDouble(EurText.Text);

                double pro = kourseEur * usd;

                UahEurText.Text = pro.ToString();
            }
        }

        private void CalculatePlnButton_Click(object sender, EventArgs e)
        {
            double koursePln;

            if (PlnText.Text.Length == 0)
            {
                koursePln = Convert.ToDouble(exchange.PlnSellLabel.Text);

                double uah = Convert.ToDouble(UahPlnText.Text);

                double quotient = uah / koursePln;

                UsdText.Text = quotient.ToString();
            }
            else
            {
                koursePln = Convert.ToDouble(exchange.PlnSellLabel.Text);

                double usd = Convert.ToDouble(PlnText.Text);

                double pro = koursePln * usd;

                UahPlnText.Text = pro.ToString();
            }
        }

        private void UsdText_KeyPress(object sender, KeyPressEventArgs key)
        {
            char validate = key.KeyChar;
            
            Key.EnterText(key);

            if (Char.IsControl(validate))
            {
                if (validate == (char)Keys.Enter)
                {
                    CalculateUsdButton.Focus();
                }
            }
        }

        private void UahUsdText_KeyPress(object sender, KeyPressEventArgs key)
        {
            char validate = key.KeyChar;
            
            Key.EnterText(key);

            if (Char.IsControl(validate))
            {
                if (validate == (char)Keys.Enter)
                {
                    CalculateUsdButton.Focus();
                }
            }
        }

        private void EurText_KeyPress(object sender, KeyPressEventArgs key)
        {
            char validate = key.KeyChar;
            
            Key.EnterText(key);

            if (Char.IsControl(validate))
            {
                if (validate == (char)Keys.Enter)
                {
                    CalculateEurButton.Focus();
                }
            }
        }

        private void UahEurText_KeyPress(object sender, KeyPressEventArgs key)
        {
            char validate = key.KeyChar;
            
            Key.EnterText(key);

            if (Char.IsControl(validate))
            {
                if (validate == (char)Keys.Enter)
                {
                    CalculateEurButton.Focus();
                }
            }
        }

        private void PlnText_KeyPress(object sender, KeyPressEventArgs key)
        {
            char validate = key.KeyChar;
            
            Key.EnterText(key);

            if (Char.IsControl(validate))
            {
                if (validate == (char)Keys.Enter)
                {
                    CalculatePlnButton.Focus();
                }
            }
        }

        private void UahPlnText_KeyPress(object sender, KeyPressEventArgs key)
        {
            char validate = key.KeyChar;
            
            Key.EnterText(key);

            if (Char.IsControl(validate))
            {
                if (validate == (char)Keys.Enter)
                {
                    CalculatePlnButton.Focus();
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            exchange.Show();
            this.Hide();
        }
    }
}
