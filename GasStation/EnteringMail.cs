using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GasStation
{
    public partial class EnteringMail : Form
    {
        public EnteringMail()
        {
            InitializeComponent();
            if (GasStation.Check == true)
            {
                pictureBox1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {                
                GasStation.Mail = textBox1.Text;

                string pattern = @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}$";
                Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
                bool matched = r.Match(GasStation.Mail).Success; // true в случае подтверждения совпадения
                if(matched != true)
                {
                    throw new ArgumentException();
                }
                if (GasStation.Mail == "")
                {
                    throw new ArgumentException();
                }
                this.Close();
            }
            catch (ArgumentException)
            {                
                MessageBox.Show("Неверный формат e-mail адреса!", "OilCity");
                textBox1.Clear();
            }            
        }       
    }
}
