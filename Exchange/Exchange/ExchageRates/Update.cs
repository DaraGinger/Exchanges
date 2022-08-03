namespace Exchange
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    
    public partial class Update : Form
    {
        private bool pressingTheLeftMouseButton = false;
        private Point mouseLocation;

        public Update()
        {
            InitializeComponent();
        }

        ExchangeMainPage exchange = (ExchangeMainPage)Application.OpenForms[1];
        private void OkButton_Click(object sender, EventArgs e)
        {
            exchange.StartPosition = FormStartPosition.Manual;
            exchange.Location = this.Location;
            exchange.Size = this.Size;
            exchange.Show();
            this.Hide();
            Validation();
        }

        private void Validation()
        {
            

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
            Key kayText = new Key();
            Key.EnterText(key);

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
            Key kayText = new Key();
            Key.EnterText(key);

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
            Key kayText = new Key();
            Key.EnterText(key);

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
            Key kayText = new Key();
            Key.EnterText(key);

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
            Key kayText = new Key();
            Key.EnterText(key);

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
            Key kayText = new Key();
            Key.EnterText(key);

            if (Char.IsControl(validate))
            {
                if (validate == (char)Keys.Enter)
                {
                    OkButton.Focus();
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

        private void UpdateLabel_MouseDown(object sender, MouseEventArgs e)
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

        private void UpdateLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.pressingTheLeftMouseButton)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(this.mouseLocation.X, this.mouseLocation.Y);
                this.Location = mousePos;
            }
        }

        private void UpdateLabel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.pressingTheLeftMouseButton = false;
            }
        }
    }
}
