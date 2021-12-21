using System;
using System.Windows.Forms;

namespace GasStation
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
            if (GasStation.Check == true)
            {
                pictureBox1.Visible = true;
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string hash = GasStation.GetHashString(textBox1.Text);

                if (hash == GasStation.Hash)
                {
                    Log frm = new Log();
                    frm.Show();
                    this.Close();
                }
                else
                {
                    textBox1.Clear();
                    throw new ArgumentException();
                }
            }
            catch(ArgumentException)
            {
                MessageBox.Show("Неверный код!", "OilCity");
            }
        }
    }
}
