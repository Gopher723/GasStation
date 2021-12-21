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
    public partial class EnterDiscountCard : Form
    {
        public EnterDiscountCard()
        {
            InitializeComponent();
            if (GasStation.Check == true)
            {
                pictureBox1.Visible = true;
                pictureBox1.SendToBack();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var discount = GasStation.DiscountCard[textBoxCard.Text];
                GasStation.Discount = discount;
            }
            catch(Exception)
            {
                MessageBox.Show("Неверный номер карты!");
            }
            this.Close();
        }
    }
}
