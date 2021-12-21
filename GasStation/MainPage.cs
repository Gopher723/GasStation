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
            numericUpDownVolume.Visible = false;
            numericUpDownVolume.ValueChanged += numericUpDown1_ValueChanged;
            if (GasStation.Check == true)
            {
                pictureBox7.Visible = true;
            }
        }

        double price = 0;
        private void buttonAI92_Click(object sender, EventArgs e)
        {
            numericUpDownVolume.Visible = true;
            labelPriceLitre.Text = GasStation.GasTypes["АИ-92"] + " ₽";
            price = GasStation.GasTypes["АИ-92"];
            buttonAI95.BackColor = Color.White;
            buttonAI92.BackColor = Color.GreenYellow;
            double answer = price * Convert.ToInt32(numericUpDownVolume.Value);
            labelSumma.Text = answer.ToString() + " ₽";
        }
        private void buttonAI95_Click(object sender, EventArgs e)
        {
            numericUpDownVolume.Visible = true;
            labelPriceLitre.Text = GasStation.GasTypes["АИ-95"] + " ₽";
            price = GasStation.GasTypes["АИ-95"];
            buttonAI92.BackColor = Color.White;
            buttonAI95.BackColor = Color.GreenYellow;
            double answer = price * Convert.ToInt32(numericUpDownVolume.Value);
            labelSumma.Text = answer.ToString() + " ₽";
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double answer = price * Convert.ToInt32(numericUpDownVolume.Value);
            labelSumma.Text = answer.ToString() + " ₽";
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            try
            {
                GasStation.SelectedGasType = GasStation.GasTypes.FirstOrDefault(x => x.Value == price).Key; ;
                GasStation.AmountOfGasoline = (double)numericUpDownVolume.Value;
                GasStation.Price = price * Convert.ToInt32(numericUpDownVolume.Value);
                if (GasStation.AmountOfGasoline == 0)
                {
                    throw new ArgumentException();
                }
                if (GasStation.SelectedPetrolPump ==0)
                {
                    throw new Exception();
                }
                CashReceipt frm = new CashReceipt();
                frm.Show();
                this.Close();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Введите количество литров!", "OilCity");
            }
            catch(Exception)
            {
                MessageBox.Show("Выберите колонку!", "OilCity");
            }
        }

        private void buttonPump1_Click(object sender, EventArgs e)
        {
            buttonPump1.BackColor = Color.GreenYellow;
            buttonPump2.BackColor = Color.White;
            buttonPump3.BackColor = Color.White;
            buttonPump4.BackColor = Color.White;
            buttonPump5.BackColor = Color.White;
            buttonPump6.BackColor = Color.White;
            GasStation.SelectedPetrolPump = Convert.ToInt32(buttonPump1.Text);
        }
        private void buttonPump2_Click(object sender, EventArgs e)
        {
            buttonPump1.BackColor = Color.White;
            buttonPump2.BackColor = Color.GreenYellow;
            buttonPump3.BackColor = Color.White;
            buttonPump4.BackColor = Color.White;
            buttonPump5.BackColor = Color.White;
            buttonPump6.BackColor = Color.White;
            GasStation.SelectedPetrolPump = Convert.ToInt32(buttonPump2.Text);
        }
        private void buttonPump3_Click(object sender, EventArgs e)
        {
            buttonPump1.BackColor = Color.White;
            buttonPump2.BackColor = Color.White;
            buttonPump3.BackColor = Color.GreenYellow;
            buttonPump4.BackColor = Color.White;
            buttonPump5.BackColor = Color.White;
            buttonPump6.BackColor = Color.White;
            GasStation.SelectedPetrolPump = Convert.ToInt32(buttonPump3.Text);
        }
        private void buttonPump4_Click(object sender, EventArgs e)
        {
            buttonPump1.BackColor = Color.White;
            buttonPump2.BackColor = Color.White;
            buttonPump3.BackColor = Color.White;
            buttonPump4.BackColor = Color.GreenYellow;
            buttonPump5.BackColor = Color.White;
            buttonPump6.BackColor = Color.White;
            GasStation.SelectedPetrolPump = Convert.ToInt32(buttonPump4.Text);
        }
        private void buttonPump5_Click(object sender, EventArgs e)
        {
            buttonPump1.BackColor = Color.White;
            buttonPump2.BackColor = Color.White;
            buttonPump3.BackColor = Color.White;
            buttonPump4.BackColor = Color.White;
            buttonPump5.BackColor = Color.GreenYellow;
            buttonPump6.BackColor = Color.White;
            GasStation.SelectedPetrolPump = Convert.ToInt32(buttonPump5.Text);
        }
        private void buttonPump6_Click(object sender, EventArgs e)
        {
            buttonPump1.BackColor = Color.White;
            buttonPump2.BackColor = Color.White;
            buttonPump3.BackColor = Color.White;
            buttonPump4.BackColor = Color.White;
            buttonPump5.BackColor = Color.White;
            buttonPump6.BackColor = Color.GreenYellow;
            GasStation.SelectedPetrolPump = Convert.ToInt32(buttonPump6.Text);
        }
    }
}
