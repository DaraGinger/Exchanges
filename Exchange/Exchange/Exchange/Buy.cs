using System;
using System.Windows.Forms;

namespace Exchange
{
    public partial class Buy : Form
    {
        public Buy()
        {
            InitializeComponent();
        }

        private void CalculateUsdButton_Click(object sender, EventArgs e)
        {
            Exchange rates = (Exchange)Application.OpenForms[0];

            double usd = Convert.ToDouble(UsdText.Text);
            double uah = Convert.ToDouble(UahUsdText.Text);
            double usdMain = Convert.ToDouble(rates.UsdBuyMainText.Text);

            if(UsdText.Text.Length == 0)
            {
                double quotioent = uah/usdMain;
                UsdText.Text = Convert.ToString(quotioent);
            }

            else
            {
                double pro = usd*usdMain;
                UahUsdText.Text = Convert.ToString(pro);
            }


        }

        private void CalculateEurButton_Click(object sender, EventArgs e)
        {
            Exchange rates = (Exchange)Application.OpenForms[0];

            double usdMain = Convert.ToDouble(rates.EurBuyMainText.Text);

            if (UsdText.Text.Length == 0)
            {
                double uah = Convert.ToDouble(UahUsdText.Text);
                double quotioent = uah/usdMain;
                UsdText.Text = Convert.ToString(quotioent);
            }

            else
            {
                double eur = Convert.ToDouble(EurText.Text);
                double pro = eur*usdMain;
                UahUsdText.Text = Convert.ToString(pro);
            }
        }

        private void CalculatePlnButton_Click(object sender, EventArgs e)
        {
            Exchange rates = (Exchange)Application.OpenForms[0];

            double pln = Convert.ToDouble(PlnText.Text);
            double uah = Convert.ToDouble(UahUsdText.Text);
            double plnMain = Convert.ToDouble(rates.PlnBuyMainText.Text);

            if (UsdText.Text.Length == 0)
            {
                double quotioent = uah/plnMain;
                UsdText.Text = Convert.ToString(quotioent);
            }

            else
            {
                double pro = pln*plnMain;
                UahUsdText.Text = Convert.ToString(pro);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Exchange exchangePage = (Exchange)Application.OpenForms[0];
            exchangePage.Show();
            this.Hide();
        }
    }
}
