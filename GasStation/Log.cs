using System;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace GasStation
{
    public partial class Log : Form
    {
        DateTime date = DateTime.Now;
        public Log()
        {
            InitializeComponent();
            if (GasStation.Check == true)
            {
                pictureBox1.Visible = true;
            }
        }       
        private void buttonOutputScreen_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = $"Отчет за {date.ToLongDateString()}\n\n";
            richTextBox1.Text += File.ReadAllText(@"log.txt", Encoding.Default);
            richTextBox1.Text += $"Выручка: {GasStation.Revenue} Руб.";
            richTextBox1.Text += $"\nОстаток АИ-95 в резервуаре: {GasStation.FuelVolume95} л";
            richTextBox1.Text += $"\nОстаток АИ-92 в резервуаре: {GasStation.FuelVolume92} л";
        }
        private void buttonDownload_Click(object sender, EventArgs e)
        {
            try
            {
                GasStation.CreatePdfLog();
                MessageBox.Show("Файл сохранен.", "OilCity", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OilCity");
            }
        }
        private void buttonEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Log_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete("tmplog.txt");
        }
    }
}