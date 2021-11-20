﻿using System;
using System.Windows.Forms;

namespace GasStation
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string hash = GasStation.GetHashString(textBox1.Text);

            if(hash == GasStation.Hash)
            {
                Log frm = new Log();
                frm.Show();
                this.Close();
            }
            else
            {
                textBox1.Clear();
                MessageBox.Show("Неверный код!");
            }
        }
    }
}