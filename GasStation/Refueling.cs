using System;
using System.Windows.Forms;
using System.IO;

namespace GasStation
{
    public partial class Refueling : Form
    {
        
        //double kol = GasStation.AmountOfGasoline;
        public Refueling()
        {            
            InitializeComponent();
            label2.Text += " " + GasStation.AmountOfGasoline + " л.";
            progressBar1.Maximum = (int)GasStation.AmountOfGasoline;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            label2.Text = "Осталось залить: " + --GasStation.AmountOfGasoline + " л.";
            label3.Text = "Залито: " + ++GasStation.LoadedGasoline + " л.";
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
            try
            {
                GasStation.Revenue += GasStation.AllPrice;
                if (GasStation.AmountOfGasoline != 0)
                {
                    throw new ArgumentException();
                }
                MessageBox.Show("Спасибо за покупку!");

                //GasStation.AllPrice += GasStation.Price + GasStation.DopPrice;

                string writePath = @"log.txt";
                GasStation.receiptNumber++;
                
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine($"Чек № {GasStation.receiptNumber}");
                    sw.WriteLine($"Тип топлива:  {GasStation.SelectedGasType} \nКоличество литров: {GasStation.LoadedGasoline} \nНомер ТРК: {GasStation.SelectedPetrolPump}  \nДата покупки: {GasStation.date} \nСумма к оплате: {GasStation.AllPrice}  Руб.");
                    sw.WriteLine("----------------------------------");
                }
                                
                this.Close();
                //UserSelection frm = new UserSelection();
                //frm.Show();
            }
            catch(ArgumentException arg)
            {
                MessageBox.Show("Топливо не залито!", "OilCity");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OilCity");
            }
            
            
        }
    }
}