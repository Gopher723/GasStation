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
                GasStation.Mail = textBox1.Text;
                if (GasStation.Mail == "")
                {
                    throw new ArgumentException();
                }
                this.Close();
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show("Неверный формат e-mail адреса!", "OilCity");
            }            
        }       
    }
}
