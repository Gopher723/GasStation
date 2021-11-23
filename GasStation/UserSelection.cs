using System;
using System.IO;
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
            //this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Authentication frma = new Authentication();
            frma.Show();
            //this.Hide();
        }

        private void UserSelection_FormClosing(object sender, FormClosingEventArgs e)
        {            
           
            var result = MessageBox.Show("Вы действительно хотите закрыть программу?", "OilCity", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                
                File.Delete("log.txt");
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
