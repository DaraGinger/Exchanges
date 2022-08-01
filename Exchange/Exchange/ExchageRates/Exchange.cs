namespace Exchange
{
    using System;
    using System.Windows.Forms;
    using System.IO;

    public partial class ExchangeMainPage : Form
    {
        private string path = Application.StartupPath + @"\SaveKourse\Kourse.txt";
        Update updateForm;
        public ExchangeMainPage()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            updateForm = new Update();
            updateForm.Show();          
            this.Hide();         
        }

        private void BuyingButton_Click(object sender, EventArgs e)
        {
            Buy buyPage = new Buy();
            this.Hide();
            buyPage.Show();

        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            Sell sellPage = new Sell();
            this.Hide();
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
    }
}
