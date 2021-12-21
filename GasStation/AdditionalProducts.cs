using System;
using System.Windows.Forms;

namespace GasStation
{
    public partial class AdditionalProducts : Form
    {
        public AdditionalProducts()
        {
            InitializeComponent();
            numericUpDownCoffe.Visible = false;
            numericUpDownCroissant.Visible = false;
            numericUpDownBurger.Visible = false;
            if (GasStation.Check == true)
            {
                pictureBox4.Visible = true;
            }
        }
        double coffeePrice = 0, croissantPrice = 0, burgerPrice = 0, price1 = 0, price2 = 0, price3 = 0;
        private void comboBoxCoffe_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxCoffe.SelectedItem.ToString())
            {
                case "Латте":
                    labelPriceCoffe.Text = "100 ₽";
                    coffeePrice = 100;
                    break;
                case "Капучино":
                    labelPriceCoffe.Text = "99 ₽";
                    coffeePrice = 99;
                    break;
                case "Американо":
                    labelPriceCoffe.Text = "120 ₽";
                    coffeePrice = 120;
                    break;
            }
            numericUpDownCoffe.Visible = true;
        }
        private void numericUpDownCoffe_ValueChanged(object sender, EventArgs e)
        {
            price1 = Convert.ToDouble(numericUpDownCoffe.Value) * coffeePrice;
            labelSumma.Text = price1 + price2 + price3 + " ₽";
        }
        private void comboBoxCroissant_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxCroissant.SelectedItem.ToString())
            {
                case "Со сгущенкой":
                    labelPriceCroissant.Text = "59 ₽";
                    croissantPrice = 59;
                    break;
                case "С кремом":
                    labelPriceCroissant.Text = "55 ₽";
                    croissantPrice = 55;
                    break;
                case "С шоколадом":
                    labelPriceCroissant.Text = "50 ₽";
                    croissantPrice = 50;
                    break;
            }
            numericUpDownCroissant.Visible = true;
        }
        private void numericUpDownCroissant_ValueChanged(object sender, EventArgs e)
        {
            price2 = Convert.ToDouble(numericUpDownCroissant.Value) * croissantPrice;
            labelSumma.Text = price1 + price2 + price3 + " ₽";
        }
        private void comboBoxBurger_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxBurger.SelectedItem.ToString())
            {
                case "Чизбургер":
                    labelPriceBurger.Text = "52 ₽";
                    burgerPrice = 52;
                    break;
                case "Чикенбургер":
                    labelPriceBurger.Text = "52 ₽";
                    burgerPrice = 52;
                    break;
                case "Гамбургер":
                    labelPriceBurger.Text = "130 ₽";
                    burgerPrice = 130;
                    break;
            }
            numericUpDownBurger.Visible = true;
        }
        private void numericUpDownBurger_ValueChanged(object sender, EventArgs e)
        {
            price3 = Convert.ToDouble(numericUpDownBurger.Value) * burgerPrice;
            labelSumma.Text = price1 + price2 + price3 + " ₽";
        }
        private void buttonContinuePayment_Click(object sender, EventArgs e)
        {
            GasStation.DopPrice += price1 + price2 + price3;
            this.Close();
        }
    }    
}
        

    

