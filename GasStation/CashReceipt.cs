using System;
using System.Windows.Forms;

namespace GasStation
{
    public partial class CashReceipt : Form
    {
        public CashReceipt()
        {
            InitializeComponent();
            label6.Text = GasStation.Price + " ₽";
            label4.Text = GasStation.SelectedGasType.ToString();
            label5.Text = GasStation.AmountOfGasoline.ToString();
            label8.Text = DateTime.Now.ToString(); 
            labelOilPrice.Text = GasStation.Price + " ₽";
            label13.Text = GasStation.SelectedPetrolPump.ToString();
            GasStation.AllPrice = GasStation.Price;
            GasStation.AllPriceWithoutDiscount = GasStation.Price;
            labelAmountDiscount.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GasStation.date = DateTime.Parse(label8.Text);
            this.Close();
            Refueling frm = new Refueling();
            frm.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {            
            try
            {
                GasStation.date = DateTime.Parse(label8.Text);
                EnteringMail frm = new EnteringMail();
                frm.ShowDialog();
                SendingEmail.Send(GasStation.Mail);                
            }            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
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
            label6.Text = GasStation.AllPrice + " ₽";
            labelAmountDiscount.Text = Convert.ToString(GasStation.AllPriceWithoutDiscount * (GasStation.Discount / 100)) + " ₽";
            GasStation.AmountDiscount = GasStation.AllPriceWithoutDiscount * (GasStation.Discount / 100);
            this.Show();
        }

        private void buttonDiscountCard_Click(object sender, EventArgs e)
        {
            EnterDiscountCard f = new EnterDiscountCard();
            f.ShowDialog();
            label6.Text = Convert.ToString(GasStation.AllPriceWithoutDiscount - (GasStation.AllPriceWithoutDiscount * (GasStation.Discount / 100)));
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
