namespace Exchange
{
    using System;
using System.Drawing;
    using System.Windows.Forms;

    public partial class Buy : Form
    {
        private bool pressingTheLeftMouseButton = false;
        private Point mouseLocation;

        public Buy()
        {
            InitializeComponent();
        }

        ExchangeMainPage exchange = (ExchangeMainPage)Application.OpenForms[1];
       
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
            exchange.StartPosition = FormStartPosition.Manual;
            exchange.Location = this.Location;
            exchange.Size = this.Size;
            exchange.Show();
            this.Close();
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

        private void TurnButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PlnBuyingLabel_Click(object sender, EventArgs e)
        {

        }

        private void BuyingLabel_MouseDown(object sender, MouseEventArgs e)
        {
            int xMouseLocationOnScreen;
            int yMouseLocationOnScreen;

            if (e.Button == MouseButtons.Left)
            {
                xMouseLocationOnScreen = -e.X;
                yMouseLocationOnScreen = -e.Y;
                this.mouseLocation = new Point(xMouseLocationOnScreen, yMouseLocationOnScreen);
                this.pressingTheLeftMouseButton = true;
            }
        }

        private void BuyingLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.pressingTheLeftMouseButton)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(this.mouseLocation.X, this.mouseLocation.Y);
                this.Location = mousePos;
            }
        }

        private void BuyingLabel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.pressingTheLeftMouseButton = false;
            }
        }
    }
}
