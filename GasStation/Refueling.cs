using System;
using System.Windows.Forms;
using System.IO;

namespace GasStation
{
    public partial class Refueling : Form
    {        
        public Refueling()
        {            
            InitializeComponent();
            label2.Text += " " + GasStation.AmountOfGasoline + " л";
            progressBar1.Maximum = (int)GasStation.AmountOfGasoline;            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            label2.Text = "Осталось залить: " + --GasStation.AmountOfGasoline + " л";
            label3.Text = "Залито: " + ++GasStation.LoadedGasoline + " л";
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                buttonStop.Enabled = false;
                buttonStart.Enabled = false;
                buttonEnd.Enabled = true;
                return;
            }            
        }
        private void buttonStart_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            buttonStop.Enabled = true;
            buttonStart.Enabled = false;
        }
        private void buttonStop_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            buttonStop.Enabled = false;
            buttonStart.Enabled = true;
            buttonEnd.Enabled = true;
        }
        private void buttonEnd_Click(object sender, EventArgs e)
        {
            try
            {
                GasStation.Revenue += GasStation.AllPrice;
                if (GasStation.SelectedGasType == "АИ-95")
                {
                    GasStation.FuelVolume95 -= GasStation.LoadedGasoline;
                }
                else
                {
                    GasStation.FuelVolume92 -= GasStation.LoadedGasoline;
                }
                
                GasStation.receiptNumber++;
                if (GasStation.AmountOfGasoline != 0)
                {
                    throw new ArgumentException();
                }
                MessageBox.Show("Спасибо за покупку!");

                string writePath = @"log.txt";
                               
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine($"Чек № {GasStation.receiptNumber}");
                    sw.WriteLine($"Тип топлива:  {GasStation.SelectedGasType} \nКоличество литров: {GasStation.LoadedGasoline} \nНомер ТРК: {GasStation.SelectedPetrolPump}  \nДата покупки: {GasStation.date} \nСумма к оплате: {GasStation.AllPrice}  Руб.");
                    sw.WriteLine("-------------------------------------------------------");
                }                                
                this.Close();
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