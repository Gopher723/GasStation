using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace GasStation
{
    public partial class Refueling : Form
    {
        public Refueling()
        {
            InitializeComponent();
            label2.Text += " " + GasStation.AmountOfGasoline + " литров.";
            progressBar1.Maximum = (int)GasStation.AmountOfGasoline;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            label2.Text = "Осталось залить: " + --GasStation.AmountOfGasoline + " литров.";
            label3.Text = "Залито: " + ++GasStation.LoadedGasoline + " литров.";
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = true;
                return;
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спасибо за покупку!");

            string writePath = @"log.txt";

            try
            {

                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine($"Сумма оплаты: {GasStation.Price} ₽");
                    //label6.Text = GasStation.Price.ToString() + " ₽";
                    //label4.Text = GasStation.SelectedGasType.ToString();
                    //label5.Text = GasStation.AmountOfGasoline.ToString();
                    //label8.Text = DateTime.Now.ToString();
                }
                Console.WriteLine("Запись выполнена");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
