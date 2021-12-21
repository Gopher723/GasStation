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
        private void buttonClient_Click(object sender, EventArgs e)
        {            
            GasStation.AmountOfGasoline = 0; //количество литров
            GasStation.SelectedPetrolPump = 0; //номер колонки
            GasStation.LoadedGasoline = 0; //для залива топлива
            GasStation.SelectedGasType = ""; //тип топлива
            GasStation.Price = 0; //цена топлива
            GasStation.Mail = ""; //почта пользователя
            GasStation.DopPrice = 0; //цена за доп товары
            GasStation.DopPriceAll = 0;
            GasStation.AllPrice = 0; //сумма покупки
            GasStation.date = DateTime.Now; //дата покупки
            GasStation.Discount = 0; //процент скидки
            GasStation.AmountDiscount = 0; //сумма скидки по карте
            GasStation.AllPriceWithoutDiscount = 0; //конечная сумма без скидки

            MainPage frm = new MainPage();
            frm.Show();
        }
        private void buttonAdministrator_Click(object sender, EventArgs e)
        {
            Authentication frma = new Authentication();
            frma.Show();
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

        private void toggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                pictureBox1.Visible = true;
                GasStation.Check = true;
            }
            else
            {
                pictureBox1.Visible = false;
                GasStation.Check = false;
            }
        }
    }
}
