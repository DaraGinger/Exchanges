namespace Exchange
{
    using System;
    using System.Windows.Forms;
    using System.IO;

    public partial class ExchangeMainPage : Form
    {
        Update updateForm;
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
            updateForm.Owner = this;
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
            File.Create(@"E:\Downloads\\Kourse.txt").Close();
            File.WriteAllText(@"E:\Downloads\\Kourse.txt", $"Buy \t    \t Sell \t \t \t \t \t \t \t \t \t \t \t \t \t" +
                                                           $"{UsdBuyLabel.Text} \t {UsdLabel.Text} \t {UsdSellLabel.Text} \t \t \t \t \t \t \t \t \t \t \t \t \t" +
                                                           $"{EurBuyLabel.Text} \t {EurLabel.Text} \t {EurSellLabel.Text} \t \t \t \t \t \t \t \t \t \t \t \t \t" +
                                                           $"{PlnBuyLabel.Text} \t {PlnLabel.Text} \t {PlnSellLabel.Text} ");
        }
    }
}
