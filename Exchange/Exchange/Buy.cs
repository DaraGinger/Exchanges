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
            Exchange rates = new Exchange();

            string usdMain = rates.UsdBuyMainText.Text;
            
            string usd = UsdBuyingText.Text;
            string uah = UahUsdBuyingText.Text;

            double usd_ = Convert.ToDouble(usd);
            double uah_ = Convert.ToDouble(uah);
            double usdMain_ = Convert.ToDouble(usdMain);

            if(UsdBuyingText.Text.Length == 0)
            {
                double quotioent = uah_/usdMain_;
                UsdBuyingText.Text = Convert.ToString(quotioent);
            }

            else
            {
                double pro = usd_*usdMain_;
                UahUsdBuyingText.Text = Convert.ToString(pro);
            }


        }

        private void CalculateEurButton_Click(object sender, EventArgs e)
        {
            Exchange rates = new Exchange();

            string eurMain = rates.EurBuyMainText.Text;

            string eur = EurBuyingText.Text;
            string uah = UahUsdBuyingText.Text;

            double eur_ = Convert.ToDouble(eur);
            double uah_ = Convert.ToDouble(uah);
            double usdMain_ = Convert.ToDouble(eurMain);

            if (UsdBuyingText.Text.Length == 0)
            {
                double quotioent = uah_/usdMain_;
                UsdBuyingText.Text = Convert.ToString(quotioent);
            }

            else
            {
                double pro = eur_*usdMain_;
                UahUsdBuyingText.Text = Convert.ToString(pro);
            }
        }

        private void CalculatePlnButton_Click(object sender, EventArgs e)
        {
            Exchange rates = new Exchange();

            string plnMain = rates.PlnBuyMainText.Text;

            string pln = PlnBuyingText.Text;
            string uah = UahUsdBuyingText.Text;

            double pln_ = Convert.ToDouble(pln);
            double uah_ = Convert.ToDouble(uah);
            double plnMain_ = Convert.ToDouble(plnMain);

            if (UsdBuyingText.Text.Length == 0)
            {
                double quotioent = uah_/plnMain_;
                UsdBuyingText.Text = Convert.ToString(quotioent);
            }

            else
            {
                double pro = pln_*plnMain_;
                UahUsdBuyingText.Text = Convert.ToString(pro);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exchange exchangePage = (Exchange)Application.OpenForms[0];
            exchangePage.Show();
            this.Hide();
        }
    }
}
