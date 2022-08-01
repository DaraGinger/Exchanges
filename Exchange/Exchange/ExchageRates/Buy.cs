﻿namespace Exchange
{
    using System;
    using System.Windows.Forms;

    public partial class Buy : Form
    {
        public Buy()
        {
            InitializeComponent();
        }

        ExchangeMainPage exchange = (ExchangeMainPage)Application.OpenForms[2];
       
        private void CalculateUsdButton_Click(object sender, EventArgs e)
        {
            double kourseUsd;

            if (UsdText.Text.Length == 0)
            {
                kourseUsd = Convert.ToDouble(exchange.UsdBuyLabel.Text);

                double uah = Convert.ToDouble(UahUsdText.Text);

                double quotient = uah / kourseUsd;

                UsdText.Text = quotient.ToString();
            }
            else
            {
                kourseUsd = Convert.ToDouble(exchange.UsdBuyLabel.Text);

                double usd = Convert.ToDouble(UsdText.Text);

                double pro = kourseUsd * usd;

                UahUsdText.Text = pro.ToString();
            }
        }

        private void CalculateEurButton_Click(object sender, EventArgs e)
        {
            double kourseEur;

            if (EurText.Text.Length == 0)
            {
                kourseEur = Convert.ToDouble(exchange.EurBuyLabel.Text);

                double uah = Convert.ToDouble(UahEurText.Text);

                double quotient = uah / kourseEur;

                EurText.Text = quotient.ToString();
            }
            else
            {
                kourseEur = Convert.ToDouble(exchange.EurBuyLabel.Text);

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
                koursePln = Convert.ToDouble(exchange.PlnBuyLabel.Text);

                double uah = Convert.ToDouble(UahPlnText.Text);

                double quotient = uah / koursePln;

                UsdText.Text = quotient.ToString();
            }
            else
            {
                koursePln = Convert.ToDouble(exchange.PlnBuyLabel.Text);

                double usd = Convert.ToDouble(PlnText.Text);

                double pro = koursePln * usd;

                UahPlnText.Text = pro.ToString();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            exchange.Show();
            this.Hide();
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}