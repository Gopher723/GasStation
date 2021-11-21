using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GasStation
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
        }

        double price = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = GasStation.GasTypes["АИ-92"] + " ₽";
            price = GasStation.GasTypes["АИ-92"];
            button2.BackColor = Color.White;
            button1.BackColor = Color.GreenYellow;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = GasStation.GasTypes["АИ-95"] + " ₽";
            price = GasStation.GasTypes["АИ-95"];
            button1.BackColor = Color.White;
            button2.BackColor = Color.GreenYellow;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double answer = price * Convert.ToInt32(numericUpDown1.Value);
            label6.Text = answer.ToString() + " ₽";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                GasStation.SelectedGasType = GasStation.GasTypes.FirstOrDefault(x => x.Value == price).Key; ;
                GasStation.AmountOfGasoline = (double)numericUpDown1.Value;
                GasStation.Price = price * Convert.ToInt32(numericUpDown1.Value);
                if (GasStation.AmountOfGasoline == 0)
                {
                    throw new ArgumentException();
                }
                CashReceipt frm = new CashReceipt();
                frm.Show();
                this.Close();
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show("Введите количсетво литров!");
            }
            catch
            {
                MessageBox.Show("Выберите колонку/тип топлива!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.GreenYellow;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            GasStation.SelectedPetrolPump = Convert.ToInt32(button4.Text);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button5.BackColor = Color.GreenYellow;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            GasStation.SelectedPetrolPump = Convert.ToInt32(button5.Text);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.GreenYellow;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            GasStation.SelectedPetrolPump = Convert.ToInt32(button6.Text);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.GreenYellow;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            GasStation.SelectedPetrolPump = Convert.ToInt32(button7.Text);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.GreenYellow;
            button9.BackColor = Color.White;
            GasStation.SelectedPetrolPump = Convert.ToInt32(button8.Text);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.GreenYellow;
            GasStation.SelectedPetrolPump = Convert.ToInt32(button9.Text);
        }
    }
}
