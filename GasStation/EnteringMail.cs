using System;
using System.Windows.Forms;

namespace GasStation
{
    public partial class EnteringMail : Form
    {
        public EnteringMail()
        {
            InitializeComponent();
            //pictureBox1.SendToBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (GasStation.Mail == "")
                {
                   throw new ArgumentException();
                }
                GasStation.Mail = textBox1.Text;
                this.Close();
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show("Неверный формат e-mail адреса!");
            }            
        }       
    }
}
