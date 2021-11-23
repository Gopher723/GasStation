using System;
using System.Windows.Forms;

namespace GasStation
{
    public partial class AdditionalProducts : Form
    {
        public AdditionalProducts()
        {
            InitializeComponent();
        }
        double coffeePrice = 0, croissantPrice = 0, burgerPrice = 0, price1 = 0, price2 = 0, price3 = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Латте":
                    label1.Text = "100 ₽";
                    coffeePrice = 100;
                    break;
                case "Капучино":
                    label1.Text = "99 ₽";
                    coffeePrice = 99;
                    break;
                case "Американо":
                    label1.Text = "120 ₽";
                    coffeePrice = 120;
                    break;
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            price1 = Convert.ToDouble(numericUpDown1.Value) * coffeePrice;
            label8.Text = price1 + price2 + price3 + " ₽";
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox2.SelectedItem.ToString())
            {
                case "Со сгущенкой":
                    label5.Text = "59 ₽";
                    croissantPrice = 59;
                    break;
                case "С кремом":
                    label5.Text = "55 ₽";
                    croissantPrice = 55;
                    break;
                case "С шоколадом":
                    label5.Text = "50 ₽";
                    croissantPrice = 50;
                    break;
            }
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            price2 = Convert.ToDouble(numericUpDown2.Value) * croissantPrice;
            label8.Text = price1 + price2 + price3 + " ₽";
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedItem.ToString())
            {
                case "Чизбургер":
                    label6.Text = "52 ₽";
                    burgerPrice = 52;
                    break;
                case "Чикенбургер":
                    label6.Text = "52 ₽";
                    burgerPrice = 52;
                    break;
                case "Гамбургер":
                    label6.Text = "130 ₽";
                    burgerPrice = 130;
                    break;
            }
        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            price3 = Convert.ToDouble(numericUpDown3.Value) * burgerPrice;
            label8.Text = price1 + price2 + price3 + " ₽";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GasStation.DopPrice = price1 + price2 + price3;
            this.Close();
        }
    }    
}
        

    

