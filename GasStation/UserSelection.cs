using System;
using System.Windows.Forms;

namespace GasStation
{
    public partial class UserSelection : Form
    {
        public UserSelection()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MainPage frm = new MainPage();
            frm.Show();
            //this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Authentication frma = new Authentication();
            frma.Show();
            //this.Close();
        }
    }
}
