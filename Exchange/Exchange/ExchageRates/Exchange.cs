namespace Exchange
{
    using System;
    using System.Windows.Forms;
    using System.IO;
    using System.Drawing;

    public partial class ExchangeMainPage : Form
    {
        private string path = Application.StartupPath + @"\SaveKourse\Kourse.txt";
        Update updateForm;
        private bool pressingTheLeftMouseButton = false;
        private Point mouseLocation;
        public ExchangeMainPage()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            updateForm = new Update();
            updateForm.StartPosition = FormStartPosition.Manual;
            updateForm.Location = this.Location;
            updateForm.Size = this.Size;
            updateForm.Show();          
            this.Hide();         
        }

        private void BuyingButton_Click(object sender, EventArgs e)
        {
            Buy buyPage = new Buy();
            this.Hide();
            buyPage.StartPosition = FormStartPosition.Manual;
            buyPage.Location = this.Location;
            buyPage.Size = this.Size;
            buyPage.Show();

        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            Sell sellPage = new Sell();
            this.Hide();
            sellPage.StartPosition = FormStartPosition.Manual;
            sellPage.Location = this.Location;
            sellPage.Size = this.Size;
            sellPage.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            File.Create(path).Close();
            File.WriteAllText(path, $"Buy \t    \t Sell \t \t \t \t \t \t \t \t \t \t \t \t \t" +
                                    $"{UsdBuyLabel.Text} \t {UsdLabel.Text} \t {UsdSellLabel.Text} \t \t \t \t \t \t \t \t \t \t \t \t \t" +
                                    $"{EurBuyLabel.Text} \t {EurLabel.Text} \t {EurSellLabel.Text} \t \t \t \t \t \t \t \t \t \t \t \t \t" +
                                    $"{PlnBuyLabel.Text} \t {PlnLabel.Text} \t {PlnSellLabel.Text} ");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UsdFlagPicture_Click(object sender, EventArgs e)
        {

        }

        private void UsdSellLabel_Click(object sender, EventArgs e)
        {

        }

        private void EurLabel_Click(object sender, EventArgs e)
        {

        }

        private void ExchangeLabel_MouseDown(object sender, MouseEventArgs e)
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

        private void ExchangeLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.pressingTheLeftMouseButton)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(this.mouseLocation.X, this.mouseLocation.Y);
                this.Location = mousePos;
            }
        }

        private void ExchangeLabel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.pressingTheLeftMouseButton = false;
            }
        }
    }
}
