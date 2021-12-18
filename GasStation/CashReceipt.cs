using System;
using System.Windows.Forms;

namespace GasStation
{
    public partial class CashReceipt : Form
    {
        public CashReceipt()
        {
            InitializeComponent();
            labelAllPrice.Text = GasStation.Price + " ₽";
            labelTypeGas.Text = GasStation.SelectedGasType.ToString();
            labelCountLitres.Text = GasStation.AmountOfGasoline.ToString();
            labelData.Text = DateTime.Now.ToString(); 
            labelOilPrice.Text = GasStation.Price + " ₽";
            labelNumberPump.Text = GasStation.SelectedPetrolPump.ToString();
            GasStation.AllPrice = GasStation.Price;
            GasStation.AllPriceWithoutDiscount = GasStation.Price;
            labelAmountDiscount.Visible = false;
        }
        private void buttonPay_Click(object sender, EventArgs e)
        {
            GasStation.date = DateTime.Parse(labelData.Text);
            this.Close();
            Refueling frm = new Refueling();
            frm.Show();
        }
        private void buttonEmail_Click(object sender, EventArgs e)
        {            
            try
            {
                GasStation.date = DateTime.Parse(labelData.Text);
                EnteringMail frm = new EnteringMail();
                frm.ShowDialog();
                SendingEmail.Send(GasStation.Mail);                
            }            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAdditionalProducts_Click(object sender, EventArgs e)
        {            
            this.Hide();
            GasStation.DopPrice = 0;
            AdditionalProducts frm = new AdditionalProducts();
            frm.ShowDialog();
            if(GasStation.DopPrice != 0)
            {
                GasStation.DopPriceAll += GasStation.DopPrice;
                label9.Text = "Доп. товары\nна сумму:";
                labelDopPrice.Text = GasStation.DopPriceAll + " ₽";
            }
            GasStation.AllPrice += GasStation.DopPrice;
            GasStation.AllPriceWithoutDiscount += GasStation.DopPrice;
            GasStation.AllPrice = GasStation.AllPriceWithoutDiscount - (GasStation.AllPriceWithoutDiscount * (GasStation.Discount / 100));            
            labelAllPrice.Text = GasStation.AllPrice + " ₽";
            labelAmountDiscount.Text = Convert.ToString(GasStation.AllPriceWithoutDiscount * (GasStation.Discount / 100)) + " ₽";
            GasStation.AmountDiscount = GasStation.AllPriceWithoutDiscount * (GasStation.Discount / 100);
            this.Show();
        }

        private void buttonDiscountCard_Click(object sender, EventArgs e)
        {
            EnterDiscountCard f = new EnterDiscountCard();
            f.ShowDialog();
            labelAllPrice.Text = Convert.ToString(GasStation.AllPriceWithoutDiscount - (GasStation.AllPriceWithoutDiscount * (GasStation.Discount / 100)));
            GasStation.AllPrice = GasStation.AllPriceWithoutDiscount - (GasStation.AllPriceWithoutDiscount * (GasStation.Discount / 100));
            if (GasStation.Discount != 0)
            {
                labelAmountDiscount.Visible = true;
                labelDiscount.Text = "Ваша скидка по карте \n составила:";
                labelAmountDiscount.Text = Convert.ToString(GasStation.AllPriceWithoutDiscount * (GasStation.Discount / 100)) + " ₽";
            }
            GasStation.AmountDiscount = GasStation.AllPriceWithoutDiscount * (GasStation.Discount / 100);
        }

    }
}
