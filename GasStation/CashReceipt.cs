using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasStation
{
    public partial class CashReceipt : Form
    {
        public CashReceipt()
        {
            InitializeComponent();
            label6.Text = GasStation.Price.ToString() + " ₽";
            label4.Text = GasStation.SelectedGasType.ToString();
            label5.Text = GasStation.AmountOfGasoline.ToString();
            label8.Text = DateTime.Now.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Refueling frm = new Refueling();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тут будет окно с почтой");
        }
    }
}
